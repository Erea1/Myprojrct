using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02字符串StringBulder
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. StringBuilder sb = new StringBuilder("devsiki,con");//利用函数创建stringbuilder
            //2.StringBuilder sb = new StringBuilder(20);//出是一个空的stringbuilder对象 占20个字符大小
            StringBuilder sb = new StringBuilder("www.siki.com", 100);
            //sb.Append("*/xxx.html");
            //sb.Insert(0, "http/");
            //Console.WriteLine(sb);
            sb.Replace('.','-');

            //sb.Remove(0, 3);
            Console.WriteLine(sb);
            Console.ReadKey();

        }
    }
}
