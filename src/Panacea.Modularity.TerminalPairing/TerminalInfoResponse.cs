using System.Runtime.Serialization;

namespace Panacea.Modularity.TerminalPairing
{
    [DataContract]
    public class TerminalInfoResponse
    {
        [DataMember(Name = "terminalName")]
        public string TerminalName { get; set; }

        [DataMember(Name = "boundToTerminal")]
        public Terminal BoundTerminal { get; set; }

        [DataMember(Name = "relationType")]
        public TerminalRelation Relation { get; set; }

        [DataMember(Name = "terminalIp")]
        public string Ip { get; set; }
    }
}
