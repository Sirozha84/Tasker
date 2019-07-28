using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker_Server
{
    public class User
    {
        public string login;
        public string password;
        public string fullname;
        public string company;
        public string departament;
        public string post;
        public string rights;
        public string comment;

        public User() { }

        public User(string login, string password, string fullname)
        {
            this.login = login;
            this.fullname = fullname;
            this.password = password;
        }

        public void Set(string[] data)
        {
            login = data[1];
            password = data[2];
            fullname = data[3];
            company = data[4];
            departament = data[5];
            post = data[6];
            rights = data[7];
            comment = data[8];
        }
    }
}

