using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

    public class While
    {
    int num;
    string name;
    public void DisplayDetails()
    {
        int i = 1;
        while (i <= num)
        {
            Console.WriteLine($"{i} . {name}");
            i++;
        }
    }

    public void GetDetails()
    {
        Console.WriteLine("__________WHILE LOOP PROGRAM____________");
        Console.WriteLine("Enter name");
        name = Console.ReadLine();
        Console.WriteLine("Enter a number");
        num = Convert.ToInt32(Console.ReadLine());
    }
}
