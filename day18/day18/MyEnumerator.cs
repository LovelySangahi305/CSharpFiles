using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18
{
    public interface IEnumerator
    {
        bool MoveNext();
        object Current { get; }
        void Reset();
    }

    internal class MyEnumerator : IEnumerator
    {
        private int[] numbers;
        private int position = -1;


        public object Current
        {
            get
            {
                if (position < 0 || position >= numbers.Length)
                    throw new InvalidOperationException();
                return numbers[position];
            }
        }


        public MyEnumerator(int[] numbers)
        {
            this.numbers = numbers;
        }
        public bool MoveNext()
        {
            position++;
            return (position < numbers.Length);

        }

        public void Reset()
        {
            position -= 1;
        }

    
    }
}
