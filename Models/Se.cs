using Newtonsoft.Json;

namespace Edi_Parsing.Models{
    public class Se{

[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
         public string Number_Of_Included_Segments { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Transaction_Set_Control_Number { get; set; }
    }
}