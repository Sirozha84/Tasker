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
        public FormUser(bool newuser, string name)
        {
            InitializeComponent();
            if (newuser) Text = "Создание нового пользователя";
            else
            {
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
