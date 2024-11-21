
using Newtonsoft.Json;

namespace Edi_Parsing.Models
{
    public class Ge
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Number_Of_Transaction_Sets_Included { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Group_Control_Number { get; set; }


    }
}