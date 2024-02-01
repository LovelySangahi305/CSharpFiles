using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class Accountdetails
    {
        public void GetData()
        {
            double balance1 = Convert.ToDouble(Console.ReadLine());
            string type1 = Console.ReadLine();
            double amount1 = Convert.ToDouble(Console.ReadLine());
            double balance2 = Convert.ToDouble(Console.ReadLine());
            string type2 = Console.ReadLine();
            double amount2 = Convert.ToDouble(Console.ReadLine());

            Account a1 = new Account (balance1, type1);
            a1.printAccountDetails();
            a1.depositAmount(amount1);
            Console.WriteLine("New Balance : {0:N}", a1.balance);

            Account a2 = new Account(balance2, type2);
            a2.printAccountDetails();
            a2.balance = amount2;
            Console.WriteLine("New Balance : {0:N}", a2.balance);
        }
    }
}
