using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Greatest2
    {
        int num1 ,  num2;
        public void GetDetails()
        {
            Console.WriteLine(" ENTER NUMBER 1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ENTER NUMBER 2 : ");
            num2 = int.Parse(Console.ReadLine());

        }
        private int CheckGreatest(int n1, int n2)
        {
            if (n1>n2)
            {
                return n1;
            }
            else
                return n2;
        }
        public void DisplayResult()
        {
            int result = CheckGreatest(num1, num2);
            Console.WriteLine($"The greatest is {result}");
        }
    }

}

