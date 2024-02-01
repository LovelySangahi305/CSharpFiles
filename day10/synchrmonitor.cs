using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class Synchrmonitor
    { 
            static object locker = new object();
            public static void ThreadMain()
            {
                Thread.Sleep(800);    // Simulate Some work
                WriteToFile();          // Access a shared resource / critical section
            }
            public static void WriteToFile()
            {
                String ThreadName = Thread.CurrentThread.Name;
                Console.WriteLine("{0} using Thread Synchronization file ", ThreadName);
                //Monitor.Enter(locker);
                try
                {
                    using (StreamWriter sw = new StreamWriter(@"Synchronization.txt ", true))
                    {
                        sw.WriteLine(ThreadName);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //  Monitor.Exit(locker);
                    Console.WriteLine("{0} using Thread Synchronization file ", ThreadName);
                }
            }

        }
    }
