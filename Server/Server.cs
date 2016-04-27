using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;
using ServerData;
using System.Threading;

namespace Server
{
    class Server
    {
        static Socket listenerSocket;
        static List<ClientData> _clients;

        static void Main(string[] args) 
        {
            Console.WriteLine("Starting server on " + Packet.GetIP4Address());
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _clients = new List<ClientData>();


            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(Packet.GetIP4Address()), 4242);
            listenerSocket.Bind(ip);


            Thread listenThread = new Thread(ListenThread);
            listenThread.Start();
        }   

        static void ListenThread()
        {
            for (;;)
            {
                listenerSocket.Listen(0);
                _clients.Add(new ClientData(listenerSocket.Accept()));
            }
        }

        //clientdata thread - reciees data from rech client individually
        public static void Data_IN(object cSocket)
        {
            Socket clientSocket = (Socket)cSocket;

            byte[] Buffer;
            int readBytes;

            for (;;)
            {
                Buffer = new byte[clientSocket.SendBufferSize];

                readBytes = clientSocket.Receive(Buffer);

                if (readBytes > 0)
                {
                    Packet packet = new Packet(Buffer);
                    DataManager(packet);
                }
            }
        }

        public static void DataManager(Packet p)
        {

        }
    }
}

