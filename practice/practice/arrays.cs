using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Arrays
    {
            
                
        public void display()
        {
            int n;
            n = int.Parse(Console.ReadLine());
                int[] arr;
            
                if (n < 1 || n > 20)
                {
                    Console.WriteLine("INVALID_INPUT");
                }
                else
                {
                    arr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    Array.Sort(arr);
                    if (n % 2 == 0)
                    {
                        
                        for (int j = 0; j < n; j++)
                        {
                        Console.Write(arr[j]+" ");
                        }
                            
                        
                    }

                    else
                    {
                    Array.Reverse(arr);
                        foreach(int val in arr)
                    { 
                            Console.Write(val+" ");
                        }
                            
                        }
                    }
                }
            }
        }
    
