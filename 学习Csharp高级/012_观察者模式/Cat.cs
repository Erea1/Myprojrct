using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_观察者模式
{
    class Cat
    {
        private string name;
        private string color;


        public Cat(string name,string color)
        {
            this.name = name;
            this.color = color;
        }
        //猫进屋 （被观察者状态发生改变）
        public void CatComing()
        {
            Console.WriteLine(color+"的猫"+name+"过来了");
            if(catCome!=null)
            catCome();
        }
        public event Action catCome;//声明一个事件 event只能在类的内部调用
    }
}
