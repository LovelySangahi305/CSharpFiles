using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal class Rectangle : InterfceShape
    {
        int length, breadth;
        int recarea;
        public void Calarea()
        {
            recarea = length * breadth;
        }
         public void Displayarea()
        {
            Console.WriteLine($" AREA OF RECATNGLE IS :: {recarea}");
        }

        public void Getdetails()
        {
            Console.WriteLine(" ENTER THE LENGTH OF RECTANGLE : ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ENTER THE BREADTH OF RECTANGLE : ");
            breadth = Convert.ToInt32(Console.ReadLine());
        }
    }
}
