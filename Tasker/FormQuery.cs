using System;
using System.Windows.Forms;

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
            textBoxAnswer.Text += "Ответ: " + Query.Say(textBoxQuery.Text) + 
                Environment.NewLine + Environment.NewLine;
        }
    }
}
