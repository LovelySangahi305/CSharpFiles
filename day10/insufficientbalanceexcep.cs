using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class Insufficientbalanceexcep : Exception
    {
        public Insufficientbalanceexcep(string message) : base(message)
        {
        }
    }
    internal class Balance
    {
        double accbalance = 50000;
        int withdraw;
        public void GetDetails()
        {
            Console.WriteLine("Enter the balance  : ");
            withdraw = Convert.ToInt32(Console.ReadLine());

        }

        public void DisplayDetails()
        {
        
                if (accbalance < withdraw)
                {
                try { 
                    throw new Insufficientbalanceexcep("Insufficient balance");
                }
                catch (Insufficientbalanceexcep e)
            {
                Console.WriteLine(e.Message);
            }
        }
            
            else
            {
                accbalance = accbalance - withdraw ;
    }
}
}
    }
