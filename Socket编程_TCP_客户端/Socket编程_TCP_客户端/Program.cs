using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socket编程_TCP_客户端
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建socket
            Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //2.发起连接请求
            IPAddress iPAddress = IPAddress.Parse("192.168.5.23");//可以将字符串装换为ipaddress
            EndPoint point = new IPEndPoint(iPAddress, 7788);

            tcpClient.Connect(point);//通过ip+端口号定义要连接的服务端

            //3.接受消息
            byte[] data = new byte[1024];
            int length=tcpClient.Receive(data);//data用来接受数据
            //length表示接收数据的长度
            string message = Encoding.UTF8.GetString(data,0,length);//只把接收到的数据做转换
            Console.WriteLine(message);
            Console.WriteLine("向客户端发送消息");
            //向服务器端发送消息
            string message2 = Console.ReadLine();//把用户输入发送到服务端
            tcpClient.Send(Encoding.UTF8.GetBytes(message2));//转换为字节
            //Console.WriteLine("接受消息："+ message2);
            Console.ReadKey();
        }
    }
}
