using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_冒泡排序扩展
{
    class Emplayee
    {
        public string Name { get; private set; }
        public int Salary { get; private set; }
        public Emplayee(string name,int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        //如果e1大于e2 返回true 否则返回false
        public static bool Compare(Emplayee e1,Emplayee e2)
        {
            if (e1.Salary > e2.Salary)
            {
                return true;
            }
            else
                return false;
        }
        public override string ToString()
        {
            return Name + ":" + Salary;
        }
    }
}
