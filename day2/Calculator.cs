using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day2;

namespace day2
{
    class Calculator
    {
        int num1;
        int num2;

        public void GetDetails()
        {
            Console.WriteLine("enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

        }

        private void Add(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        private int Substract()
        {
            return num1 - num2;
        }

        private int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }


        private int Divide(int num1, int num2 = 20)
        {
            return num1 / num2;
        }

        public void DisplayResults()
        {
            Add(num1, num2);
            int sub = Substract();
            int mul = Multiply(num1, num2);
            int div = Divide(num1);
            Console.WriteLine($"{num1} - {num2} = {sub}");
            Console.WriteLine($"{num1} * {num2} = {mul}");
            Console.WriteLine($"{num1} / {num2} = {div}");

        }
    }
}


