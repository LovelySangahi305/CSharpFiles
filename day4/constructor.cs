using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Constructor
    {
        long accno;
        string name;
        public float roi;
        public string accounttype;

        public void GetDetails()
        {
            Console.WriteLine("Enter Account number");
            accno = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Accountnumber :  {accno} Name : {name} RateofInterest : {roi}");
        }
       
    }
}
