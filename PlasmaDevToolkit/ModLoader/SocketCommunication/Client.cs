using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PlasmaDevToolkit.ModLoader
{
    internal class Client
    {
        public byte[] Buffer;
        public Socket Socket;
        public Guid Guid;
        public Client(Socket socket, int size, Guid guid)
        {
            Socket = socket;
            Buffer = new byte[size];
            Guid = guid;    
        }
    }
}
