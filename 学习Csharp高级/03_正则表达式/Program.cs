using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "I am blue cat";
            ////Regex.Replace(s,"^","开始:");//搜索字符串 符合正则表岛是的情况 然后把符合的位置 替换为后面的字符
            //string res = Regex.Replace(s, "$", "结束");
            //string s = Console.ReadLine();
            //bool isMath = true;//默认标志位 表示你s是一个合法密码
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i]<'0'||s[i]>'9')//当前字符如果不是数字字符
            //    {
            //        isMath = false;
            //        break;
            //    }
            //}
            //if (isMath)
            //{
            //    Console.WriteLine("hefa");
            //}else
            //    Console.WriteLine("buhefa");
            //string pattern = @"^\d*$";//正则表达式

            //bool ismath= Regex.IsMatch(s,pattern);

            //string pattren = @"^\W*$";

            //bool ismath = Regex.IsMatch(s, pattren);
            //Console.WriteLine(ismath);
            string str = "I am a Cat";
            string pattern = @"[^ahou]";
            string s = Regex.Replace(str, pattern,"*");
            Console.WriteLine(s);


            Console.ReadKey();
        }
    }
}
