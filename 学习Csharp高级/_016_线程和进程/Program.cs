using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _016_线程和进程
{
    class Program
    {
        //一般会把比较耗时的操作 开启单独的线程去执行 比如下载
        static int Test(int i,string str)
        {
            Console.WriteLine("test"+i+str);
            Thread.Sleep(100);//让当前线程休眠 单位ms
            return 100;
        }
        static void Main(string[] args)//在main线程中执行一个县城里面语句的执行 是从上到下的
        {
            //下载文件 code
            //Func<int,string,int> a = Test;
            ////可以取得当前线程的状态
            //IAsyncResult ar= a.BeginInvoke(100,"siki",null, null);//开启一个新的线程去执行 a所用的方法
            //可以认为线程时同步执行的（异步）
            Console.WriteLine("main");
            //while (ar.IsCompleted==false)//没有完毕
            //{
            //    Console.Write(".");
            //    Thread.Sleep(10);//控制频率
            //}
            //int res= a.EndInvoke(ar);//取得异步线程的返回值
            //Console.WriteLine(res);
            //bool isEnd= ar.AsyncWaitHandle.WaitOne(1000);//检测线程结束 如果等待了1000ms还没结束 则返回false 否则会返回true

            //if (isEnd)
            //{
            //    int res=a.EndInvoke(ar);
            //    Console.WriteLine(res);
            //}
            //通过回调检测线程结束

            Func<int, string, int> a = Test;
            //可以取得当前线程的状态
            //倒数第二个参数是委托类型的参数 表是回调函数 当线程结束时会调用这个委托指向
            //倒数第一个参数用来给回调函数传递数据
            //IAsyncResult ar = a.BeginInvoke(100, "siki", OnCallBack, a);
            a.BeginInvoke(100, "siki", ar => {
                int res = a.EndInvoke(ar);
                Console.WriteLine(res+"在lambda表达式中取得");

            }, null);




            Console.ReadKey();

            //移动文件 code

        }
        static void OnCallBack(IAsyncResult ar)
        {
            // Console.WriteLine("子线程end");
            Func<int,string,int> a = ar.AsyncState as Func<int, string, int>;
            int res = a.EndInvoke(ar);
            Console.WriteLine(res+"在回调函数中取得结果");
        }
    }
}
