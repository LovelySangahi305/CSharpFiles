using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Refparam
    {

            int num;

            public void GetDetails()
            {
                Console.WriteLine("Enter a value");
                num = Convert.ToInt32(Console.ReadLine());
            }

            private void CalculateSquare(ref int num)
            {
                num = num * num;
                Console.WriteLine($"Square of is {num}");
            }

            public void DisplayDetails()
            {
                Console.WriteLine($"Before Square : {num}");
                CalculateSquare(ref num);
                Console.WriteLine($"After Square : {num}");
            }
        }
}
