using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Primeno
    {
    int a, b,num;

    public void GetDetails()
    {

        Console.WriteLine("Enter the first number  : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number  : ");
        b = Convert.ToInt32(Console.ReadLine());
    }
    private bool CheckPrime(int n)
    {
        for(int i=a;i<b;i++)
        {
            if(i%b == 0)
                return true;
            else
                return false;
        }
    }
    public void DisplayDetails()
    {
        Console.WriteLine("_____________DISPLAYING  PRIME SERIES BETWEEN NUMBERS____________");
        for(int i =a;i<b;i++)
        {
            int k = CheckPrime(i);
            Console.WriteLine(i);
        }
    }

}
