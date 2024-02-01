using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {

        }
}
    internal class Voter
    {
        int age;

        public void GetDetails()
        {
            Console.WriteLine("Enter a age : ");
            age = Convert.ToInt32(Console.ReadLine());

        }

        public void DisplayDetails()
        {
            if (age < 1 || age > 100)
            {
                try
                {
                    throw new InvalidAgeException("Age cannot be less 1 or greater than 100");
                }
                catch (InvalidAgeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                if (age < 18)
                {
                    Console.WriteLine("Not eligible to vote");
                }
                else
                {
                Console.WriteLine("Eligible to vote");
            }
        }
    }
}
 }