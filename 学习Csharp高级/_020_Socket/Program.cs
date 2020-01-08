using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _020_Socket
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建socket
            Socket tcpServer = new Socket
                (AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            //2.绑定ip、端口号 192.168.5.23
            IPAddress iPAddress = new IPAddress(new byte[] {192,168,5,23 });
            EndPoint point = new IPEndPoint(iPAddress,7788);//是对ip加端口号做了封装的类
            tcpServer.Bind(point);//绑定 向操作系统申请一个可用的ip和端口号用来做通信
            //3.开始监听 等待客户端连接
            tcpServer.Listen(100);//参数是最大连接数

            Socket clientSocket= tcpServer.Accept();//暂停当前线程 直到有客户端连接进来 之后进行下面的代码
            Console.WriteLine("一个客户端连接进来");
            string message = "Hello world";
            byte[] data= Encoding.UTF8.GetBytes(message);
            clientSocket.Send(data);

            byte[] data2 = new byte[1024];//创建一个用来承接客户端发送的消息
            int length = clientSocket.Receive(data2);
            string message2 = Encoding.UTF8.GetString(data2, 0, length);
            Console.WriteLine("接受消息：" + message2);
            Console.ReadKey();
        }
    }
}
