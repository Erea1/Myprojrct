using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _017_Thread发起线程
{
    class Mythread
    {
        private string filename;
        private string filepath;
        public Mythread(string filename,string filepath)
        {
            this.filename = filename;
            this.filepath = filepath;
        }
        public void DownFiled()
        {
            Console.WriteLine("开始");
            Thread.Sleep(2000);
            Console.WriteLine("jieshu ");
        }
    }
}
