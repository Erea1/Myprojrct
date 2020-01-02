using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_冒泡排序扩展
{
    class Program
    {
        static void Sort(int[] sortArray)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length-1; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        int tmop = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = tmop;
                        swapped = true;
                    }
                }
            }
            while (swapped);
            


        }

        static void CommonSoort<T>(T[] sortArray,Func<T,T,bool> compareMethod)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (compareMethod(sortArray[i], sortArray[i + 1]))
                    {
                        T tmop = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = tmop;
                        swapped = true;
                    }
                }
            }
            while (swapped);
        }

        static void Main(string[] args)
        {
            //int[] sortArry = new int[] {12,46,3,789,45,6,4,7, };
            //Sort(sortArry);
            //foreach (int item in sortArry)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            Emplayee[] emplayees = new Emplayee[]
            {
                new Emplayee("de",12),
                new Emplayee("da",45),
                new Emplayee("dc",15),
                new Emplayee("dg",19),
                new Emplayee("dt",132),
            };

            CommonSoort<Emplayee>(emplayees, Emplayee.Compare);
            foreach (Emplayee item in emplayees)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }


    
}
