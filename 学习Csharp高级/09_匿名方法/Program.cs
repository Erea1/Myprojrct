using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_匿名方法
{
    class Program
    {
        static int Test1(int arg1,int arg2)
        {
            return arg1 + arg2;
        }
        static void Main(string[] args)
        {
            //Func<int, int, int> plus = Test1;
            Func<int, int, int> plus = delegate (int arg1, int arg2)
             {
                 return arg1 + arg2;
             };//匿名方法



            Console.WriteLine(plus(12, 45)); 

            Console.ReadKey();
        }
    }
}
