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
        public static bool TryGetPairingPlugin(this PanaceaServices core, out IPairingPlugin plugin)
        {
            plugin = null;
            var pairingPlugin = core.PluginLoader.GetPlugins<IPairingPlugin>().FirstOrDefault();
            if (pairingPlugin == null)
            {
                return false;
            }
            plugin = pairingPlugin;
            return true;
        }
    }
}
