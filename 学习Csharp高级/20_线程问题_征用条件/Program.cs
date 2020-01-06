using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20_线程问题_征用条件
{
    class Program
    {
        static void ChangeState(object o)
        {
            MythreadObject m = o as MythreadObject;
            while (true)
            {
                lock (m)//向系统申请可不可以锁定m对象 如果没有 则可以 否则会暂停 直到申请到m对象
                {
                    m.ChangeState();//在同一时刻 只有一个线程在执行这个方法
                }
                
            }
        }
        static void Main(string[] args)
        {
            MythreadObject m = new MythreadObject();
            Thread t = new Thread(ChangeState);
            t.Start(m);

            new Thread(ChangeState).Start(m);
            Console.ReadKey();
        }
    }
}
