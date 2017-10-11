using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;


namespace EchoClient
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Program C = new Program();
            C.Client();
        }

        public void Client()
        {
            TcpClient client = new TcpClient("localhost", 11000);
            Console.WriteLine("Client Up");
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

            while (true)
            {
                
                Console.WriteLine("Ready to send");
                string LineToSend = Console.ReadLine();
                writer.WriteLine(LineToSend);
                Console.ReadKey();
            }
            client.Close();
        }
    }
}


                //TIL AT SENDE BESKEDER
                //Console.WriteLine("Ready to send");
                //string LineToSend = Console.ReadLine();
                //writer.WriteLine(LineToSend);
                //Console.ReadKey();