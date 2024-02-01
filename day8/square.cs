using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal class Square : InterfceShape
    {
         int side , sqarea;
        public void Calarea()
        {
            sqarea = side * side;
        }

        public void Displayarea()
        {
            Console.WriteLine($" AREA OF SQUARE IS :: {sqarea}");
        }

        public void Getdetails()
        {
            Console.WriteLine(" ENTER THE SIDE FOR SQAURE AREA : ");
            side = Convert.ToInt32(Console.ReadLine());
        }
    }
}
