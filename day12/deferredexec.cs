using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12
{
    internal class Deferredexec
    {
        string[] trainees = new string[4] { "lovely", "lauren", "benstock", "lucky" };

        public void DisplayNames()
        {
            var names = from t in trainees
                        select t;

            foreach (string t in names)
            {
                Console.Write(" " + t);
            }

            trainees[1] = "Malti";
            trainees[2] = "Monika";

            Console.WriteLine();

            foreach (string t in names)
            {
                Console.Write(" " + t);
            }
        }
    }
}
