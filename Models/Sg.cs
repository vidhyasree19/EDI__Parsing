using Newtonsoft.Json;

namespace Edi_Parsing.Models
{
    public class Sg
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Shipment_Status_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Status_Reason_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Dispostion_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Date { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Time { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Time_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string DateTime { get; set; }
    }
}