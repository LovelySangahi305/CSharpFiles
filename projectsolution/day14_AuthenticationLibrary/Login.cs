using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14_AuthenticationLibrary
{
    public class Login : IUserAuthenticate
    {
        public bool ValidateUser(string username, string password)
        {
            if (username.Equals("lovely") && password.Equals("lovely@123"))
                return true;
            else
                return false;
        }
    }
}
