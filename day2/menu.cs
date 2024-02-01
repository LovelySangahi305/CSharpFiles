using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Menu
    {
        int num1, num2;
        char ch;


        public void GetDetails()
        {
            Console.WriteLine("Enter the first number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator : ");
            ch = Convert.ToChar(Console.ReadLine());
        }

        private int PerformOperation(int n1, int n2, char c)
        {
            switch (c)
            {
                case '+':
                    return n1 + n2;
                    break;
                case '-':
                    return n1 - n2;
                    break;
                case '*':
                    return n1 * n2;
                    break;
                case '/':
                    return n1 / n2;
                    break;
                default:
                    Console.WriteLine("INAPPROPRIATE OPERATOR");
                    return 0;
                    break;

            }
        }
        public void DisplayDetails()
        {
            int res = PerformOperation( num1 ,  num2 , ch);
            Console.WriteLine($"RESULT AFTER PERFORMING OPERATION : {res}");

        }

    }
}
