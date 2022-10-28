using Newtonsoft.Json;
using PlasmaDevToolkit.ModLoader.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlasmaDevToolkit.Overrides;
using Console = PlasmaDevToolkit.Overrides.Console;

namespace PlasmaDevToolkit.ModLoader.SocketCommunication
{
    internal class CommandHandler
    {
        internal static void HandleCommand(byte[] data)
        {
            string msg = Encoding.Default.GetString(data);
            Command userCommand = JsonConvert.DeserializeObject<Command>(msg);
            switch(userCommand.CommandEx)
            {
                case CommandEx.importObj:
                    string path = string.Join("", userCommand.Args);
                    Console.FormatMessage($"Imporing \"{path}\"", UnityEngine.LogType.Warning);
                    ObjImporter.ImportModel(path);
                    break;
            }
        }
    }
}
