using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiananceDotNet_yFinance.Model.Options
{
    [JsonObject]
    public class Option
    {
        [JsonProperty ("expirationDate")]
        public int ExpirationDate { get; set; }
        [JsonProperty("hasMiniOptions")]
        public bool HasMiniOptions { get; set; }
        [JsonProperty("calls")]
        public required List<Contract> Calls { get; set; }
        [JsonProperty("puts")]
        public required List<Contract> Puts { get; set; }
    }

}
