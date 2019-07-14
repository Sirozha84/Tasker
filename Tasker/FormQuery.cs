using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace Tasker
{
    public partial class FormQuery : Form
    {
        public FormQuery()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Text += "Запрос: " + textBoxQuery.Text + Environment.NewLine;
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(Properties.Settings.Default.server, 8082);
                NetworkStream stream = client.GetStream();
                BinaryReader reader = new BinaryReader(stream);
                BinaryWriter writer = new BinaryWriter(stream);
                writer.Write(textBoxQuery.Text);
                textBoxAnswer.Text += "Ответ: " + reader.ReadString() + Environment.NewLine + Environment.NewLine;
            }
            catch
            {
                textBoxAnswer.Text += "Ошибка соединения" + Environment.NewLine + Environment.NewLine;
            }
        }
    }
}
