using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal class Circle : InterfceShape
    {
        float rad, cirarea;
        public void Calarea()
        {
            cirarea = 3.14f * rad * rad;
        }

        public void Displayarea()
        {
            Console.WriteLine($" AREA OF CIRCLE IS :: {cirarea}");
        }

       public  void Getdetails()
        {
            Console.WriteLine(" ENTER THE RADIUS FOR CIRCLE AREA : ");
            rad =  Convert.ToSingle(Console.ReadLine());
        }
    }
}
