using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构
{
    class Program
    {
        static void Main(string[] args)
        {


            //使用自己的顺序表
            //SeqList<string>sqList = new SeqList<string>();
            LinkList<string>sqList = new LinkList<string>();
            sqList.Add("123");
            sqList.Add("456");
            sqList.Add("789");
            Console.WriteLine(sqList[0]);
            Console.WriteLine(sqList.GetEle(0));
            sqList.Insert("77777",1);
            for (int i = 0; i < sqList.GetLength(); i++)
            {
                Console.Write(sqList[i]+"  ");
            }

            Console.WriteLine();
            sqList.Delete(0);
            for (int i = 0; i < sqList.GetLength(); i++)
            {
                Console.Write(sqList[i] + "  ");
            }
            sqList.Clear();
            Console.WriteLine(sqList.GetLength());
            Console.ReadKey();


        }
    }
}
