using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class Array
    {
        int[] num = new int[5];

        public void GetDetails()
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Enter a number : ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("_____________displaying array through for loop__________");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"num[{i}] = {num[i]}");
            }
        }
        
        public void DisplayDetails2() 
        {
            Console.WriteLine("__________displaying array using for each _________");
            foreach (var a in num)
            {
                Console.WriteLine($"{a}");
            }
        }
    }
}
