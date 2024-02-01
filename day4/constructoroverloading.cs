using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Bank
    {

        long accno;
        string name;
        float roi;

        //default constructor
        public Bank()
        {
            roi = 2.5f;
            Console.WriteLine("Default Constructor executed");

        }

        //parameterized constructor
        public Bank(float roi)
        {
            this.roi = roi;
            Console.WriteLine("Constructor with one parameter executed");
        }

        //parameterized constructor
        public Bank(string s, float roi)
        {
            this.roi = roi;

            Console.WriteLine("Constructor with two parameters executed");
        }

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

