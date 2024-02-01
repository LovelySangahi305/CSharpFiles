using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace day8
{
    sealed internal class Class4
    {
        public Class4()
        {
            Console.WriteLine(" this is sealed class .");
        }
    }
   // internal class Class5 : Class4 { }
   //cannot inherit class4 as it is sealed 
}
