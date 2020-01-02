using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_事件
{
    class Program
    {
        public delegate void MyDlegate();
        //public MyDlegate mydelgate;//声明一个委托类型的变量 作为类的成员
        public event MyDlegate mydelgate;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.mydelgate = Test;
            p.mydelgate();
            Console.ReadKey();
        }
        static void Test()
        {
            Console.WriteLine("test1");
        }
    }
}
