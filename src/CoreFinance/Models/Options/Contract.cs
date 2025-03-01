using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiananceDotNet_yFinance.Model.Options
{
    [JsonObject]
    public class Contract
    {
        [JsonProperty("contractSymbol")]
        public required string ContractSymbol { get; set; }
        [JsonProperty("strike")]
        public double Strike { get; set; }
        [JsonProperty("currency")]
        public required string Currency { get; set; }
        [JsonProperty("lastPrice")]
        public double lastPrice { get; set; }
        [JsonProperty("change")]
        public double Change { get; set; }
        [JsonProperty("percentChange")]
        public double PercentChange { get; set; }
        [JsonProperty("volume")]
        public int Volume { get; set; }
        [JsonProperty("openInterest")]
        public int openInterest { get; set; }
        [JsonProperty("bid")]
        public double Bid { get; set; }
        [JsonProperty("ask")]
        public double Ask { get; set; }
        [JsonProperty("contractSize")]
        public required string ContractSize { get; set; }
        [JsonProperty("expiration")]
        public int Expiration { get; set; }
        [JsonProperty("lastTradeDate")]
        public int LastTradeDate { get; set; }
        [JsonProperty("impliedVolatility")]
        public double ImpliedVolatility { get; set; }
        [JsonProperty("inTheMoney")]
        public bool InTheMoney { get; set; }
    }
}
