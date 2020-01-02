using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_委托
{
    class Program
    {
        private delegate string GetAstring();//定义了一个委托类型 名字叫做get啊string
        static void Main(string[] args)
        {
            //int x = 40;
            ////x.ToString();
            ////Console.WriteLine(x);
            ////GetAstring a = new GetAstring(x.ToString);//a指向了x中的tostring方法
            //GetAstring a = x.ToString;
            ////string s = a();//通过委托实力调用x轴的tostring方法
            //string s = a.Invoke();//通过invoke方法调a所引用的方法
            //Console.WriteLine(s);

            //2. 使用委托类型作为方法的参数
            PrintString methood = Methood1;
            PrintStr(methood);
            methood = Methood2;
            PrintStr(methood);


            Console.ReadKey();
            
        }
        private delegate void PrintString();
        static void PrintStr(PrintString print)
        {
            print();
        }
        static void Methood1()
        {
            Console.WriteLine("methood1");
        } static void Methood2()
        {
            Console.WriteLine("methood2");
        }
    }
}
