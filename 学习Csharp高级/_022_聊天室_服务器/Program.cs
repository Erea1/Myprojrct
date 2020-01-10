using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _022_聊天室_服务器
{
    class Program
    {
        static List<Client> clientList = new List<Client>();
        /// <summary>
        /// 广播消息
        /// </summary>
        /// <param name="message"></param>
        public static void BroadcastMessage(string message)
        {
            var notConnectList = new List<Client>();
            foreach (var client in clientList)
            {
                if (client.Connectde)
                    client.SendMessage(message);
                else
                    notConnectList.Add(client);
            }
            foreach (var temp in notConnectList)
            {
                clientList.Remove(temp);
            }
        }
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpServer.Bind(new IPEndPoint(IPAddress.Parse("192.168.124.9"),7788));

            tcpServer.Listen(100);
            Console.WriteLine("Server runing");
            while (true)
            {


                Socket clientSocket = tcpServer.Accept();
                Console.WriteLine("a client Connected");
                Client client = new Client(clientSocket);//吧每个客户端通信的逻辑放到client类里面进行处理
                clientList.Add(client);
            }

            
        }


    }
}
