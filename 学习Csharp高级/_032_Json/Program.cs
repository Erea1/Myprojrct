using LitJson;
using System;
using System.Collections.Generic;
using System.IO;

namespace _032_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Skill> skillList = new List<Skill>();

            //jsondata 代表一个数组或对象
            //JsonData jsonData = JsonMapper.ToObject(File.ReadAllText("Json技能信息.txt"));//此处是对象
            //foreach (JsonData temp in jsonData)//在这jsondata代表一个数组
            //{
            //    Skill skill = new Skill();
            //    JsonData idValue= temp["id"];
            //    JsonData nameValue = temp["name"];
            //    JsonData damageValue = temp["damage"];
            //    int id = int.Parse(idValue.ToString());
            //    int damage = int.Parse(damageValue.ToString());
            //    //Console.WriteLine("技能名称："+nameValue+"技能id："+id+"伤害："+damage);
            //    skill.name = nameValue.ToString();
            //    skill.id = id;
            //    skill.damage = damage;
            //    skillList.Add(skill);
            //}

            //foreach (Skill temp in skillList)
            //{
            //    Console.WriteLine(temp);
            //}
            //json对象必须跟类里面的字段属性一致
            //Skill[]skillArry =  JsonMapper.ToObject<Skill[]>(File.ReadAllText("Json技能信息.txt"));
            //foreach (Skill temp in skillArry)
            //{
            //    Console.WriteLine(temp);
            //}
            //skillList = JsonMapper.ToObject<List<Skill>>(File.ReadAllText("Json技能信息.txt"));
            //foreach (Skill temp in skillList)
            //{
            //    Console.WriteLine(temp);
            //}
            //Player p = JsonMapper.ToObject<Player>(File.ReadAllText("主角信息.txt"));
            //Console.WriteLine(p);
            //foreach (var temp in p.SkillList)
            //{
            //    Console.WriteLine(temp);
            //}
            //Player p = new Player();
            //p.Name = "华农兄弟";
            //p.Level = 100;
            //p.Age = 50;
            //string json = JsonMapper.ToJson(p);
            //Console.WriteLine(json);

            //Player p = JsonMapper.ToObject<Player>(File.ReadAllText("主角信息.txt"));
            //Console.WriteLine(p);
            Console.ReadKey();
        }
    }
    
}
