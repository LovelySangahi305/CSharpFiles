using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
       class Demo <T>
        {
       T a;
       T b;
            
 
        public Demo(T a, T b)
            {
                this.a = a;
                this.b = b;
            }
            public void Display()
            {
                Console.WriteLine($"A = {a}");
                Console.WriteLine($"B = {b}");
              }
            }
    
    }
