using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class Evenno
    {
        int[] array1;
        int x;

        public void GetDetails()
        {
            Console.WriteLine("Enter array size : ");
            x = Convert.ToInt32(Console.ReadLine());
            array1 = new int[x];

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter {i + 1} value ");
                array1[i] = Convert.ToInt32(Console.ReadLine());

            }
        }

        public void DisplayEvenNumbers()
        {
            Console.WriteLine("Even numbers are : ");
            foreach (var a in array1)
            {
                if (a % 2 == 0) Console.WriteLine($"{a}");
            }
        }
    }
}
