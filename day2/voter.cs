using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day2;

public class Voter
{
    string username;
        int age;
    public void AcceptDetails()
    {
        Console.WriteLine(" ENTER A USERNAME : ");
        username = Console.ReadLine();
        Console.WriteLine(" ENTER YOUR AGE : ");
        age = int.Parse(Console.ReadLine());

    }
    private bool CheckEligibilty(int age)
    {
        if (age >=18)
        {
            return true;
        }
        else
            return false;
    }
    public void DisplayResult()
    {
        if (!CheckEligibilty(age))
        {
            Console.WriteLine(" YOU ARE INELIGIBLE TO VOTE!");
        }
        else
        {
            Console.WriteLine(" YOU ARE ELIGIBLE TO VOTE ");
        }
    }
}
