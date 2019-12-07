using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Guldkortet
{
    class Server
    {

        protected Reader reader;
        protected Socket workSocket = null;
        protected const int BufferSize = 1024;
        protected byte[] buffer = new byte[BufferSize];
        protected StringBuilder sb = new StringBuilder();
        protected string data;
        protected Socket listener = null;

        public Server()
        {
            reader = new Reader();
        }

        public void listen()
        {

            byte[] bytes = new Byte[1024];
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 12345);
            listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
 
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Start listening for connections.  
                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");
                    // Program is suspended while waiting for an incoming connection.  
                    Socket handler = listener.Accept();
                    data = null;


                    Console.WriteLine("Client connected....");

                    // An incoming connection needs to be processed.  
                    while (true)
                    {
                        int bytesRec = handler.Receive(bytes);
                        data = Encoding.Unicode.GetString(bytes, 0, bytesRec);
                        handleInput(data);
                        // Echo the data back to the client.  
                        byte[] msg = Encoding.Unicode.GetBytes(data);
                        handler.Send(msg);

                        if (data.Equals("stop"))
                        {
                            Console.WriteLine("Client stopppeD");
                            break;
                        }
                    }

                    // Show the data on the console.  
                    Console.WriteLine("Text received : {0}", data);

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
      
        public CardAnswer handleInput(string input)
        {
            Console.WriteLine(input);
            return reader.GetCardAnswer("", "");
        }


    }
}
