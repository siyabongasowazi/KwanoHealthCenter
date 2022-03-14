using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class UserPassword
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public UserPassword(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
