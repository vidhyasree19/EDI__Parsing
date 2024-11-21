using Edi_Parsing.Models;

namespace Edi_Parsing{

    public class Segments{
        public Isa isaSegment { get; set; } 
        public Gs gsSegment { get; set; }
        public List<St> stSegment { get; set; } = new List<St>();
        //public B4 b4Segment { get; set; }
        // public N9 n9Segment { get; set; }
        // public Q2 q2Segment { get; set; }
        // public Sg sgSegment { get; set; }
        // public R4 r4Segment { get; set; }
        // public Se seSegment { get; set; }
        public Ge geSegment { get; set; }
        public Iea ieaSegment { get; set; }
    }
}