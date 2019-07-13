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
        const string minimalVersion = "1.0.0";                          //Минимальная версия клиента
        static public List<Account> accounts = new List<Account>();     //Список пользователей

        static void Main(string[] args)
        {
            Console.WriteLine("Tasker Server     Версия 1.0.0 (13.07.2019)\n");
            LoadAccounts();
            Account admin = accounts.Find(o => o.login == "admin");
            string newpas = PasGenerate.Generate();
            if (admin == null) accounts.Add(new Account("admin", "Администратор", newpas));
            else admin.password = newpas;
            SaveAccounts();
            Console.WriteLine("Пароль для пользователя admin: " + newpas);

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

        public static void LoadAccounts()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<Account>));
                using (var reader = new StreamReader("accounts.xml"))
                    accounts = (List<Account>)serializer.Deserialize(reader);
            }
            catch
            {
                accounts = new List<Account>();
            }
        }
        public static void SaveAccounts()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<Account>));
                using (var writer = new StreamWriter("accounts.xml"))
                    serializer.Serialize(writer, accounts);
            }
            catch
            {
                Log.Write("Ошибка при сохранении данных");
            }
        }

        static string answer(string[] query)
        {
            if (query.Count() != 3) return "error";
            if (query[0] != minimalVersion) return "badversion☺" + minimalVersion;
            Account acc = accounts.Find(o => o.login == query[1]);
            if (acc == null) return "failed";
#if DEBUG
            if (query[2] != "123") return "failed";
#else
            if (query[2] != acc.password) return "failed";
#endif
            Log.Write("Авторизовался пользователь " + acc.fullname);
            return "ok☺" + acc.fullname;
        }
    }
}
