using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static day11.Delegatebasic;

namespace day11
{
    public delegate int MyDelegate(int a, int b);
    internal class Delegatebasic
    {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public int Substract(int a, int b)
            {
                return a - b;
            }
            public int Multiply(int a, int b)
            {
                return a * b;
            }
            public int Divide(int a, int b)
            {
                return a / b;
            }
        }
    }
