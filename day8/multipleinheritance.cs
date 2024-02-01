using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal interface Multipleinherit1
    {
        void Fun1();
    }
    internal interface Multipleinherit2
    {
        void Fun2();
    }
    internal class Child4: Multipleinherit1, Multipleinherit2
    {
        public void Fun1()
        {
            Console.WriteLine("*** INTERAFCE 1 IS EXECUTED *** ");
        }
        public void Fun2()
        {
            Console.WriteLine("*** INTERAFCE 2 IS EXECUTED *** ");
        }
    }
}
