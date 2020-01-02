using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Lambda表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lambda表达式的参数是不需要声明参数类型的
            //Func<int, int, int> plus = (arg1, arg2) =>
            //  {

            //      return (arg1+arg2);
            //  };
            //Console.WriteLine(plus(9,5));
            Func<int, int> test2 = a => a+1;//表示的参数只有一个的时候 可以不加括号 当方法语句只有一句话是 也可以不加大括号



            Console.ReadKey();
        }
    }
}
