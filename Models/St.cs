using Newtonsoft.Json;

namespace Edi_Parsing.Models
{
    public class St
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string ContainerNumber { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Transaction_Set_Identifier_Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string Transaction_Set_Control_Number { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public List<B4> b4Segment { get; set; } = new List<B4>();
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public List<N9> n9Segment { get; set; } = new List<N9>();
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public Q2 q2Segment { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]


        public List<Sg> sgSegment { get; set; } = new List<Sg>();
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public List<R4> r4Segment { get; set; } = new List<R4>();
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]



        public Se seSegment { get; set; }
    }
}