using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day14_calclib;

namespace day14_clientapp
{
    public class Class1
    {
            int num1, num2, result;
            Calculator obj;

            public Class1()
            {
                obj = new Calculator();
            }

            public void GetNumbers()
            {
                Console.WriteLine("Enter first number : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                num2 = Convert.ToInt32(Console.ReadLine());

            }

            public void DisplayResult()
            {
                result = obj.Add(num1, num2);
                Console.WriteLine($"{num1} + {num2} = {result}");
            }
        }
    }
