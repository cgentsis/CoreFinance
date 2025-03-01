using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiananceDotNet_yFinance.Model.Options
{
    [JsonObject]
    public class Quote
    {
        [JsonProperty ("language")]
        public required string language { get; set; }
        [JsonProperty("region")]
        public required string region { get; set; }
        [JsonProperty("quoteType")]
        public required string quoteType { get; set; }
        [JsonProperty("typeDisp")]
        public required string typeDisp { get; set; }
        [JsonProperty("quoteSourceName")]
        public required string quoteSourceName { get; set; }
        [JsonProperty("triggerable")]
        public bool triggerable { get; set; }
        [JsonProperty("customPriceAlertConfidence")]
        public required string customPriceAlertConfidence { get; set; }
        [JsonProperty("currency")]
        public required string currency { get; set; }
        [JsonProperty("messageBoardId")]
        public required string messageBoardId { get; set; }
        [JsonProperty("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }
        [JsonProperty("regularMarketPrice")]
        public double regularMarketPrice { get; set; }
        [JsonProperty("marketState")]
        public required string marketState { get; set; }
        [JsonProperty("exchange")]
        public required string exchange { get; set; }
        [JsonProperty("shortName")]
        public required string shortName { get; set; }
        [JsonProperty("longName")]
        public required string longName { get; set; }
        [JsonProperty("exchangeTimezoneName")]
        public required string exchangeTimezoneName { get; set; }
        [JsonProperty("exchangeTimezoneShortName")]
        public required string exchangeTimezoneShortName { get; set; }
        [JsonProperty("gmtOffSetMilliseconds")]
        public int gmtOffSetMilliseconds { get; set; }
        [JsonProperty("market")]
        public required string market { get; set; }
        [JsonProperty("esgPopulated")]
        public bool esgPopulated { get; set; }
        [JsonProperty("postMarketChangePercent")]
        public double postMarketChangePercent { get; set; }
        [JsonProperty("postMarketTime")]
        public int postMarketTime { get; set; }
        [JsonProperty("postMarketPrice")]
        public double postMarketPrice { get; set; }
        [JsonProperty("postMarketChange")]
        public double postMarketChange { get; set; }
        [JsonProperty("regularMarketChange")]
        public double regularMarketChange { get; set; }
        [JsonProperty("regularMarketTime")]
        public int regularMarketTime { get; set; }
        [JsonProperty("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }
        [JsonProperty("regularMarketDayRange")]
        public required string regularMarketDayRange { get; set; }
        [JsonProperty("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }
        [JsonProperty("regularMarketVolume")]
        public int regularMarketVolume { get; set; }
        [JsonProperty("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }
        [JsonProperty("bid")]
        public double bid { get; set; }
        [JsonProperty("ask")]
        public double ask { get; set; }
        [JsonProperty("bidSize")]
        public int bidSize { get; set; }
        [JsonProperty("askSize")]
        public int askSize { get; set; }
        [JsonProperty("fullExchangeName")]
        public required string fullExchangeName { get; set; }
        [JsonProperty("financialCurrency")]
        public required string financialCurrency { get; set; }
        [JsonProperty("regularMarketOpen")]
        public double regularMarketOpen { get; set; }
        [JsonProperty("averageDailyVolume3Month")]
        public int averageDailyVolume3Month { get; set; }
        [JsonProperty("averageDailyVolume10Day")]
        public int averageDailyVolume10Day { get; set; }
        [JsonProperty("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }
        [JsonProperty("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }
        [JsonProperty("fiftyTwoWeekRange")]
        public required string fiftyTwoWeekRange { get; set; }
        [JsonProperty("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }
        [JsonProperty("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }
        [JsonProperty("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }
        [JsonProperty("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }
        [JsonProperty("dividendDate")]
        public int dividendDate { get; set; }
        [JsonProperty("sourceInterval")]
        public int sourceInterval { get; set; }
        [JsonProperty("exchangeDataDelayedBy")]
        public int exchangeDataDelayedBy { get; set; }
        [JsonProperty("averageAnalystRating")]
        public required string averageAnalystRating { get; set; }
        [JsonProperty("tradeable")]
        public bool tradeable { get; set; }
        [JsonProperty("cryptoTradeable")]
        public bool cryptoTradeable { get; set; }
        [JsonProperty("earningsTimestamp")]
        public int earningsTimestamp { get; set; }
        [JsonProperty("earningsTimestampStart")]
        public int earningsTimestampStart { get; set; }
        [JsonProperty("earningsTimestampEnd")]
        public int earningsTimestampEnd { get; set; }
        [JsonProperty("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }
        [JsonProperty("trailingPE")]
        public double trailingPE { get; set; }
        [JsonProperty("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }
        [JsonProperty("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }
        [JsonProperty("epsForward")]
        public double epsForward { get; set; }
        [JsonProperty("epsCurrentYear")]
        public double epsCurrentYear { get; set; }
        [JsonProperty("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }
        [JsonProperty("sharesOutstanding")]
        public long sharesOutstanding { get; set; }
        [JsonProperty("bookValue")]
        public double bookValue { get; set; }
        [JsonProperty("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }
        [JsonProperty("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }
        [JsonProperty("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }
        [JsonProperty("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }
        [JsonProperty("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }
        [JsonProperty("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }
        [JsonProperty("marketCap")]
        public long marketCap { get; set; }
        [JsonProperty("forwardPE")]
        public double forwardPE { get; set; }
        [JsonProperty("priceToBook")]
        public double priceToBook { get; set; }
        [JsonProperty("firstTradeDateMilliseconds")]
        public long firstTradeDateMilliseconds { get; set; }
        [JsonProperty("priceHint")]
        public int priceHint { get; set; }
        [JsonProperty("displayName")]
        public required string displayName { get; set; }
        [JsonProperty("symbol")]
        public required string symbol { get; set; }
    }

}
