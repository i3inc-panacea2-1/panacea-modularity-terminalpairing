using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.TerminalPairing
{
    public interface IPairingPlugin : IPlugin
    {
        IBoundTerminalManager GetBoundTerminalManager();
    }
}
