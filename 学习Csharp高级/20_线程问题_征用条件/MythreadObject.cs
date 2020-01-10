using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_线程问题_征用条件
{
    class MythreadObject
    {
        private int state = 5;

        public void ChangeState()
        {
            state++;
            if (state == 5)
            {
                Console.WriteLine("state = 5 ");
            }
            state = 5;
        }
    }
}
