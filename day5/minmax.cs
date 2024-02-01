using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace day5
{
    internal class Minmax
    {
        int []arr;
        int n;
        public void GetDetails()
        {
            Console.WriteLine("Enter the size of the array : ");
            n= int.Parse(Console.ReadLine());
            arr = new int[n];
            for(int i=0;i< arr.Length;i++)
            {
                Console.Write($"Enter the arr[{i}] : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Displayminmax()
        {
            
            Array.Sort(arr);
            Console.WriteLine($"Sorted array is :");
            foreach (var a in arr)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Maximum value from the array is : {arr[0]}");
            Console.WriteLine($"Minimum value from the array is : {arr[n-1]}");
        }
    }
}
