using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace Tasker
{
    static class Query
    {
        public static string Say(string query)
        {
            string answer = "error";
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(Properties.Settings.Default.server, 8082);
                NetworkStream stream = client.GetStream();
                BinaryReader reader = new BinaryReader(stream);
                BinaryWriter writer = new BinaryWriter(stream);
                writer.Write(query);
                answer = reader.ReadString();
            }
            catch { }
            return answer;
        }

    }
}
