using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasker
{
    public partial class FormUser : Form
    {
        string lastname;
        public FormUser(bool newuser, string name)
        {
            InitializeComponent();
            if (newuser)
            {
                Text = "Создание нового пользователя";
                return;
            }
            string[] answer = Query.Say("userread☺" + name).Split('☺');
            if (answer[0] == "ok") Close();
            if (answer[0] == "error") Program.ErrorConnection();
            Text = "Редактирование пользователя " + answer[0];
            textBoxLogin.Text = answer[0];
            lastname = answer[0];
            textBoxPassword.Text = answer[1];
            textBoxPasswordConfirm.Text = answer[1];
            textBoxFullName.Text = answer[2];
            comboBoxCompany.Text = answer[3];
            comboBoxDepartament.Text = answer[4];
            comboBoxPost.Text = answer[5];
            checkBoxAdmin.Checked = answer[6][0] == '1';
            textBoxComment.Text = answer[7];
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (lastname != textBoxLogin.Text)
                Query.Say("userdel☺" + lastname);
            string answer = Query.Say("userwrite☺" +
                textBoxLogin.Text + "☺" +
                textBoxPassword.Text + "☺" +
                textBoxFullName.Text + "☺" +
                comboBoxCompany.Text + "☺" +
                comboBoxDepartament.Text + "☺" +
                comboBoxPost.Text + "☺" +
                (checkBoxAdmin.Checked ? "1" : "0") + "☺" +
                textBoxComment.Text);
            if (answer == "ok") Close();
            if (answer == "error") Program.ErrorConnection();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
