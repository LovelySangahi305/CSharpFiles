using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18
{
    internal class MyCollection : IEnumerable
    {
        private int[] numbers = { 1, 2, 3, 4, 5 };
        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(numbers);
        }
    }
}
