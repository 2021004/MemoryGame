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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            this.MinimumSize = new Size((tableLayoutPanel1.Width + 231), this.MinimumSize.Height);
            tableLayoutPanel1.Width = tableLayoutPanel1.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;
            int buttonClickedIndex = buttonGrid.Values.ToList().IndexOf(buttonClicked) + 1;

            int buttonClicked_x = Math.Abs(buttonClickedIndex) + 9;
            while (buttonClicked_x >= 11)
                buttonClicked_x /= 10;
            int buttonClicked_y = buttonClickedIndex % 10;
            if (buttonClicked_y == 0)
                buttonClicked_y = 10;

            Size_x = buttonClicked_x;
            Size_y = buttonClicked_y;

            comboBoxAdditions((Size_x * Size_y) / 2);

            for (int j = 2; j <= 100; j++)
            {
                if (j == buttonClickedIndex)
                    buttonGrid[j].Text = string.Format("{0},{1}",buttonClicked_x.ToString() ,buttonClicked_y.ToString());
                else
                    buttonGrid[j].Text = "";

                int buttons_x = Math.Abs(j) + 9;
                while (buttons_x >= 11)
                    buttons_x /= 10;
                int buttons_y = j % 10;
                if (buttons_y == 0)
                    buttons_y = 10;

                if (buttons_x <= buttonClicked_x && buttons_y <= buttonClicked_y)
                    buttonGrid[j].BackColor = SystemColors.ButtonFace;
                else
                    buttonGrid[j].BackColor = SystemColors.ControlLight;
            }
        }

        public void comboBoxAdditions(int number)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            DirectoryInfo di = new DirectoryInfo(Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"), "csv"));
            FileInfo[] files = di.GetFiles("*.csv");
            foreach (FileInfo file in files)
            {
                if (File.ReadLines(file.FullName).Count() >= number)
                {
                    comboBox1.Items.Add(file.Name.Substring(0, (file.Name.Length - 4)));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region buttonGrid
            buttonGrid.Add(1, button1);
            buttonGrid.Add(2, button2);
            buttonGrid.Add(3, button3);
            buttonGrid.Add(4, button4);
            buttonGrid.Add(5, button5);
            buttonGrid.Add(6, button6);
            buttonGrid.Add(7, button7);
            buttonGrid.Add(8, button8);
            buttonGrid.Add(9, button9);
            buttonGrid.Add(10, button10);
            buttonGrid.Add(11, button11);
            buttonGrid.Add(12, button12);
            buttonGrid.Add(13, button13);
            buttonGrid.Add(14, button14);
            buttonGrid.Add(15, button15);
            buttonGrid.Add(16, button16);
            buttonGrid.Add(17, button17);
            buttonGrid.Add(18, button18);
            buttonGrid.Add(19, button19);
            buttonGrid.Add(20, button20);
            buttonGrid.Add(21, button21);
            buttonGrid.Add(22, button22);
            buttonGrid.Add(23, button23);
            buttonGrid.Add(24, button24);
            buttonGrid.Add(25, button25);
            buttonGrid.Add(26, button26);
            buttonGrid.Add(27, button27);
            buttonGrid.Add(28, button28);
            buttonGrid.Add(29, button29);
            buttonGrid.Add(30, button30);
            buttonGrid.Add(31, button31);
            buttonGrid.Add(32, button32);
            buttonGrid.Add(33, button33);
            buttonGrid.Add(34, button34);
            buttonGrid.Add(35, button35);
            buttonGrid.Add(36, button36);
            buttonGrid.Add(37, button37);
            buttonGrid.Add(38, button38);
            buttonGrid.Add(39, button39);
            buttonGrid.Add(40, button40);
            buttonGrid.Add(41, button41);
            buttonGrid.Add(42, button42);
            buttonGrid.Add(43, button43);
            buttonGrid.Add(44, button44);
            buttonGrid.Add(45, button45);
            buttonGrid.Add(46, button46);
            buttonGrid.Add(47, button47);
            buttonGrid.Add(48, button48);
            buttonGrid.Add(49, button49);
            buttonGrid.Add(50, button50);
            buttonGrid.Add(51, button51);
            buttonGrid.Add(52, button52);
            buttonGrid.Add(53, button53);
            buttonGrid.Add(54, button54);
            buttonGrid.Add(55, button55);
            buttonGrid.Add(56, button56);
            buttonGrid.Add(57, button57);
            buttonGrid.Add(58, button58);
            buttonGrid.Add(59, button59);
            buttonGrid.Add(60, button60);
            buttonGrid.Add(61, button61);
            buttonGrid.Add(62, button62);
            buttonGrid.Add(63, button63);
            buttonGrid.Add(64, button64);
            buttonGrid.Add(65, button65);
            buttonGrid.Add(66, button66);
            buttonGrid.Add(67, button67);
            buttonGrid.Add(68, button68);
            buttonGrid.Add(69, button69);
            buttonGrid.Add(70, button70);
            buttonGrid.Add(71, button71);
            buttonGrid.Add(72, button72);
            buttonGrid.Add(73, button73);
            buttonGrid.Add(74, button74);
            buttonGrid.Add(75, button75);
            buttonGrid.Add(76, button76);
            buttonGrid.Add(77, button77);
            buttonGrid.Add(78, button78);
            buttonGrid.Add(79, button79);
            buttonGrid.Add(80, button80);
            buttonGrid.Add(81, button81);
            buttonGrid.Add(82, button82);
            buttonGrid.Add(83, button83);
            buttonGrid.Add(84, button84);
            buttonGrid.Add(85, button85);
            buttonGrid.Add(86, button86);
            buttonGrid.Add(87, button87);
            buttonGrid.Add(88, button88);
            buttonGrid.Add(89, button89);
            buttonGrid.Add(90, button90);
            buttonGrid.Add(91, button91);
            buttonGrid.Add(92, button92);
            buttonGrid.Add(93, button93);
            buttonGrid.Add(94, button94);
            buttonGrid.Add(95, button95);
            buttonGrid.Add(96, button96);
            buttonGrid.Add(97, button97);
            buttonGrid.Add(98, button98);
            buttonGrid.Add(99, button99);
            buttonGrid.Add(100, button100);
            #endregion
            #region checkBoxs
            checkBoxs.Add(1, checkBox1);
            checkBoxs.Add(2, checkBox2);
            checkBoxs.Add(3, checkBox3);
            checkBoxs.Add(4, checkBox4);
            checkBoxs.Add(5, checkBox5);
            #endregion
            #region textBoxs
            textBoxs.Add(1, textBox1);
            textBoxs.Add(2, textBox2);
            textBoxs.Add(3, textBox3);
            textBoxs.Add(4, textBox4);
            textBoxs.Add(5, textBox5);
            #endregion
            #region submenu
            comboBoxAdditions(2);
            #endregion
            #region contextMenuStrip
            name();
            #endregion
        }

        public void name()
        {
            ContextMenuStrip menu = contextMenuStrip1;
            ToolStripMenuItem item, submenu;

            submenu = deleteToolStripMenuItem;
            submenu.DropDownItems.Clear();

            DirectoryInfo di = new DirectoryInfo(Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"), "csv"));
            FileInfo[] files = di.GetFiles("*.csv");
            foreach (FileInfo file in files)
            {
                item = new ToolStripMenuItem();
                item.Text = file.Name.Substring(0, (file.Name.Length - 4));
                item.Name = file.Name.Substring(0, (file.Name.Length - 4));
                submenu.DropDownItems.Add(item);
                item.Click += new EventHandler(item_Click);
            }

            menu.Items.Add(submenu);
        }

        public Dictionary<int, Button> buttonGrid = new Dictionary<int, Button>();
        public Dictionary<int, CheckBox> checkBoxs = new Dictionary<int, CheckBox>();
        public Dictionary<int, TextBox> textBoxs = new Dictionary<int, TextBox>();
        public int Size_x = 2;
        public int Size_y = 2;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox CheckBoxClicked = sender as CheckBox;
            int checkBoxClickedIndex = checkBoxs.Values.ToList().IndexOf(CheckBoxClicked) + 1;
            if (CheckBoxClicked.Checked == true)
            { // on
                ColorDialog MyDialog = new ColorDialog();
                MyDialog.AllowFullOpen = false;
                MyDialog.ShowHelp = true;
                MyDialog.Color = CheckBoxClicked.BackColor;
                
                if (MyDialog.ShowDialog() == DialogResult.OK)
                {
                    CheckBoxClicked.BackColor = MyDialog.Color;
                    if (checkBoxClickedIndex + 1 != 6)
                    {
                        checkBoxs[(checkBoxClickedIndex + 1)].Enabled = true;
                        textBoxs[(checkBoxClickedIndex + 1)].Enabled = true;
                    }
                    if (checkBox2.Checked == true && comboBox1.SelectedIndex > -1)
                    {
                        startButton.Enabled = true;
                    }
                    else
                    {
                        startButton.Enabled = false;
                    }

                }
                else
                {
                    CheckBoxClicked.Checked = false;
                }
            }
            else
            { // off
                checkBoxs[checkBoxClickedIndex].BackColor = SystemColors.Control;
                for (int j = checkBoxClickedIndex; j < 5; j++)
                {
                    checkBoxs[(j + 1)].Enabled = false;
                    checkBoxs[(j + 1)].Checked = false;
                    checkBoxs[(j + 1)].BackColor = SystemColors.Control;
                    textBoxs[(j + 1)].Enabled = false;
                }
            }
        }

        private void newListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.FormClosed += new FormClosedEventHandler(form2_FormClosed);
        }

        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            comboBoxAdditions((Size_x * Size_y) / 2);
            name();
        }

        protected void item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItemClicked = sender as ToolStripMenuItem;
            File.Delete(Path.Combine(Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"), "csv"), string.Format("{0}.csv", toolStripMenuItemClicked.Text)));
            comboBoxAdditions((Size_x * Size_y) / 2);
            name();
        }
    }
}
