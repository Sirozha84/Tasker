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
using System.Threading;

namespace Tasker
{
    public partial class FormLogin : Form
    {
        public FormLogin(bool resetAutologin)
        {
            InitializeComponent();
            if (resetAutologin)
            {
                Properties.Settings.Default.autologin = false;
                Properties.Settings.Default.Save();
            }
            textBoxServer.Text = Properties.Settings.Default.server;
            textBoxLogin.Text = Properties.Settings.Default.login;
            if (Properties.Settings.Default.rememberLogin)
            {
                textBoxPassword.Text = Properties.Settings.Default.password;
                checkBoxRemember.Checked = true;
            }
            if (Properties.Settings.Default.autologin)
            {
                checkBoxAutologin.Checked = true;
                ButtonOK_Click(null, null);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckBoxAutologin_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxRemember.Enabled = !checkBoxAutologin.Checked;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = textBoxServer.Text;
            Properties.Settings.Default.login = textBoxLogin.Text;
            Properties.Settings.Default.rememberLogin = checkBoxRemember.Checked;
            if (checkBoxRemember.Checked | checkBoxAutologin.Checked)
                Properties.Settings.Default.password = textBoxPassword.Text;
            Properties.Settings.Default.autologin = checkBoxAutologin.Checked;
            Properties.Settings.Default.Save();

            string[] answer = new string[1];
            string err = "Ошибка подключения";
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(Properties.Settings.Default.server, 8082);
                NetworkStream stream = client.GetStream();
                BinaryReader reader = new BinaryReader(stream);
                BinaryWriter writer = new BinaryWriter(stream);
                writer.Write("login☺" + Program.clientVer + "☺" + Properties.Settings.Default.login + "☺" + 
                    Properties.Settings.Default.password);
                answer = reader.ReadString().Split('☺');
            }
            catch {  }



            if (answer[0]=="ok" && answer.Count() == 2)
            {
                FormMain form = new FormMain(answer[1]);
                Hide();
                form.ShowDialog();
                Environment.Exit(0);
                //Close();
            }
            else
            {
                if (answer[0] == "badversion" && answer.Count() == 2)
                    err = "Для работы необходима версия клиента " + answer[1] + " или выше.";
                if (answer[0] == "failed") err = "Ошибка авторизации.\nНе правильное имя пользователя или пароль.";

                MessageBox.Show(err, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxAutologin.Checked = false;
            }

        }

        void OKenable()
        {
            buttonOK.Enabled = (textBoxServer.Text.Length > 0 &
                                textBoxLogin.Text.Length > 0 &
                                textBoxPassword.Text.Length > 0);
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e) { OKenable(); }
        private void TextBoxServer_TextChanged(object sender, EventArgs e) { OKenable(); }
        private void TextBoxLogin_TextChanged(object sender, EventArgs e) { OKenable(); }
    }
}
