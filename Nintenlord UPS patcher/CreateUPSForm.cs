using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Nintenlord.Hacking.Core;

namespace Nintenlord.UPSpatcher
{
    public partial class CreateUPSForm : Form
    {
        public CreateUPSForm()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Form2_Resize);
            this.MinimumSize = new Size(this.Width - this.textBox1.Width, this.Height);
        }

        void Form2_Resize(object sender, EventArgs e)
        {
            textBox1.Size = this.Size - this.MinimumSize;
            textBox2.Size = this.Size - this.MinimumSize;
            textBox3.Size = this.Size - this.MinimumSize;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select the original file.";
            open.Filter = "All files|*";
            open.Multiselect = false;
            open.ShowDialog();
            if (open.FileNames.Length > 0)
            {
                textBox1.Text = open.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select the modified file.";
            open.Filter = "All files|*";
            open.Multiselect = false;
            open.ShowDialog();
            if (open.FileNames.Length > 0)
            {
                textBox2.Text = open.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "UPS file|*.ups";
            save.Title = "Select where to save patch";
            save.AddExtension = true;
            save.OverwritePrompt = true;
            save.ShowDialog();
            if (save.FileNames.Length > 0)
            {
                textBox3.Text = save.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] original = null, modified = null;

            try
            {
                BinaryReader br = new BinaryReader(File.OpenRead(textBox1.Text));
                original = br.ReadBytes((int)br.BaseStream.Length);
                br.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening file\n" + textBox1.Text);
                return;
            }

            try
            {
                BinaryReader br = new BinaryReader(File.Open(textBox2.Text, FileMode.Open));
                modified = br.ReadBytes((int)br.BaseStream.Length);
                br.Close();
            }
            catch (Exception)
            {                
                MessageBox.Show("Error opening file\n" + textBox2.Text);
                return;
            }
            

            UPSfile upsFile = new UPSfile(original, modified);
            upsFile.WriteToFile(textBox3.Text);
            MessageBox.Show("Patch has been created.");

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
