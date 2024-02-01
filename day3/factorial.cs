using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Factorial
    {
    int n , fact =1;

    public void GetDetails()
    {

        Console.WriteLine("Enter the number whose factorial you want : ");
        n = Convert.ToInt32(Console.ReadLine());
        
    }
    public void DisplayDetails()
    {
        Console.WriteLine("_____________FACTORIAL OF A NUMBER____________");
        for (int i = 1; i <= n ; i++)
        {
            fact = fact*i;
        }
        Console.WriteLine($"factorial of {n} = {fact}");
    }
}

