using System;
using System.IO;

namespace Tasker_Server
{
    static class Log
    {
        /// <summary>
        /// Запись лога программы
        /// </summary>
        /// <param name="rec">Запись</param>
        public static void Write(string rec)
        {
            rec = DateTime.Now.ToString("[yyyy.MM.dd HH:mm] ") + rec;
            Console.WriteLine(rec);
            using (StreamWriter file = File.AppendText("Log.txt"))
                file.WriteLine(rec);
        }
    }
}
