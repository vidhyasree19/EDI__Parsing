using Newtonsoft.Json;

namespace Edi_Parsing.Models{
    public class Q2{

[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Vessel_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Country_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Date { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Date1 { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Date2 { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Lading_Quantity { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Weight { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Weight_Qualifier { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Flight_Number { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Reference_Identification_Qualifier { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Reference_Identification { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Vessel_Code_Qualifier { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Vessel_Name { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Volume { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Volume_Unit_Qualifier { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Weight_Unit_Code { get; set; }
    }
}