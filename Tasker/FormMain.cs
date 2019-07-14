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
    public partial class FormMain : Form
    {
        public FormMain(string name)
        {
            InitializeComponent();
            Text = "Tasker - " + name;
        }
        
        #region Menu
        private void MenuExit_Click(object sender, EventArgs e) { Close(); }
        private void MenuQuery_Click(object sender, EventArgs e) { FormQuery form = new FormQuery(); form.ShowDialog(); }
        private void MenuUsers_Click(object sender, EventArgs e) { FormUserList form = new FormUserList(); form.ShowDialog(); }
        private void MenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tasker\n" + "Версия: " + Program.version + "\nАвтор: Сергей Гордеев", "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
