using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_多播委托
{
    class Program
    {
        static void Test1()
        {
            Console.WriteLine("test1");
        }

        static void Test2()
        {
            Console.WriteLine("test2");
        }

        static void Main(string[] args)
        {
            Action a = Test1;
            a += Test2;
            a();


            Console.ReadKey();

            

        }
    }
}
