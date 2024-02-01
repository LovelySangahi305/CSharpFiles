using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    public class For
    {
        string name;
        int num;
        public void DisplayDetails()
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i} . {name}");
            }
        }

        public void GetDetails()
        {
            Console.WriteLine("__________FOR LOOP PROGRAM____________");
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
        }
    }
}