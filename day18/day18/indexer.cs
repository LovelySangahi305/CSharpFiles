using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18
{
    internal class Indexr
    {
        private string[] names = new string[10];

        //this: current instance (current object)
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }

    }
}
