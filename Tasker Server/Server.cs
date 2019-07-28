using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Xml.Serialization;

namespace Tasker_Server
{
    class Server
    {
        const string minimalVersion = "1.0.0";              //Минимальная версия клиента
        static public List<User> users = new List<User>();  //Список пользователей
        public static List<Task> tasks = new List<Task>();  //Список активныз заявок

        static void Main(string[] args)
        {
            Console.WriteLine("Tasker Server     Версия 1.0.0 (13.07.2019)\n");

            //Загрузка пользователей и создание "дефолтного" админа со случайным паролем
            LoadUsers();
            User admin = users.Find(o => o.login == "admin");
            string newpas = PasGenerate.Generate();
            if (admin == null) users.Add(new User("admin", newpas, "Администратор"));
            else admin.password = newpas;
            SaveUsers();
            Console.WriteLine("Пароль для пользователя admin: " + newpas);
            
            //Загрузка активных заявок
            LoadWork();
            SaveWork();

            //Запуск сервера
            TcpListener server = new TcpListener(IPAddress.Any, 8082);
            server.Start();
            Log.Write("Сервер запущен...");
            while (true)
            {
                ThreadPool.QueueUserWorkItem(call, server.AcceptTcpClient());
            }
        }

        /// <summary>
        /// Обработка запроса
        /// </summary>
        /// <param name="clientobject"></param>
        static void call(object clientobject)
        {
            try
            {
                TcpClient client = clientobject as TcpClient;
                using (NetworkStream stream = client.GetStream())
                {
                    BinaryReader reader = new BinaryReader(stream);
                    BinaryWriter writer = new BinaryWriter(stream);
                    writer.Write(answer(reader.ReadString().Split('☺')));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            };
        }

        #region Load/Save
        public static void LoadUsers()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<User>));
                using (var reader = new StreamReader("users.xml"))
                    users = (List<User>)serializer.Deserialize(reader);
            }
            catch { }
        }
        public static void SaveUsers()
        {
            users.Sort((o1, o2) => o1.login.CompareTo(o2.login));
            try
            {
                var serializer = new XmlSerializer(typeof(List<User>));
                using (var writer = new StreamWriter("users.xml"))
                    serializer.Serialize(writer, users);
            }
            catch
            {
                Log.Write("Ошибка при сохранении данных");
            }
        }
        public static void LoadWork()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<Task>));
                using (var reader = new StreamReader("work.xml"))
                    tasks = (List<Task>)serializer.Deserialize(reader);
            }
            catch { }
        }
        public static void SaveWork()
        {
            users.Sort((o1, o2) => o1.login.CompareTo(o2.login));
            try
            {
                var serializer = new XmlSerializer(typeof(List<Task>));
                using (var writer = new StreamWriter("work.xml"))
                    serializer.Serialize(writer, tasks);
            }
            catch
            {
                Log.Write("Ошибка при сохранении данных");
            }
        }
        #endregion

        static string answer(string[] query)
        {
            if (query[0] == "ping") return "pong";
            if (query[0] == "login")
            {
                if (query.Count() != 4) return "error";
                if (query[1] != minimalVersion) return "badversion☺" + minimalVersion;
                User acc = users.Find(o => o.login == query[2]);
                if (acc == null) return "failed";
#if DEBUG
                if (query[3] != "123") return "failed";
#else
                if (query[2] != acc.password) return "failed";
#endif
                Log.Write("Авторизовался пользователь " + acc.fullname);
                return "ok☺" + acc.fullname;
            }
            if (query[0] == "userlist")
            {
                string ans = "";
                foreach (User acc in users)
                    if (acc.login != "admin")
                        ans += acc.login + "☺";
                return ans;
            }
            if (query[0] == "userread")
            {
                if (query.Count() != 2) return "error";
                User user = users.Find(o => o.login == query[1]);
                if (user == null) return "error";
                return user.login + "☺" +
                    user.password + "☺" +
                    user.fullname + "☺" +
                    user.company + "☺" +
                    user.departament + "☺" +
                    user.post + "☺" +
                    user.rights + "☺" +
                    user.comment;
            }
            if (query[0] == "userwrite")
            {
                if (query.Count() != 9) return "error";
                User user = users.Find(o => o.login == query[1]);
                if (user == null)
                {
                    user = new User();
                    users.Add(user);
                }
                user.Set(query);
                SaveUsers();
                Log.Write("Запись пользователя " + query[1]);
                return "ok";
            }
            if (query[0] == "userdel")
            {
                User user = users.Find(o => o.login == query[1]);
                if (user != null)
                {
                    users.Remove(user);
                    SaveUsers();
                }
                Log.Write("Удаление пользователя " + query[1]);
                return "ok";
            }
            if (query[0] == "gettasks")
            {

            }
            //if (query[0] == "
            return "what?";
        }
    }
}
