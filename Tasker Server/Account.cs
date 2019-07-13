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
        public string password;

        public Account() { }

        public Account(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
