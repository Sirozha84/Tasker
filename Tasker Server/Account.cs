using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker_Server
{
    public class Account
    {
        public string login;
        public string fullname;
        public string password;

        public Account() { }

        public Account(string login, string fullname, string password)
        {
            this.login = login;
            this.fullname = fullname;
            this.password = password;
        }
    }
}
