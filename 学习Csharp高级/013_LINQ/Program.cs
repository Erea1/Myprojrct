using System;
using System.Collections.Generic;
using System.Linq;

namespace _013_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化武林高手
            var masterList = new List<MartialArtsMaster>(){
            new MartialArtsMaster(){ Id = 1, Name = "黄蓉",    Age = 18, Menpai = "丐帮", Kongfu = "打狗棒法",  Level = 9  },
            new MartialArtsMaster(){ Id = 2, Name = "洪七公",  Age = 70, Menpai = "丐帮", Kongfu = "打狗棒法",  Level = 10 },
            new MartialArtsMaster(){ Id = 3, Name = "郭靖",    Age = 22, Menpai = "丐帮", Kongfu = "降龙十八掌",Level = 10 },
            new MartialArtsMaster(){ Id = 4, Name = "任我行",  Age = 50, Menpai = "明教", Kongfu = "葵花宝典",  Level = 1  },
            new MartialArtsMaster(){ Id = 5, Name = "东方不败",Age = 35, Menpai = "明教", Kongfu = "葵花宝典",  Level = 10 },
            new MartialArtsMaster(){ Id = 6, Name = "林平之",  Age = 23, Menpai = "华山", Kongfu = "葵花宝典",  Level = 7  },
            new MartialArtsMaster(){ Id = 7, Name = "岳不群",  Age = 50, Menpai = "华山", Kongfu = "葵花宝典",  Level = 8  },
            new MartialArtsMaster() { Id = 8, Name = "令狐冲", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 },
            new MartialArtsMaster() { Id = 9, Name = "梅超风", Age = 23, Menpai = "桃花岛", Kongfu = "九阴真经", Level = 8 },
            new MartialArtsMaster() { Id =10, Name = "黄药师", Age = 23, Menpai = "梅花岛", Kongfu = "弹指神通", Level = 10 },
            new MartialArtsMaster() { Id = 11, Name = "风清扬", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 }
            };
            //初始化武学
            var kongfuList = new List<Kongfu>(){
                new Kongfu(){KongfuId=1, KongfuName="打狗棒法", Lethality=90},
                new Kongfu(){KongfuId=2, KongfuName="降龙十八掌", Lethality=95},
                new Kongfu(){KongfuId=3, KongfuName="葵花宝典", Lethality=100},
                new Kongfu() { KongfuId=  4, KongfuName = "独孤九剑", Lethality = 100 },
                new Kongfu() { KongfuId = 5, KongfuName = "九阴真经", Lethality = 100 },
                new Kongfu() { KongfuId = 6, KongfuName = "弹指神通", Lethality = 100 }
            };
            int[] arryA = new int[] { 2, 5, 9, 3, 7, 6, 4 };
            //查询所有武林绝学大于8的高手
            //var res = new List<MartialArtsMaster>();
            //foreach (var temp in masterList)
            //{
            //    if (temp.Level>8)
            //    {
            //        res.Add(temp);
            //    }
            //}
            //使用LINQ做查询 (表达式写法)

            //var res = from m in masterList//from 后面设置查询的集合
            //          where m.Level > 8 && m.Menpai == "丐帮"//where后跟查询的条件
            //          //orderby m.Age
            //          orderby m.Level,m.Age  //按照多个字段实行排序 如果第一个属性相同 则按第二个属性排序
            //          select m;//biaoshi把m结果的集合返回
            //var res = masterList.Where(Test1);
            //var res = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮");

            //3.联合查询
            //var res = from m in masterList
            //          from k in kongfuList
            //          where m.Kongfu == k.KongfuName&&k.Lethality>90
            //          select m;//取得所学功夫杀伤力大于90的大侠

            //4.扩展方法用法
            //var res= masterList.SelectMany(m => kongfuList, (m, k) => 
            //new { master = m, kongfu = k }).Where(x=>x.master.Kongfu== x.kongfu.KongfuName&&x.kongfu.Lethality>90);

            //var res = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮").OrderBy(m => m.Age);
            //var res = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮").OrderBy(m => m.Level).ThenBy(m=>m.Age);

            //5.join on
            //var res = from m in masterList
            //          join k in kongfuList on m.Kongfu equals k.KongfuName
            //          where k.Lethality>90
            //          select new { master = m, kongfu = k };

            //6.
            //var res = from k in kongfuList
            //          join m in masterList on k.KongfuName equals m.Kongfu
            //          into groups
            //          orderby groups.Count()
            //          select new { kongfu = k,count=groups.Count()};
            //7.按属性分组
            var res = from m in masterList
                      group m by m.Kongfu into g
                      select new { count = g.Count(), key = g.Key };// g.key表示是按照哪个属性分的组
            //8.量词操作符
            //bool res= masterList.Any(m => m.Menpai == "丐帮");
            //bool res = masterList.All(m => m.Menpai == "丐帮");
            //Console.WriteLine(res);
            foreach (var temp in res)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
        //过滤方法
        static bool Test1(MartialArtsMaster master)
        {
            if (master.Level > 8)
            {
                return true;
            }
            else
                return false;
        }
    }
}
