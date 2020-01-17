using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_Json
{
    class Skill 
    {
        public int id;
        public int damage;
        public string name;

        public override string ToString()
        {
            return $"{nameof(id)}: {id}, {nameof(damage)}: {damage}, {nameof(name)}: {name}";
        }
    }
}
