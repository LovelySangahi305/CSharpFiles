using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal interface Interface5
    {
        void Hello();
    }
    internal interface Interface6 : Interface5
    {
        void World();
    }
    internal class Class5 : Interface6
    {
        public void Hello()
        {
            Console.WriteLine(" INTERFACE 5 : HELLO ");
        }

        public void World()
        {
            Console.WriteLine(" INTERFACE 6 : WORLD ");
        }
    }
}
