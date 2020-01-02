using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_LINQ
{
    class Kongfu
    {
        public int KongfuId { get; set; }
        public string KongfuName { get; set; }
        public int Lethality { get; set; }
        public override string ToString()
        {
            return string.Format("KongfuId:{0},KongfuName:{1},Lethality:{2}",KongfuId,KongfuName,Lethality);
        }
    }
}
