using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day14_AuthenticationLibrary;

namespace ConsoleApp1
{
    internal class Class1
    {
        
            string username = "";
            string password = "";

            IUserAuthenticate uservalidation;

            public Class1(IUserAuthenticate uservalidation)
            {
                this.uservalidation = uservalidation;
            }

            private void GetDetails()
            {
                Console.WriteLine("Enter username");
                username = Console.ReadLine();

                Console.WriteLine("Enter password");
                password = Console.ReadLine();


            }

            public void DisplayResult()
            {

                GetDetails();
                if (uservalidation.ValidateUser(username, password))
                {
                    Console.WriteLine("Login sucessful");
                }
                else
                {
                    Console.WriteLine("Login Failed");
                }
            }

        }
}
