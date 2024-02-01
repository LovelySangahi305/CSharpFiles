using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18
{
    internal class Threading2
    {
        static async Task Main()
        {
            Console.WriteLine("Start of Main");

            // Asynchronous method call
            await GetDataAsynchronously();

            Console.WriteLine("End of Main");
        }

        static async Task GetDataAsynchronously()
        {
            Console.WriteLine("Start of GetDataAsynchronously");

            // Simulate an asynchronous operation
            await Task.Delay(3000);

            Console.WriteLine("End of GetDataAsynchronously");

        }
    }
}
