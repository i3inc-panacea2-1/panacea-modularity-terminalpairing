using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Panacea.Modularity.TerminalPairing
{
    [DataContract]
    public class Terminal
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "mac_addresses")]
        public List<string> MacAddresses { get; set; }

        [DataMember(Name = "terminalIp")]
        public string Ip { get; set; }
    }
}
