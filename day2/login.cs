using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day2;

    public class Login
    {
 string username , password;
        public void GetDetails()
        {
            Console.WriteLine(" ENTER A USERNAME : ");
            username = Console.ReadLine();
            Console.WriteLine(" ENTER A PASSWORD : ");
            password = Console.ReadLine();

        }
        private bool ValidateUser(string username , string password)
        {
            if (username == "lovelys" || password == "sangahilovely")
            {
                return true;
            }
            else
                return false;
        }
        public void DisplayResult()
        {
            if (!ValidateUser(username , password))
            {
                Console.WriteLine(" LOGIN FAILED ");
            }
            else {
                Console.WriteLine(" SUCCESSFUL LOGIN ");
                    }
        }
    }
