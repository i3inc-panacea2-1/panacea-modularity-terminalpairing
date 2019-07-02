using Panacea.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.TerminalPairing
{
    public static class PanaceaServicesExtensions
    {
        public static IPairingPlugin GetPairingPlugin(this PanaceaServices core)
        {
            return core.PluginLoader.GetPlugin<IPairingPlugin>();
        }
        public static bool TryGetPairing(this PanaceaServices core, out IBoundTerminalManager manager)
        {
            manager = core.PluginLoader.GetPlugins<IPairingPlugin>().FirstOrDefault()?.GetBoundTerminalManager();
            return manager != null;
        }
    }
}
