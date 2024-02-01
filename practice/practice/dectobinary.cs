using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class dectobinary
    {
        public void function()
        {
            Console.Write("Enter the Decimal Number : ");
            int n = int.Parse(Console.ReadLine());
            int i=0;
            int[] arr = new int[n];
            while(n > 0)
            {
                arr[i] = n % 2;
                n = n / 2;
                i++;
            }

            Console.Write("Binary Represenation of the given Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }

        }
    }
}
