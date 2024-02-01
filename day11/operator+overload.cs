using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11
{
    internal class OperatorPlus
    {
        public int num;

        public void GetDetails()
        {
            Console.WriteLine("Enter a value for plus/minus overloading : ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Num : {0}", num);
        }


        public OperatorPlus Add(OperatorPlus obj2)
        {
            OperatorPlus obj3 = new OperatorPlus();
            obj3.num = this.num + obj2.num;
            return obj3;

        }
        public static OperatorPlus operator -(OperatorPlus obj1, OperatorPlus obj2)
        {
            Console.WriteLine("__________ OPERATOR - OVERLOADING_________");
            OperatorPlus obj3 = new OperatorPlus();
            obj3.num = obj1.num - obj2.num;
            return obj3;
        }

        public static OperatorPlus operator +(OperatorPlus obj1, OperatorPlus obj2)
        {
            Console.WriteLine("__________ OPERATOR + OVERLOADING_________");
            OperatorPlus obj3 = new OperatorPlus();
            obj3.num = obj1.num + obj2.num;
            return obj3;
        }
    }
}
