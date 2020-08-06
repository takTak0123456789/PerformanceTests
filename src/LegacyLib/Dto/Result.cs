using System.Runtime.Serialization;

namespace LegacyLib.Dto
{
    [DataContract]
    public class Result
    {
        [DataMember(Order = 1)]
        public decimal Prop1 { get; set; }

        [DataMember(Order = 2)]
        public decimal Prop2 { get; set; }

        [DataMember(Order = 3)]
        public decimal Prop3 { get; set; }

        [DataMember(Order = 4)]
        public decimal Prop4 { get; set; }

        [DataMember(Order = 5)]
        public decimal Prop5 { get; set; }
    }
}
