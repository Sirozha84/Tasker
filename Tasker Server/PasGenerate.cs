using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker_Server
{
    class PasGenerate
    {
        static Random rnd = new Random();
        public static string Generate()
        {
            string pas = "";
            for (int i = 0; i < 8; i++)
                pas += (char)(rnd.Next(2) == 0 ? rnd.Next(48, 58) : rnd.Next(97, 123));
            return pas;
        }
    }
}
