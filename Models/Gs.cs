

using Newtonsoft.Json;

namespace Edi_Parsing.Models
{
    public class Gs
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Functional_Identifier_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Functional_Senders_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Functional_Receivers_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Group_Date { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Group_Time { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Group_Control_Number { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Responsible_Agency_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Version { get; set; }


    }
}