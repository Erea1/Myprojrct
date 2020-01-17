using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_使用streamreader和streamWrite读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("TextFile1.txt");

           
            //while (true)
            //{
            //    string str = reader.ReadLine();//读取一行字符串
            //    if (str==null)break;
            //    Console.WriteLine(str);
                    
                
            //}
            //string str= reader.ReadToEnd();
            //Console.WriteLine(str);
            //while (true)
            //{   int res= reader.Read();//读取一个字符
            //    if (res==-1)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine((char)res);
            //    }
            //}
            
            

            //reader.Close();

            //streawrite 文件写入流
            StreamWriter writer = new StreamWriter("testFile2.txt");
            while (true)
            {
                string message= Console.ReadLine();
                if (message=="q")
                {
                    break;
                }
                writer.Write(message);
            }

            writer.Close();
            Console.ReadKey();
        }
    }
}
