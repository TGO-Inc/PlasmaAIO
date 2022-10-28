using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlasmaDevToolkit.ModLoader
{
    static class SocketExtensions
    {
        public static bool IsConnected(this Socket socket)
        {
            try
            {
                return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
            }
            catch (SocketException) { return false; }
        }
        public static bool ContainsValue(this ConcurrentDictionary<Guid, Client> dic, Client client, out Guid guid)
        {
            foreach(var item in dic)
            {
                if (item.Value.Equals(client))
                {
                    guid = item.Key;
                    return true;
                }
            }
            guid = Guid.Empty;
            return false;
        }
        public static bool ContainsValue(this ConcurrentDictionary<Guid, Client> dic, Socket client, out Guid guid)
        {
            foreach (var item in dic)
            {
                if (item.Value.Socket.Equals(client))
                {
                    guid = item.Key;
                    return true;
                }
            }
            guid = Guid.Empty;
            return false;
        }
        public static Client GetByValue(this ConcurrentDictionary<Guid, Client> dic, Socket client)
        {
            foreach (var item in dic)
            {
                if (item.Value.Socket.Equals(client))
                {
                    return item.Value;
                }
            }
            return null;
        }
        public static bool TryRemove(this ConcurrentDictionary<Guid, Client> dic, Socket socket, out Client client)
        {
            foreach (var item in dic)
            {
                if (item.Value.Socket.Equals(socket))
                {
                    return dic.TryRemove(item.Key, out client);
                }
            }
            client = null;
            return false;
        }
    }
}
