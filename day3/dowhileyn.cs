using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Dowhileyn
    {
        int num;
        char ch = 'y';

        private void GetDetails()
        {
            Console.WriteLine("___________DO WHILE PROGRAM WITH YES/NO__________");
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            do
            {
                Console.Clear();
                GetDetails();
                Console.WriteLine($"{num} * {num} = {num * num}");
                Console.WriteLine("Do you wish continue y/n");
                ch = Convert.ToChar(Console.ReadLine().ToLower());
            }
            while (ch == 'y');
        }
    }
