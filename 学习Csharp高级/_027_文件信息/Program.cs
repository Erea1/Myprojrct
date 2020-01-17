using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_文件信息
{
    class Program
    {
        static void Main(string[] args)
        {
            //string [] strAry =  File.ReadAllLines("TextFile.txt");//把每一行文本读取成字符串
            //foreach (var s in strAry)
            //{
            //    Console.WriteLine(s);
            //}
            //string s = File.ReadAllText("TextFile.txt");
            //Console.WriteLine(s);
            //byte[] byteArry =  File.ReadAllBytes("2019_08_22_14_46.45.bmp");
            //foreach (var b in byteArry)
            //{
            //    Console.Write(b);
            //}
            //File.WriteAllText("textFile2.txt", @"你好\n中国");
            //File.WriteAllLines("textFile3.txt", new string[] {"123","456 " });
            byte[] byteArry = File.ReadAllBytes("2019_08_22_14_46.45.bmp");
            File.WriteAllBytes("test4.png",byteArry);
            Console.ReadKey();
        }
    }
}
