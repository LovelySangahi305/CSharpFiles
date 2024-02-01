using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal class Shadowing
    { 
            public void Display()
            {
                Console.WriteLine("Function of Display");
            }
        }
    internal class Class10 : Shadowing
    {
        //shadowing
        public new void Display()
        {
            Console.WriteLine("Shadowing functions");
        }
    }
}
