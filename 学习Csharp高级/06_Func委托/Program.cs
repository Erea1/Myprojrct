using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Func委托
{
    class Program
    {
        static int Test1()
        {
            return 1;
        }
        static int Test2(string str)
        {
            Console.WriteLine(str);
            return 100;
        }
        static int Test3(int i,int j)
        {
            return i + j;
        }
        static void Main(string[] args)
        {
            //Func<int> a = Test1;   //返回值必须带int
            //Console.WriteLine(a());
            //Func<string, int> a = Test2;//func后可以跟很多类型 前面的是参数类型 最有一个是返回值类型
            Func<int, int, int> a = Test3;

            Console.WriteLine(a(1,3));
            Console.ReadKey();

        }
    }
}
