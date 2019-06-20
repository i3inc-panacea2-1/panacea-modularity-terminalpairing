using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.TerminalPairing
{
    public interface IBoundTerminal
    {
        event EventHandler Connected;
        event EventHandler Disconnected;
        bool IsConnected { get; }
        TerminalRelation Relation { get; }
        string HostName { get; }
        Task TryConnect();
        void Off<T>(string action, Action<T> callback);
        void On<T>(string action, Action<T> callback);
        void Send<T>(string action, T obj);
    }
}
