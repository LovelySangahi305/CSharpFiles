using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class Account
    {
        public static int counter = 0;
        public int accountNo;
        public double balance;
        public string accountType;

        public Account(double balance, string accountType)
        {
            accountNo = ++counter;
            this.balance = balance;
            this.accountType = accountType;
        }

        public void depositAmount(double amount)
        {
            balance += amount;
        }

        public void printAccountDetails()
        {
            Console.WriteLine("[Acct No : " + accountNo
                            + ", Type : " + accountType
                            + ", Balance : {0:N}" + "]", balance);

            //Console.WriteLine(details);
        }
    }
}

