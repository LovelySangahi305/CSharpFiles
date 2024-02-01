using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace day6
{
    internal class Genericswap
    {
        public void Swap<T>(T a, T b)
        {
            Console.WriteLine($"Before swap a : {a} b: {b}");
            T temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Before swap a : {a} b: {b}");
        }
    }

    
}
