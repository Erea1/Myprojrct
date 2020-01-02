using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "学习string的第一节课";//使用string类型存储字符串类型 双引号引起来
            //int length = s.Length;
            //if (s=="xxx")
            //{
            //    Console.WriteLine("相同");
            //}
            //else
            //    Console.WriteLine("不相同");
            //Console.WriteLine(length);
            //s = "heep//" + s;
            //Console.WriteLine(s);

            //char c = s[3];
            //Console.WriteLine(c);
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}
            string s = "www.devsiki.com";
            
            //int res = s.CompareTo("siki");//当两个字符串相等时返回0 当s字符排名靠前时候返回-1 否则返回1
            //Console.Write(res);
            //string newStr= s.Replace(".d","--");//把指定字符换位另一字符  或者将指定字符串换位指定字符串
            //Console.WriteLine(newStr);
            //string[] strAry =  s.Split('.');
            //for (int i = 0; i < strAry.Length; i++)
            //{
            //    Console.WriteLine(strAry[i]);
            //}
            //string str= s.Substring(4,7);//按给定的索引和长度取字符串
            //Console.WriteLine(str);

            //Console.WriteLine(s.ToUpper());
            //string str = s.Trim();//删除首尾的空白
            //Console.WriteLine(str);
            int index = s.IndexOf("devsiki");
            Console.WriteLine(index);//如果包含 返回字符串第一个字符索引 否则返回-1 
            Console.ReadKey();
        }
    }
}
