using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_Json
{
    //class Player
    //{
    //    public string Name { get; set; }
    //    public int Level { get; set; }
    //    public int Age { get; set; }
    //    public List<Skill> SkillList { get; set; }

    //    public override string ToString()
    //    {
    //        return $"{nameof(Name)}: {Name}, {nameof(Level)}: {Level}, {nameof(Age)}: {Age}, {nameof(SkillList)}: {SkillList}";
    //    }
    //}
    public class SkillListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 天下无双
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int damage { get; set; }

        public override string ToString()
        {
            return $"{nameof(id)}: {id}, {nameof(name)}: {name}, {nameof(damage)}: {damage}";
        }
    }

    public class Player
    {
        /// <summary>
        /// 李智
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SkillListItem> SkillList { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Level)}: {Level}, {nameof(Age)}: {Age}, {nameof(SkillList)}: {SkillList}";
        }
    }
}
