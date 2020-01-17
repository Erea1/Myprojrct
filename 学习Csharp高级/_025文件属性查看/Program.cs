using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025文件属性查看
{
    class Program
    {
        static void Main(string[] args)
        {
            //相对路径 ：找当前程序所在的路径
            ////绝对路径 
            //FileInfo fileInfo = new FileInfo("helloworld.txt");
            //Console.WriteLine(fileInfo.Exists);

            //Console.WriteLine(fileInfo.Length);
            //Console.WriteLine(fileInfo.IsReadOnly);
            ////fileInfo.Delete();//删除输出路径的文件
            ////fileInfo.CopyTo("tt.txt");
            //fileInfo.MoveTo("tttt.txt");//重命名或移动
            DirectoryInfo dirInfo = new DirectoryInfo(@"E:\Projects\GitProject\学习Csharp高级\_025文件属性查看\bin\Debug");//查看debug文件夹信息
            Console.WriteLine(dirInfo.Exists);
            Console.WriteLine(dirInfo.Parent);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.CreationTime);
            dirInfo.CreateSubdirectory("siki");
           
            Console.ReadKey();
        }
    }
}
