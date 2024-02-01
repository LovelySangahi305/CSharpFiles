using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class FuncOverload
    {
        
        public void Add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine($"{a} + {b} + {c}= {a + b + c}");
        }
        public void Add(string a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}
