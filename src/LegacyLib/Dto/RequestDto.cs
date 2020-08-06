using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LegacyLib.Dto
{

    [DataContract]
    public class RequestDto
    {
        [DataMember(Order = 1)]
        public int Year { get; set; }

        [DataMember(Order = 2)]
        public string Denomination1 { get; set; }

        [DataMember(Order = 3)]
        public string Denomination2 { get; set; }
        [DataMember(Order = 4)]
        public string MaritalStatus { get; set; }
        [DataMember(Order = 5)]
        public List<SubRequestDto> SubRequests { get; set; }
        [DataMember(Order = 6)]
        public decimal Income { get; set; }
        [DataMember(Order = 7)]
        public decimal SomeProp { get; set; }
        [DataMember(Order = 8)]
        public decimal SomeProp2 { get; set; }
        [DataMember(Order = 9)]
        public decimal SomeProp3 { get; set; }
        [DataMember(Order = 10)]
        public decimal QualifiedProp { get; set; }
        [DataMember(Order = 11)]
        public decimal QualifiedProp2 { get; set; }
        [DataMember(Order = 12)]
        public string SomeProp22 { get; set; }
        [DataMember(Order = 13)]
        public string Shortname { get; set; }


    }
}
