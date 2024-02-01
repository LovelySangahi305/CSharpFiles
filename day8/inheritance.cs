using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day8
{
    internal class Inherit
    {
        protected int num;
        protected string name;

        public Inherit()
        {
            Console.WriteLine("Default constructor of Parent");
            num = 10;
            name = "lovely";
        }

        protected void Function1()
        {
            Console.WriteLine("Function1 of Parent");
        }
    }
    internal class Child : Inherit
    {
        int num2;

        public Child()
        {
            num2 = 30;
            Console.WriteLine("Constructor of Child class");
        }

        public void Function2()
        {
            base.Function1();
            Console.WriteLine($"Num1 : {num} ,  Name : {name} , Num2 : {num2}");
            Console.WriteLine("Function2 of Child");
        }
    }
}
