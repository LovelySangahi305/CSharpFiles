using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class DoWhile
    {
        int num;
        string name;
        public void DisplayDetails()
        {
            int i = 1;
            do
            {
                Console.WriteLine($"{i} . {name}");
                i++;
            } while (i <= num);
        }

        public void GetDetails()
        {
        Console.WriteLine("__________DO WHILE LOOP PROGRAM____________");
        Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
        }

    }
