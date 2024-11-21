using Newtonsoft.Json;
namespace Edi_Parsing.Models
{
    public class B4
    {
       

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string SpecialHandlingCode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string InquiryRequestNumber { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string ShipmentStatusCode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]


        public string ReleaseDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string ReleaseTime { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string StatusLocation { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string EquipmentInitial { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]


        public string EquipmentNumber { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string EquipmentStatusCode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string EquipmentType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]


        public string LocationIdentifier { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string LocationQualifier { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string DateTime { get; set; }


    }
}