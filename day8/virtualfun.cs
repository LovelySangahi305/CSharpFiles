using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal class Virtualfun
    {
        public virtual void Display()
        {
            Console.WriteLine("This is Parent Function in virtual function class ");
        }
    }

    internal class Class7 : Virtualfun
    {
        public override sealed void Display()
        {
            Console.WriteLine("Parent function overrident in Child");
        }
    }
    internal class Class8 : Class7
    {
       // public override void Display() { } //showing error
       // cannot override because it is sealed 
 
    }
}
