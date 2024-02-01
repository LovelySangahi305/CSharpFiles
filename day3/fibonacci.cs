using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Fibonacci
    {
    int n, a = 0, b = 1;
        
        public void GetDetails()
        {
            
                Console.WriteLine("Enter a number till which you want fibonacci series : ");
                n = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("_____________DISPLAYING FIBONACCI SERIES ____________");
            Console.Write($"{a} {b} ");
            for (int i = 1; i < n; i++)
            {
                int c = a + b;
                Console.Write($" {c} ");
            a = b;
            b = c;
            }
        Console.WriteLine("");
        }
    }
