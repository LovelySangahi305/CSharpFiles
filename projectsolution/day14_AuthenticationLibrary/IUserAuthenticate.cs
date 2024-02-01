using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14_AuthenticationLibrary
{
    public interface IUserAuthenticate
    {
        bool ValidateUser(string username, string password);
    }
}
