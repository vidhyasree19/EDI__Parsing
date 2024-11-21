using Newtonsoft.Json;

namespace Edi_Parsing.Models
{
    public class N9
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Reference_Identification_Qualifier { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Reference_Identification { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Free_Form_Identification { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Date { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Time { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Time_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Reference__Identification_Qualifier { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Reference__Identification { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Free_Form_Identification_Qualifier { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Reference_Identification1 { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Free_Form_Identification_Qualifier1 { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Reference_Identification_ { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string DateTime { get; set; }
    }
}