using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _017_Thread发起线程
{
    class Program
    {
        static void DownloadFile(object filename)
        {
            Console.WriteLine("开始下载" + filename);
            Thread.Sleep(2000);
            Console.WriteLine("下载完成");
        }
        static void Main(string[] args)
        {
            //Thread t = new Thread(DownloadFile);//创建thread对象 线程并未启动
            //t.Start("xxx.种子");//开始
            //Console.WriteLine("Main");
            //Thread t = new Thread(() =>
            //{
            //    Console.WriteLine("开始下载" + Thread.CurrentThread.ManagedThreadId);
            //    Thread.Sleep(2000);
            //    Console.WriteLine("下载完成");
            //});
            //t.Start();
            //Mythread my = new Mythread("xxx.bt,","http://www.xx.bbs");
            //Thread t=  new Thread(my.DownFiled); //构造一个thread对象的时候 可以传递一个静态方法 也可以传递一个对象的普通方法
            //t.Start();
            Thread t = new Thread(DownloadFile);//这是个前台线程
            t.IsBackground = true;//设置为后台线程
            t.Start("xx");
            //t.Abort()//zhongzhixiancheng  
            t.Join();//当当前线程睡眠 
            Console.ReadKey();

        }
    }
}
