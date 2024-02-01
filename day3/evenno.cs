using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Evenno
    {
        int a, b;

        public void GetDetails()
        {

            Console.WriteLine("Enter the first number  : ");
            a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number  : ");
        b = Convert.ToInt32(Console.ReadLine());


    }
        public void DisplayDetails()
        {
            Console.WriteLine("_____________DISPLAYING SERIES BETWEEN NUMBERS____________");
            for (int i = a; i < b; i++)
            {
            if (i % 2 == 0)
            { Console.Write($" {i} "); }
            
            }
        }
    }

