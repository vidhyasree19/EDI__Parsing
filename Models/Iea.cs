using System.Runtime.InteropServices.Marshalling;
using Newtonsoft.Json;

namespace Edi_Parsing.Models
{
    public class Iea
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Number_Of_Included_Functional_Groups { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Interchange_Control_Number { get; set; }


    }
}