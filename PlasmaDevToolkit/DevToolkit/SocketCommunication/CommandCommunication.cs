using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using PlasmaDevToolkit.Overrides;
using Console = PlasmaDevToolkit.Overrides.Console;
using PlasmaDevToolkit.DevToolkit.SocketCommunication;

namespace PlasmaDevToolkit.DevToolkit
{
    internal class CommandCommunication : Socket
    {
        private IPEndPoint localEnd;
        private ConcurrentDictionary<Guid, Client> clients;
        public CommandCommunication() : base(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        {
            clients = new ConcurrentDictionary<Guid, Client>();
            localEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 14613);
            base.Bind(localEnd);
            base.Listen(999);
            base.BeginAccept(AcceptRequest, null);
            Console.FormatMessage($"Socket Server Open.", LogType.Warning);
        }

        private void AcceptRequest(IAsyncResult res)
        {
            Socket client = null;
            try
            {
                if (base.IsBound)
                {
                    client = base.EndAccept(res);
                }
                if (client != null)
                {
                    if (!clients.ContainsValue(client, out Guid guid))
                    {
                        guid = Guid.NewGuid();
                        clients.TryAdd(guid, new Client(client, 2048, guid));
                    }
                    client.BeginReceive(clients[guid].Buffer, 0, 2048, SocketFlags.None, ClientCommand, client);
                    Console.FormatMessage($"Client [{guid}] has connected.", LogType.Warning);
                }
            }
            catch (SocketException exception)
            {
                Console.FormatMessage(exception);
            }
            finally
            {
                if (base.IsBound)
                {
                    base.BeginAccept(AcceptRequest, null);
                }
            }
        }
        private void ClientCommand(IAsyncResult res)
        {
            Socket client = null;
            try
            {
                client = (Socket)res.AsyncState;
                if (client != null)
                {
                    int size = base.EndReceive(res);
                    CommandHandler.HandleCommand(clients.GetByValue(client).Buffer.Take(size).ToArray());
                }
            }
            catch (SocketException e)
            {
                if (clients.TryRemove(client, out Client cl))
                {
                    Console.FormatMessage($"Client [{cl.Guid}] disconnected.", LogType.Warning);
                }
            }
            finally
            {
                if (client != null)
                {
                    try
                    {
                        base.BeginReceive(clients.GetByValue(client).Buffer, 0, 2048, SocketFlags.None, ClientCommand, client);
                    }
                    catch
                    {
                        if (clients.TryRemove(client, out Client cl))
                        {
                            Console.FormatMessage($"Client [{cl.Guid}] disconnected.", LogType.Warning);
                        }
                    }
                }
            }
        }
    }
}
