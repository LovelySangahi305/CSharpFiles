using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal interface  Expinterfce1
    {
        void Display();
    }
    internal interface Expinterfce2
    {
        void Display();
    }

    internal class Child3 : Expinterfce1, Expinterfce2
    {
        void Expinterfce1.Display()
        {
            Console.WriteLine("****Interface 1  is displayed here****");
        }

        void Expinterfce2.Display()
        {
            Console.WriteLine("****Interface 2 is displayed here****");
        }
    }
}
