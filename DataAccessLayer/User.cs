using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class User
    {
        public int UserID { get; set; }
        public string Username{ get; set; }
        public string Status { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public User(string username, string passsword, string status, string userType)
        {
            this.Username = username;
            this.Password = passsword;
            this.Status = status;
            this.UserType = userType;
        }

        //FOR UPDATING
        public User(int userID, string username)
        {
            this.Username = username;
            this.UserID = userID;
        }
    }
}
