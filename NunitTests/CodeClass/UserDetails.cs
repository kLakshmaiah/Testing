using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTests.CodeClass
{
    public class UserDetails
    {
        public bool Login(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("user Name is Empty");
            }
            else if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password is Empty");
            }
            else
            {
                if (userName.Equals("Laxman", StringComparison.CurrentCultureIgnoreCase) && userName.Equals("admin@1234", StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
