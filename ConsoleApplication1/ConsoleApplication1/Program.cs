using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipserver = new IPEndPoint(IPAddress.Parse("192.168.1.108"), 80);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.SendTimeout = 1000;
            client.ReceiveTimeout = 1000;
            try
            {
                client.Connect(ipserver);
                Console.WriteLine(ipserver.ToString() + " is opened.");
                client.Close();
            }
            catch 
            {
                Console.WriteLine(ipserver.ToString() + " is closed.");
            }
        }
    }
}
