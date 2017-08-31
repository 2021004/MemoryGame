using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form3 : Form
    {
        public Form3(Dictionary<string, Color> teams, int grid_x, int grid_y)
        {
            colours = teams;
            Size_x = grid_x;
            Size_y = grid_y;
            InitializeComponent();
        }

        public Dictionary<int, Button> buttonGrid = new Dictionary<int, Button>();
        public Dictionary<int, Panel> labelGroopss = new Dictionary<int, Panel>();
        public Dictionary<int, Panel> colourGroopss = new Dictionary<int, Panel>();
        public Dictionary<string, Color> colours;
        public Dictionary<int, Label> labels = new Dictionary<int, Label>();
        public Dictionary<int, Label> labelScorss = new Dictionary<int, Label>();
        
        public int Size_x;
        public int Size_y;

        private void Form3_Load(object sender, EventArgs e)
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
            #region textBoxs
            labels.Add(1, label1);
            labels.Add(2, label4);
            labels.Add(3, label6);
            labels.Add(4, label8);
            labels.Add(5, label10);
            #endregion
            #region labelScorss
            labelScorss.Add(1, label2);
            labelScorss.Add(2, label3);
            labelScorss.Add(3, label5);
            labelScorss.Add(4, label7);
            labelScorss.Add(5, label9);
            #endregion
            #region labelGroopss
            labelGroopss.Add(1, panel2);
            labelGroopss.Add(2, panel3);
            labelGroopss.Add(3, panel5);
            labelGroopss.Add(4, panel7);
            labelGroopss.Add(5, panel9);
            #endregion
            #region colourGroopss
            colourGroopss.Add(1, panel1);
            colourGroopss.Add(2, panel4);
            colourGroopss.Add(3, panel6);
            colourGroopss.Add(4, panel8);
            colourGroopss.Add(5, panel10);
            #endregion

            int Teams = 1;
            foreach (string teamName in colours.Keys)
            {
                labelGroopss[Teams].Visible = true;
                colourGroopss[Teams].BackColor = colours[teamName];
                labels[Teams].Text = teamName;
                Teams++;
            }

            resize_grid();
        }

        private void resize_grid()
        {
            for (int j = 1; j <= 100; j++)
            {
                if (j == 1)
                {
                    squarsize(j);
                }
                else
                {
                    int buttons_x = Math.Abs(j) + 9;
                    while (buttons_x >= 11)
                        buttons_x /= 10;
                    int buttons_y = j % 10;
                    if (buttons_y == 0)
                        buttons_y = 10;

                    if (buttons_x <= Size_x && buttons_y <= Size_y)
                    {
                        buttonGrid[j].Visible = true;
                        squarsize(j);
                    }
                    else
                        buttonGrid[j].Visible = false;
                }
            }
            

        }

        public void squarsize(int j)
        {
            buttonGrid[j].Size = new Size(((tableLayoutPanel1.Width / Size_y) - 2), ((tableLayoutPanel1.Height / Size_x) - 2));
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            resize_grid();
        }
    }
}
