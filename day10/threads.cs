using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class Threadss
    {
        
            public static void Display1()
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Function1 : {i}");
                    //Thread.Sleep(1000);
                }
            }
            public static void Display2()
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Function2 : {i}");
                    // Thread.Sleep(1000);
                }
            }
        }
    }
