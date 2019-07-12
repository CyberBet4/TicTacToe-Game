using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        
        public static string player1name = "player1";
        public static int tic = 0;
        public string tac;
        public int score1, score2 = 0;

        public void score(int score1, int score2)
        {
            player1.Text = score1.ToString();
            player2.Text = score2.ToString();
        }
        public string checker(int val)
        {
            //simple code to alternate between 'X' and 'O'
            if(val % 2 == 0)
            {
                tac = "X";
            }else { tac = "O"; }
            return tac;
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public void played()
        {
            //disables all button when a win or draw is encountered
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled =
            button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = 
            button9.Enabled = false;
        }
        public void judge()
        {
            /**     takes care of changing the color to indicate a win, 
            *       also increases the score via the score function
            *       disables all button if there is a win or a tie with the played functino
            */
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = button2.BackColor = button3.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(++score1, score2); 
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = button4.BackColor = button7.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(++score1, score2);
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = button5.BackColor = button9.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(++score1, score2);
                 
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = button5.BackColor = button8.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(++score1, score2);
                 
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = button6.BackColor = button9.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(++score1, score2);
                 
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = button5.BackColor = button6.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(++score1, score2);
                 
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = button8.BackColor = button9.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(++score1, score2);
                 
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = button5.BackColor = button7.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(++score1, score2);
                 
            }
            //o version of the game

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = button2.BackColor = button3.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(score1, ++score2);
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = button4.BackColor = button7.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(score1, ++score2);
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = button5.BackColor = button9.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(score1, ++score2);
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = button5.BackColor = button8.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(score1, ++score2);
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = button6.BackColor = button9.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(score1, ++score2);
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = button5.BackColor = button6.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(score1, ++score2);
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = button8.BackColor = button9.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(score1, ++score2);
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = button5.BackColor = button7.BackColor = Color.FromArgb(210, 216, 179);
                played(); score(score1, ++score2);
            }
        }

        public void reset()
        {
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text
                = button7.Text = button8.Text = button9.Text = "";
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled
                = button7.Enabled = button8.Enabled = button9.Enabled = true;
            button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor
                = button7.BackColor = button8.BackColor = button9.BackColor = Color.FromArgb(212, 170, 125);
        }
        public Form1()
        {
            InitializeComponent();
            rename1.Hide();
            tieGame1.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void tie()
        {
            //if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled
            //    == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false && score1 != ++score1 && score2 != ++score2) 
            //{
            //    //tieGame1.Show();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = checker(tic);
            tic++;
            judge();
            button1.Enabled = false;
            tie();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = checker(tic);
            tic++;
            judge();
            button2.Enabled = false;
            tie();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = checker(tic);
            tic++;
            judge();
            button3.Enabled = false;
            tie();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = checker(tic);
            tic++;
            judge();
            button4.Enabled = false;
            tie();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = checker(tic);
            tic++;
            judge();
            button5.Enabled = false;
            tie();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = checker(tic);
            tic++;
            judge();
            button6.Enabled = false;
            tie();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = checker(tic);
            tic++;
            judge();
            button7.Enabled = false;
            tie();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = checker(tic);
            tic++;
            judge();
            button8.Enabled = false;
            tie();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = checker(tic);
            tic++;
            judge();
            button9.Enabled = false;
            tie();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            rename obj = new rename();
            obj.Show();
            label1.Text = player1name;
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            rename1.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}