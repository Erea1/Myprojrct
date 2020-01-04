using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _014_反射
{
    class Program
    {
        static void Main(string[] args)
        {
            //每一个类对应一个type对象 type存储了这个类有哪些方法、数据、成员
            MyClass my = new MyClass();//类的数据是存储在对象中的
            //Type type = my.GetType();//通过调用对象获取这个对象的所属类的type对象
            ////Console.WriteLine(type.Name);//获取类名
            ////Console.WriteLine(type.Namespace);//获取所属类名空间
            ////Console.WriteLine(type.Assembly);//类所在的程序集
            //FieldInfo[] array = type.GetFields();//只能获取共有的字段
            //PropertyInfo[] array2 = type.GetProperties();
            //MethodInfo[] array3 = type.GetMethods();
            //foreach (MethodInfo info in array3)
            //{
            //    Console.Write(info.Name+"   ");
            //}
            //通过type对象可以获取对应的所有成员 除了私有的
            Assembly assem = my.GetType().Assembly;//通过类的type对象获取所在程序集的assem
            //Console.WriteLine(assem.FullName);
            Type[]types= assem.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine(type);
            }
            Console.ReadKey();
        }
    }
}
