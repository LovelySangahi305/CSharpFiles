using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Table
    {
        int a,b;
        public void GetDetails()
        {
            Console.WriteLine("_____________TABLE PRINTING FROM FIRST TO SECOND NUMBER__________ ");
            Console.WriteLine("Enter the first number : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            b = int.Parse(Console.ReadLine());

        }
        public void PrintTable(int num1, int num2)
        {
            for (int i= 1;i<=num2;i++)
            {
                int x = num1 * i;
                Console.WriteLine($"{num1}*{i} = {x}");
            }
        }
        public void DisplayDetails()
        {
             PrintTable( a, b);

        }
        }

    }
