using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MemoryGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                textBox1.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Add this List ??", "Confirm Add!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int count = new int();

                if (richTextBox1.Text != "")
                    count = richTextBox1.Text.Count(x => x == ',');

                if (textBox1.Text == "")
                    MessageBox.Show("Please Give your list a Name", "Name");
                else if (count < 1)
                    MessageBox.Show("Please insert more than one item in your List", "List");
                else
                {
                    File.WriteAllText(Path.Combine(Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"), "csv"), string.Format("{0}.csv", textBox1.Text)), richTextBox1.Text);
                    this.Close();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int lineCount = richTextBox1.Lines.Count();
            label2.Text = string.Format("List Items: {0}", lineCount.ToString());
        }
    }
}
