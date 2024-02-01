using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Pyramid2
    {
        int a;
        public void GetDetails()
        {
            Console.WriteLine("_____________PYRAMID PRINTING FOR NUMBERS __________ ");
            Console.WriteLine("Enter the number of lines till you want you numbers to get printed: ");
            a = int.Parse(Console.ReadLine());


        }
        public void DisplayPyramid()
        {
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }
        }
    }
}
