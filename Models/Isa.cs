
using Newtonsoft.Json;

namespace Edi_Parsing.Models
{
    public class Isa
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Authorization_Information_Qualifer { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Authorization_Information { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Security_Information_Qualifer { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Security_Information { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Interchange_Id_Qualifier { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Interchange_Sender_Qualifier { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Interchange_Id_Qualifier_Receiver { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Interchange_Receiver_Id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Date { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Time { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Interchange_Control_Standard_Id_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Interchange_Version { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Interchange_Control_Nbr { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Acknowledgement_Requested { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Test_Indicator { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Sub_Element_Separator { get; set; }



    }
}