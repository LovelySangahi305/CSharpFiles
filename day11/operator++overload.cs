using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11
{
    internal class Incrementoverload
    {
        public int num;

        public void GetDetails()
        {
            Console.WriteLine("Enter a value for increment/decrement overloading : ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Num : {0}", num);
        }

        public static Incrementoverload operator ++(Incrementoverload obj1)
        {
            Console.WriteLine("__________ OPERATOR ++ OVERLOADING_________");
            Incrementoverload obj2 = new Incrementoverload();
            obj2.num = obj1.num++;
            return obj2;
        }
        public static Incrementoverload operator --(Incrementoverload obj1)
        {
            Console.WriteLine("__________ OPERATOR -- OVERLOADING_________");
            Incrementoverload obj2 = new Incrementoverload();
            obj2.num = obj1.num--;
            return obj2;


        }

    }
}
