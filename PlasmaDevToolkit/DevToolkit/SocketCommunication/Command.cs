using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlasmaDevToolkit.DevToolkit.SocketCommunication
{
    internal class Command
    {
        public CommandEx CommandEx;
        public string[] Args;
    }
    internal enum CommandEx
    {
        importObj
    }
}
