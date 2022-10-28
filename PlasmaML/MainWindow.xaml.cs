using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using PlasmaML.SocketCommunication;
using Newtonsoft.Json;

namespace PlasmaML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var d = new OpenFileDialog
            {
                Multiselect = false,
                InitialDirectory = "E:\\Documents\\GitHub\\PlasmaML\\OBJ_test",
                CheckFileExists = true,
                Filter = "OBJ File|*.obj"
            };
            if (d.ShowDialog() == true)
            {
                string file = d.FileName;
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 14613);
                Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Client.Connect(endPoint);
                Command command = new Command()
                {
                    CommandEx = CommandEx.importObj,
                    Args = new string[] { file }
                };
                byte[] message = Encoding.Default.GetBytes(JsonConvert.SerializeObject(command));
                Client.Send(message, message.Length, SocketFlags.None);
                Client.Disconnect(false);
            }
        }
    }
}
