using System;
using System.Runtime.Serialization;

namespace LegacyLib.Dto
{
    [DataContract]
    public class SubRequestDto
    {
        [DataMember(Order = 1)]
        public string Name { get; set; }

        [DataMember(Order = 2)]
        public int ChildID { get; set; }

        [DataMember(Order = 3)]
        public int SomeID { get; set; }

        [DataMember(Order = 4)]
        public int? ContractID { get; set; }

        [DataMember(Order = 5)]
        public DateTime DateOfBirth { get; set; }

        [DataMember(Order = 6)]
        public int Until { get; set; }

        [DataMember(Order = 7)]
        public bool IsLiving { get; set; }

        [DataMember(Order = 8)]
        public bool IsHalfAlive { get; set; }

    }
}
