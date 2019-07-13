using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasker
{
    static class Program
    {
        public static string version = "1.0.0 (13.07.2019)";
        public static string clientVer = "1.0.0";               //Минимальная версия разрешённая на сервере
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin(args.Count() > 0));
        }
    }
}
