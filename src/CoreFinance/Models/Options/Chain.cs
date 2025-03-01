using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiananceDotNet_yFinance.Model.Options
{
    [JsonObject]
    public class OptionChain
    {
        [JsonProperty ("underlyingSymbol")]
        public required string UnderlyingSymbol { get; set; }
        [JsonProperty("expirationDates")]
        public required List<int> ExpirationDates { get; set; }
        [JsonProperty("strikes")]
        public required List<double> Strikes { get; set; }
        [JsonProperty("hasMiniOptions")]
        public bool HasMiniOptions { get; set; }
        [JsonProperty("quote")]
        public required Quote Quote { get; set; }
        [JsonProperty("options")]
        public required List<Option> Options { get; set; }
    }
}
