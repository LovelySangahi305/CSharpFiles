using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11
{
    internal class OperatorGreater
    {
        public int num;

        public void GetDetails()
        {
            Console.WriteLine("Enter a value for >/< overloading : ");
            num = Convert.ToInt32(Console.ReadLine());
        }



        public static bool operator >(OperatorGreater obj1, OperatorGreater obj2)
        {
            Console.WriteLine("__________ OPERATOR > OVERLOADING_________");
            if (obj1.num > obj2.num)
                return true;
            else
                return false;

        }
        public static bool operator <(OperatorGreater obj1, OperatorGreater obj2)
        {
            Console.WriteLine("__________ OPERATOR < OVERLOADING_________");
            if (obj1.num < obj2.num)
                return true;
            else
                return false;
        }
    }
}
