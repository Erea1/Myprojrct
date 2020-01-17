using System;
using System.IO;

namespace _028_FileStream读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建文件流
            FileStream stream = new FileStream("TextFile1.txt",FileMode.Open);
            while (true)
            {
                byte[] data = new byte[1024];
                int length = stream.Read(data, 0, data.Length);
                if (length == 0)
                {
                    Console.WriteLine("读取结束");
                    break;
                }
                for (int i = 0; i < length; i++)
                {
                    Console.Write(data[i]+" ");
                }
            }
            //2.读取/写入数据
            
            



            Console.ReadKey();
        }
    }
}
