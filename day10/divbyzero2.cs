using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class Divbyzero2
    {
        int Num1;
        int Num2;
        int Result;

        private void AcceptDetails()
        {
            Console.WriteLine("Enter a number1 : ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number2 : ");
            Num2 = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            try
            {
                AcceptDetails();
                Divide();
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Incorrect format");
                Console.WriteLine(fe.Message);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("Cannot divide a number by zero");
                Console.WriteLine(de.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void Divide()
        {
            Result = Num1 / Num2;
            Console.WriteLine($"the Result of Division is : {Result}");
        }
    }
}
