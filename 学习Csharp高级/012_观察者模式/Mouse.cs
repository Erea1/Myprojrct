using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_观察者模式
{
    //观察者类
    class Mouse
    {
        private string name;
        private string color;

        public Mouse(string name,string color,Cat cat)
        {
            this.name = name;
            this.color = color;
            cat.CatCome += this.RunAway;
        }

        public void RunAway()
        {
            Console.WriteLine(color+"的老鼠"+name+"跑了");
        }
    }
}
