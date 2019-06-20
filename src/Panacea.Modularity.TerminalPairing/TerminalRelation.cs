using System.Runtime.Serialization;

namespace Panacea.Modularity.TerminalPairing
{
    [DataContract]
    public enum TerminalRelation
    {
        [DataMember(Name = "slave")]
        Slave,
        [DataMember(Name = "master")]
        Master
    }
}
