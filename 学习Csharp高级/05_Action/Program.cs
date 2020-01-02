using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Action
{
    class Program
    {
        static void PrintString()
        {
            Console.WriteLine("Hello world");
        }
        static void PrintInt(int args)
        {

        }
        static void PrintString(string str) {

            Console.WriteLine(str);
        }
        static void PrintDouble(int a ,int b)
        {
            Console.WriteLine(a+b);
        }
        static void Main(string[] args)
        {
            //int x = 100;//action 只能指向没有返回值 没有参数的方法
            //Action a = PrintString;
            Action<int> a = PrintInt; //定义一个委托类型 这个类型指向一个没有返回值，有一个int类型参数
            Action<string> b = PrintString;///定义一个委托类型 这个类型指向一个没有返回值，有一个string类型参数
            Action<int, int> c = PrintDouble;

            c(1,2);
            //Action<int,int,int,string,bool,>可以通过泛型去指定action的参数
             Console.ReadKey();
        }
    }
}
