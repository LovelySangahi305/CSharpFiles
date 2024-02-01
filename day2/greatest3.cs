using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Greatest3
    {
        int num1, num2, num3;
        public void GetDetails()
        {
            Console.WriteLine(" ENTER NUMBER 1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ENTER NUMBER 2 : ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ENTER NUMBER 3 : ");
            num3 = int.Parse(Console.ReadLine());
        }
        private int CheckGreatest(int n1, int n2 , int n3)
        {
            if (n1 > n2 && n1 > n3)
            {
                return n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                return n2;
            }
            else
                return n3;
        }
        public void DisplayResult()
        {
            int result = CheckGreatest(num1, num2 , num3);
            Console.WriteLine($"The greatest number is {result}");
        }
    }
}
