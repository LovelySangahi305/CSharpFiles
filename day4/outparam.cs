using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Outparam
    {
        int num1, num2, l, m, n, o;

        public void GetDetails()
        {
            Console.WriteLine("Enter first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

        private void Calculate(int a, int b, out int c, out int d, out int e, out int f)
        {
            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;
        }

        public void DisplayOutput()
        {
            Console.WriteLine($"______________OUT PARAMETER PROGRAM_________________");
            Calculate(num1, num2, out l, out m, out n, out o);
            Console.WriteLine($"Add = {l}");
            Console.WriteLine($"Substract = {m}");
            Console.WriteLine($"Multiply = {n}");
            Console.WriteLine($"Divide = {o}");
        }
    }
}
