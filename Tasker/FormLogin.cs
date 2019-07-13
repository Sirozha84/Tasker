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
            
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(Properties.Settings.Default.server, 8082);
                NetworkStream stream = client.GetStream();
                BinaryReader reader = new BinaryReader(stream);
                BinaryWriter writer = new BinaryWriter(stream);
                writer.Write(Program.clientVer + "☺" + Properties.Settings.Default.login + "☺" + Properties.Settings.Default.password);
                MessageBox.Show(reader.ReadString());
            }
            catch {  }


            /*if (true)
            {
                Close();
            }
            else
            {
                //Что-то пошло не так, сбрасываем галочки
                checkBoxRemember.Checked = false;                
                checkBoxAutologin.Checked = false;
            }*/

        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = textBoxPassword.Text.Length > 0;
        }
    }
}
