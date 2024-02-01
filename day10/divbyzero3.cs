using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class Divbyzero3
    {
        int Num1;
        int Num2;
        int Result;

        private void AcceptDetails()
        {
            Console.WriteLine("Enter a number");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            Num2 = Convert.ToInt32(Console.ReadLine());

        }

        public void DisplayDetails()
        {
            AcceptDetails();
            Divide();
        }

        private void Divide()
        {

            Result = Num1 / Num2;
            Console.WriteLine($"the Result of Division is : {Result}");
        }
    }
}
