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
    public partial class FormCatalog : Form
    {
        int cat;
        public FormCatalog(int cat)
        {
            InitializeComponent();
            this.cat = cat;
            if (cat == 0) Text = "Пользователи";
            if (cat == 1) Text = "Компании";
            if (cat == 2) Text = "Подразделения";
            Refresh();
        }

        void Refresh()
        {
            string[] answer = new string[1];
            if (cat == 0) answer = Query.Say("userlist").Split('☺');
            //if (cat == 0) writer.Write("");
            //if (cat == 0) writer.Write("");
            if (answer[0] == "error") Program.ErrorConnection();
            listViewUsers.BeginUpdate();
            listViewUsers.Items.Clear();
            foreach (string s in answer)
                if (s != "")
                    listViewUsers.Items.Add(new ListViewItem(s));
            listViewUsers.EndUpdate();
        }

        private void ListViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = listViewUsers.SelectedItems.Count > 0;
            buttonEdit.Enabled = sel;
            buttonDel.Enabled = sel;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (cat == 0) using (FormUser form = new FormUser(true, "")) form.ShowDialog();
            //if (cat == 1) using (FormUser form = new FormUser(true, "")) form.ShowDialog();
            //if (cat == 2) using (FormUser form = new FormUser(true, "")) form.ShowDialog();
            Refresh();
        }
    }
}
