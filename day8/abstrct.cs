using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    abstract internal class Abstrct
    {
       public abstract void SayAbstract();
    }
    internal class Child1 : Abstrct
    {
        public override void SayAbstract()
        {
            Console.WriteLine("SAY HELLO TO CHILD 1 CLASS ");
        }
        
    }
    internal class Child2 : Abstrct
    {
        public override void SayAbstract()
        {
            Console.WriteLine("SAY HELLO TO CHILD 2 CLASS ");
        }
    }
}
