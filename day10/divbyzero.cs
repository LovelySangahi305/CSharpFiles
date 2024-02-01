using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class Divbyzero
    {
            int Num1;
            int Num2;
            int Result;

            private void AcceptDetails()
            {
                try
                {
                    Console.WriteLine("Enter a number1 : ");
                    Num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a number2 : ");
                    Num2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Incorrect format");
                    Console.WriteLine(fe.Message);
                }
            }

            public void DisplayDetails()
            {
                AcceptDetails();
                Divide();
            }

            private void Divide()
            {

                try
                {
                    Result = Num1 / Num2;
                    Console.WriteLine($"the Result of Division is : {Result}");
                }
                catch (DivideByZeroException de)
                {
                    Console.WriteLine("Cannot divide a number by zero");
                    Console.WriteLine(de.Message);
                }

            }
        }
}
