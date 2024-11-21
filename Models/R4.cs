using Newtonsoft.Json;

namespace Edi_Parsing.Models{
    public class R4{
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

         public string Port_Or_Terminal_Function_Code { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Location_Qualifier { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Location_Identifier { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Port_Name { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Country_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Terminal_Name { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Pier_Number { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string State_or_Province_Code { get; set; }
    }
}