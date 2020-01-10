using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _022_聊天室_服务器
{
    class Client
    {
        private Socket clientSocket;
        private Thread t;
        private byte[] data = new byte[1024];

        public Client(Socket s)
        {
            clientSocket = s;
            //启动一个线程 处理客户端的接受
            t = new Thread(ReceiveMessage);
            t.Start();
               
        }
        private void ReceiveMessage()
        {
            //一直接受客户端的数据
            while (true)
            {
                //在接受数据之前 先判断socket是否断开
                if (clientSocket.Poll(10, SelectMode.SelectRead))
                {
                    clientSocket.Close();
                    break;//终止线程
                }
                int length= clientSocket.Receive(data);
                string message = Encoding.UTF8.GetString(data, 0, length);
                //TODO: 服务器接收数据的时候 把这个数据发送给客户端
                Console.WriteLine("接收到消息："+message);
                Program.BroadcastMessage(message);
                //广播消息
            }
        }
        public void SendMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            clientSocket.Send(data);
        }
        public bool Connectde
        {
            get{ return clientSocket.Connected; }
        }
    }
}
