using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("加菲", "黄色");
            Mouse mouse1 = new Mouse("米奇","黑色",cat);
            //cat.catCome += mouse1.RunAway;
            Mouse mouse2 = new Mouse("迷离", "白色",cat);
            //cat.catCome += mouse2.RunAway;
            Mouse mouse3 = new Mouse("booki", "白色",cat);
            //cat.catCome += mouse3.RunAway;
            cat.CatComing();
            Console.ReadKey();

        }
    }
}
