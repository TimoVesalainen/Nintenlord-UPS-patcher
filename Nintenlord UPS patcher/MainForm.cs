using System;
using System.Windows.Forms;

namespace Nintenlord.UPSpatcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new PatchFileForm();
            form.ShowInTaskbar = false;
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new CreateUPSForm();
            form.ShowInTaskbar = false;
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new GetUPSDataForm();
            form.ShowInTaskbar = false;
            form.ShowDialog();
        }
    }
}
