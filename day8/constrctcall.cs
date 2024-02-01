using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal class Class1
    {
        int num1;

        public Class1(int num1)
        {
            this.num1 = num1;
            Console.WriteLine("Constructor of class1");
        }

        public void Display()
        {
            Console.WriteLine($"Num1 : {num1}");
        }
    }

    internal class Class2 : Class1
    {
        int num2;

        public Class2(int num1, int num2) : base(num1)
        {
            this.num2 = num2;
            Console.WriteLine("Constructor of class2");
        }

        public void Display2()
        {
            base.Display();
            Console.WriteLine($"Num2 : {num2}");
        }
    }

    internal class Class3 : Class2
    {
        int num3;

        public Class3(int num1, int num2, int num3) : base(num1, num2)
        {
            this.num3 = num3;
            Console.WriteLine("Constructor of class3");
        }

        public void Display3()
        {
            base.Display2();
            Console.WriteLine($"Num3 : {num3}");
        }
    }
}
