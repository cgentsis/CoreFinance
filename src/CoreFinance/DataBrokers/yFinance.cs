using CoreFinance.Models;
using FiananceDotNet_yFinance.Model.Options;
using Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CoreFinance.DataBrokers
{
    public class YFinance : ISymbolDataProvider
    {
        #region Constants
        private readonly string _symbol;
        private readonly string _baseUrl = "https://query1.finance.yahoo.com";
        private readonly string _historyUri = "/v8/finance/chart/{0}?interval=1d&{1}";
        private readonly string _optionsUri = "/v7/finance/options/{0}";
        private readonly string _rangeUriSegment = "range={0}d";
        private readonly string _periodUriSegment = "period1={0}&period2={1}";
        #endregion

        internal HttpClient _httpClient { get; set; }

        #region ctor
        public YFinance(string symbol)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_baseUrl);
            //Note for future generations... do not remove the user agent, yahoo will return 429 with out one. 
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; AcmeInc/1.0)");
            _httpClient.Timeout = TimeSpan.FromMinutes(1);
            _symbol = symbol;
        }
        #endregion

        #region Public

        #region History
        public async Task<IEnumerable<HistoricalValue>?> GetHistoryAsync(int DaysOfHystory)
        {
            return V8ChartJsonToHistoricalValues(await GetRawAsync(string.Format(_historyUri, _symbol, string.Format(_rangeUriSegment, DaysOfHystory))));
        }

        public async Task<IEnumerable<HistoricalValue>?> GetHistoryAsync(DateTime start, DateTime end)
        {
            return V8ChartJsonToHistoricalValues(await GetRawAsync(string.Format(_historyUri, _symbol, string.Format(_periodUriSegment, ((DateTimeOffset)start).ToUnixTimeSeconds(), ((DateTimeOffset)end).ToUnixTimeSeconds()))));
        }
        #endregion

        #region Options
        public async Task GetOptionChain()
        {
            var jObject = JsonConvert.DeserializeObject<JObject>(await GetRawAsync(string.Format(_optionsUri, _symbol)));
            var result = jObject?["optionChain"]?["result"]?[0]?.ToObject<OptionChain>();
        }
        #endregion
        #endregion

        #region Internals 
        internal async Task<string> GetRawAsync(string uri)
        {
            var response = await _httpClient.GetAsync(uri);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase); //In the future i shall make this a bit more specific 
            }
            return await response.Content.ReadAsStringAsync();
        }

        internal static IEnumerable<HistoricalValue>? V8ChartJsonToHistoricalValues(string jsonString)
        {
            var result = new List<HistoricalValue>();
            var jobject = JsonConvert.DeserializeObject<JObject>(jsonString);
            var epochs = jobject?["chart"]?["result"]?[0]?["timestamp"]?.Values<long>();
            var open = jobject?["chart"]?["result"]?[0]?["indicators"]?["quote"]?[0]?["open"]?.Values<decimal>().ToList();
            var close = jobject?["chart"]?["result"]?[0]?["indicators"]?["quote"]?[0]?["close"]?.Values<decimal>().ToList();
            var low = jobject?["chart"]?["result"]?[0]?["indicators"]?["quote"]?[0]?["low"]?.Values<decimal>().ToList();
            var high = jobject?["chart"]?["result"]?[0]?["indicators"]?["quote"]?[0]?["high"]?.Values<decimal>().ToList();
            var volume = jobject?["chart"]?["result"]?[0]?["indicators"]?["quote"]?[0]?["volume"]?.Values<ulong>().ToList();

            var index = 0;

            if (epochs == null)
            {
                return null;
            }
            foreach (var date in epochs)
            {

                var item = new HistoricalValue()
                {
                    Date = DateTimeOffset.FromUnixTimeSeconds(date).DateTime,
                    Open = open?[index],
                    Close = close?[index],
                    Low = low?[index],
                    High = high?[index],
                    Volume = volume?[index]
                };
                result.Add(item);
                index++;
            }
            return result;
        }
        #endregion
    }
}