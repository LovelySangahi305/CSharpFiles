using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class Namecheck
    {
        string[] names;
        int x;
        char k;
        public void GetDetails()
        {
            Console.WriteLine("Enter array size : ");
            x = Convert.ToInt32(Console.ReadLine());
            names = new string[x];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter arr[{i + 1}] name : ");
                names[i] = Console.ReadLine();

            }
            Console.WriteLine("Enter the character : ");
            k = Convert.ToChar(Console.ReadLine());

        }

        public void CheckDetails()
        {
            Console.WriteLine($"Names starts with {k} and length greater than 5 : ");
            foreach (var a in names)
            {
                if ((a.StartsWith(k) || a.StartsWith(k)) && a.Length > 5)
                {
                    Console.WriteLine($"{a}");
                }
            }
        }
    }
}
