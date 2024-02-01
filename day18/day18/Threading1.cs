using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18
{
    internal class Threading1
    {
        static void Main()
        {
            Console.WriteLine("Start of Main");

            // Synchronous method call
            GetDataSynchronously();

            Console.WriteLine("End of Main");
        }

        static void GetDataSynchronously()
        {
            Console.WriteLine("Start of GetDataSynchronously");

            // Simulate a time-consuming operation
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("End of GetDataSynchronously");
        }

    }
}
