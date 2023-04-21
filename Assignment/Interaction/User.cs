using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class User
    {
        private string _user;
        private string _password;

        public User(string user, string password)
        {
            this._user = user;
            this._password = password;
        }

        public string GetUser()
        {
            return this._user;
        }

        public string GetPassword()
        {
            return this._password;
        }
    }
}
