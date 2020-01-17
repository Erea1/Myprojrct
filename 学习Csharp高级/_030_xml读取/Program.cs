using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _030_xml读取
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建技能信息集合
            List<Skill>skillList =new List<Skill>();
            //专门解析xml文档
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("skillinfo.txt");
            //得到根节点
            XmlNode rootNode= xmldoc.FirstChild;//获取第一个节点
            XmlNodeList skillNodeList= rootNode.ChildNodes;//获取当前节点的所有子节点的集合
            foreach (XmlNode skillNode in skillNodeList)
            {
                Skill skill = new Skill();
                XmlNodeList fildNodeList = skillNode.ChildNodes;//huoquskill下面的所有节点
                foreach (XmlNode fieldNode in fildNodeList)
                {
                    if (fieldNode.Name=="id")//通过name属性可以获取一个节点的名字
                    {
                        skill.Id = int.Parse(fieldNode.InnerText);
                    }
                    else if(fieldNode.Name=="name")
                    {
                        skill.Name = fieldNode.InnerText;
                        skill.Lang= fieldNode.Attributes[0].Value;

                    }
                    else
                    {
                        skill.Damage = int.Parse(fieldNode.InnerText);
                    }
                    
                }
                skillList.Add(skill);

            }

            foreach (Skill skill in skillList)
            {
                Console.WriteLine(skill);
            }

            Console.ReadKey();
        }
    }
}
