using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_特性
{
    //1.特性类的后缀用attribute结尾
    //2.需要继承system.attribute
    //3.一般情况下声明为sealed
    //4.一般情况下特性类用来表示目标结构的一些状态 定义字段或属性 没有方法
    [AttributeUsage(AttributeTargets.Class)]//表示特性类的对象程序结构有哪些
    class MytestAttribute:System.Attribute
    {
        public string Description { get; set; }
        public string VersionNumber { get; set; }
        public int ID { get; set; }
        public MytestAttribute(string des)
        {
            this.Description = des;
        }

    }
}
