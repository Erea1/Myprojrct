#define IsTest1//定义一个宏


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _015_特性
{
    //通过属性名字 给属性赋值
    [Mytest("简单的特性类",ID =100)]//使用时不需要加后缀
    class Program
    {
        [Obsolete("这个方法过时了 使用NewMethod",true)]//表示一个方法被弃用
        static void OldMethod()
        {
            Console.WriteLine("Oldmethod");
        }
        static void NewMethod()
        {

        }
        [Conditional("IsTest1")]
        static void Test1()
        {
            Console.WriteLine("test1");
        }
        static void Test2()
        {
            Console.WriteLine("test2");
        }
        [DebuggerStepThrough]//可以跳过debug的单步调试 不让进入该方法  当确定这个方法没有错误时使用
        static void PrintOut(string str,[CallerFilePath]string fileName="",
            [CallerLineNumber]int lineNumber=0,[CallerMemberName]string methodName="")
        {
            Console.WriteLine(str);
            Console.WriteLine(fileName);
            Console.WriteLine(lineNumber);
            Console.WriteLine(methodName);
        }
        static void Main(string[] args)
        {
            //OldMethod();
            //Test1();
            //Test2();
            //Test1();

            //PrintOut("123");
            Type type = typeof(Program);//通过typeof 获取type对象
            object[]array=type.GetCustomAttributes(false);
            MytestAttribute mytestAttribute = array[0] as MytestAttribute;
            Console.WriteLine(mytestAttribute.Description);
            Console.WriteLine(mytestAttribute.ID);
            Console.ReadKey();
        }
    }
}
