using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _测试数组转化
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "5b";


           
            //byte数组转int

            byte[] e = HexStringToByteArray(test);
            Console.WriteLine((int)e[0]);
            //Console.WriteLine(e[0].ToString("x2"));
            
            //int a = BitConverter.ToInt32(strToToHexByte(test),0);

            //byte[] b = Encoding.Default.GetBytes(test);
            //int c = BitConverter.ToInt32(b, 0);

           //Console.WriteLine(Convert.ToInt32(test,16));
            //Console.WriteLine(a);




            Console.ReadKey();

        }
        //网上找的16进制字符串转byte数组
        public static byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[1];
            buffer[0] = (byte)Convert.ToByte(s.Substring(0, 2), 16);
            
            return buffer;
        }
       
    }
}
