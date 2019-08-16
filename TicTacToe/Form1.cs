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
        public int userPlay, start = 0;
        public int score1, score2 = 0;

        public int Rand(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
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
        public void startGame(int x)
        {
            start = x; 
            walterPlay();
        }
        public void walterPlay()
        {
            //start should start with different method, use random to change start num
            //give different moves
            if(start == 1)
            {
                /**
                 * TODO ON THIS PROGRAM
                 * [+] make game dragable
                 * [+] prompt tie for tie game
                 * [+] make computer play game too
                 * [+] player2 rename
                 * [+] computer will prompt some toast; bragging
                 */
                button1.Text = "O"; button1.Enabled = false;
                switch (userPlay)
                {
                    case 5: checker(++tic);
                        //WIN THE GAME, WHEN THE CHANCE SHOWS UP
                        if (button1.Text == "O" && button3.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button2.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button2.Text == "O" && button3.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button1.Text == "O" && button5.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button1.Text == "O" && button9.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button9.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button7.Text == "O" && button5.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button7.Text == "O" && button3.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button3.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button7.Text == "O" && button8.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button7.Text == "O" && button9.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button8.Text == "O" && button9.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button3.Text == "O" && button6.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button3.Text == "O" && button9.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button6.Text == "O" && button9.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button4.Text == "O" && button5.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button4.Text == "O" && button6.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button6.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button1.Enabled = false; }
                        else if (button2.Text == "O" && button5.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button2.Text == "O" && button8.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button8.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button4.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button1.Text == "O" && button7.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button4.Enabled = false; }
                        else if (button4.Text == "O" && button7.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        //BLOCK USER FROM WINNING THE GAME
                        else if (button2.Text == "X" && button5.Text == "X" && button8.Enabled == true)
                        {
                            button8.Text = "O"; button8.Enabled = false;
                        } else if (button4.Text == "X" && button5.Text == "X" && button6.Enabled == true)
                        {
                            button6.Text = "O"; button6.Enabled = false;
                        } else if (button7.Text == "X" && button5.Text == "X" && button3.Enabled == true)
                        {
                            button3.Text = "O"; button3.Enabled = false;
                        } else if (button8.Text == "X" && button5.Text == "X" && button2.Enabled == true)
                        {
                            button2.Text = "O"; button2.Enabled = false;
                        } else if (button9.Text == "X" && button5.Text == "X" && button1.Enabled == true)
                        {
                            button1.Text = "O"; button1.Enabled = false;
                        } else if (button6.Text == "X" && button5.Text == "X" && button4.Enabled == true)
                        {
                            button4.Text = "O"; button4.Enabled = false;
                        } else if (button3.Text == "X" && button5.Text == "X" && button7.Enabled == true)
                        {
                            button7.Text = "O"; button7.Enabled = false;
                        }

                        else if(button9.Enabled == true)
                        {
                            button9.Text = "O"; button9.Enabled = false;
                        }
                        else { goto case 2; }
                        judge();
                        break;

                    case 7: checker(++tic);
                        //WIN THE GAME, WHEN THE CHANCE SHOWS UP
                        if (button1.Text == "O" && button3.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button2.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button2.Text == "O" && button3.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button1.Text == "O" && button5.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button1.Text == "O" && button9.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button9.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button7.Text == "O" && button5.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button7.Text == "O" && button3.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button3.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button7.Text == "O" && button8.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button7.Text == "O" && button9.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button8.Text == "O" && button9.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button3.Text == "O" && button6.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button3.Text == "O" && button9.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button6.Text == "O" && button9.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button4.Text == "O" && button5.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button4.Text == "O" && button6.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button6.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button1.Enabled = false; }
                        else if (button2.Text == "O" && button5.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button2.Text == "O" && button8.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button8.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button4.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button1.Text == "O" && button7.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button4.Enabled = false; }
                        else if (button4.Text == "O" && button7.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        //BLOCK USER FROM WINNING THE GAME
                        else if (button4.Text == "X" && button7.Text == "X" && button1.Enabled == true)
                        {
                            button1.Text = "O"; button1.Enabled = false;
                        }
                        else if (button8.Text == "X" && button7.Text == "X" && button9.Enabled == true)
                        {
                            button9.Text = "O"; button9.Enabled = false;
                        }
                        else if (button5.Text == "X" && button7.Text == "X" && button3.Enabled == true)
                        {
                            button3.Text = "O"; button3.Enabled = false;
                        }
                        else if (button1.Text == "X" && button7.Text == "X" && button4.Enabled == true)
                        {
                            button4.Text = "O"; button4.Enabled = false;
                        }
                        else if (button9.Text == "X" && button7.Text == "X" && button8.Enabled == true)
                        {
                            button8.Text = "O"; button8.Enabled = false;
                        }
                        else if (button3.Text == "X" && button7.Text == "X" && button5.Enabled == true)
                        {
                            button5.Text = "O"; button5.Enabled = false;
                        }
                        else if(button3.Enabled == true)
                        {
                            button3.Text = "O"; button3.Enabled = false;
                        }
                        else { goto case 3; }

                        judge();
                        break;
                    case 2: checker(++tic);
                        //WIN THE GAME, WHEN THE CHANCE SHOWS UP
                        if (button1.Text == "O" && button3.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button2.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button2.Text == "O" && button3.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button1.Text == "O" && button5.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button1.Text == "O" && button9.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button9.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button7.Text == "O" && button5.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button7.Text == "O" && button3.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button3.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button7.Text == "O" && button8.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button7.Text == "O" && button9.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button8.Text == "O" && button9.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button3.Text == "O" && button6.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button3.Text == "O" && button9.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button6.Text == "O" && button9.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button4.Text == "O" && button5.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button4.Text == "O" && button6.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button6.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button1.Enabled = false; }
                        else if (button2.Text == "O" && button5.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button2.Text == "O" && button8.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button8.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button4.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button1.Text == "O" && button7.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button4.Enabled = false; }
                        else if (button4.Text == "O" && button7.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        //BLOCK USER FROM WINNING THE GAME
                        if (button1.Text == "X" && button2.Text == "X" && button3.Enabled == true)
                        {
                            button3.Text = "O"; button3.Enabled = false;
                        }
                        else if (button3.Text == "X" && button2.Text == "X" && button1.Enabled == true)
                        {
                            button1.Text = "O"; button1.Enabled = false;
                        }
                        else if (button5.Text == "X" && button2.Text == "X" && button8.Enabled == true)
                        {
                            button8.Text = "O"; button8.Enabled = false;
                        }
                        else if (button8.Text == "X" && button2.Text == "X" && button5.Enabled == true)
                        {
                            button5.Text = "O"; button5.Enabled = false;
                        }
                        else if (button6.Enabled == true)
                        {
                            button6.Text = "O"; button6.Enabled = false;
                        }
                       
                        else { goto case 1; }
                        judge();
                        break;
                    case 6: checker(++tic);
                        //WIN THE GAME, WHEN THE CHANCE SHOWS UP
                        if (button1.Text == "O" && button3.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button2.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button2.Text == "O" && button3.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button1.Text == "O" && button5.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button1.Text == "O" && button9.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button9.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button7.Text == "O" && button5.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button7.Text == "O" && button3.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button3.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button7.Text == "O" && button8.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button7.Text == "O" && button9.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button8.Text == "O" && button9.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button3.Text == "O" && button6.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button3.Text == "O" && button9.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button6.Text == "O" && button9.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button4.Text == "O" && button5.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button4.Text == "O" && button6.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button6.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button1.Enabled = false; }
                        else if (button2.Text == "O" && button5.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button2.Text == "O" && button8.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button8.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button4.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button1.Text == "O" && button7.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button4.Enabled = false; }
                        else if (button4.Text == "O" && button7.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        //BLOCK USER FROM WINNING THE GAME
                        if (button4.Text == "X" && button6.Text == "X" && button5.Enabled == true)
                        {
                            button5.Text = "O"; button5.Enabled = false;
                        }
                        else if (button5.Text == "X" && button6.Text == "X" && button4.Enabled == true)
                        {
                            button4.Text = "O"; button4.Enabled = false;
                        }
                        else if (button3.Text == "X" && button6.Text == "X" && button9.Enabled == true)
                        {
                            button9.Text = "O"; button9.Enabled = false;
                        }
                        else if (button9.Text == "X" && button6.Text == "X" && button3.Enabled == true)
                        {
                            button3.Text = "O"; button3.Enabled = false;
                        }
                        else if(button2.Enabled == true)
                        {
                            button2.Text = "O"; button2.Enabled = false;
                        }
                        else { goto case 4; }
                        judge();
                        break;
                    case 9: checker(++tic);
                        //WIN THE GAME, WHEN THE CHANCE SHOWS UP

                        if (button1.Text == "O" && button3.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button2.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button2.Text == "O" && button3.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button1.Text == "O" && button5.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button1.Text == "O" && button9.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button9.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button7.Text == "O" && button5.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button7.Text == "O" && button3.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button3.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button7.Text == "O" && button8.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button7.Text == "O" && button9.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button8.Text == "O" && button9.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button3.Text == "O" && button6.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button3.Text == "O" && button9.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button6.Text == "O" && button9.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button4.Text == "O" && button5.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button4.Text == "O" && button6.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button6.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button1.Enabled = false; }
                        else if (button2.Text == "O" && button5.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button2.Text == "O" && button8.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button8.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button4.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button1.Text == "O" && button7.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button4.Enabled = false; }
                        else if (button4.Text == "O" && button7.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        //BLOCK USER FROM WINNING THE GAME
                        if (button1.Text == "X" && button9.Text == "X" && button5.Enabled == true)
                        {
                            button5.Text = "O"; button5.Enabled = false;
                        }
                        else if (button5.Text == "X" && button9.Text == "X" && button1.Enabled == true)
                        {
                            button1.Text = "O"; button1.Enabled = false;
                        }
                        else if (button8.Text == "X" && button9.Text == "X" && button7.Enabled == true)
                        {
                            button7.Text = "O"; button7.Enabled = false;
                        }
                        else if (button7.Text == "X" && button9.Text == "X" && button8.Enabled == true)
                        {
                            button8.Text = "O"; button8.Enabled = false;
                        }
                        else if (button6.Text == "X" && button9.Text == "X" && button3.Enabled == true)
                        {
                            button3.Text = "O"; button3.Enabled = false;
                        }
                        else if (button3.Text == "X" && button9.Text == "X" && button6.Enabled == true)
                        {
                            button6.Text = "O"; button6.Enabled = false;
                        }
                        else if(button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if(button4.Enabled == true)
                        { button4.Text = "O"; button4.Enabled = false; }
                        else { goto case 5; }
                        judge();
                        break;
                    case 4: checker(++tic);
                        //WIN THE GAME, WHEN THE CHANCE SHOWS UP
                        if (button1.Text == "O" && button3.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button2.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button2.Text == "O" && button3.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button1.Text == "O" && button5.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button1.Text == "O" && button9.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button9.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button7.Text == "O" && button5.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button7.Text == "O" && button3.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button3.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button7.Text == "O" && button8.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button7.Text == "O" && button9.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button8.Text == "O" && button9.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button3.Text == "O" && button6.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button3.Text == "O" && button9.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button6.Text == "O" && button9.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button4.Text == "O" && button5.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button4.Text == "O" && button6.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button6.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button1.Enabled = false; }
                        else if (button2.Text == "O" && button5.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button2.Text == "O" && button8.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button8.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button4.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button1.Text == "O" && button7.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button4.Enabled = false; }
                        else if (button4.Text == "O" && button7.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        //BLOCK USER FROM WINNING THE GAME
                        if (button6.Text == "X" && button4.Text == "X" && button5.Enabled == true)
                        {
                            button5.Text = "O"; button5.Enabled = false;
                        }
                        else if (button5.Text == "X" && button4.Text == "X" && button6.Enabled == true)
                        {
                            button6.Text = "O"; button6.Enabled = false;
                        }
                        else if (button1.Text == "X" && button4.Text == "X" && button7.Enabled == true)
                        {
                            button7.Text = "O"; button7.Enabled = false;
                        }
                        else if (button7.Text == "X" && button4.Text == "X" && button1.Enabled == true)
                        {
                            button1.Text = "O"; button1.Enabled = false;
                        }
                        else if(button5.Enabled == true)
                        {
                            button5.Text = "O"; button5.Enabled = false;
                        }
                        else { goto case 6; }
                        judge();
                        break;
                    case 3: checker(++tic);
                        //WIN THE GAME, WHEN THE CHANCE SHOWS UP
                        if (button1.Text == "O" && button3.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button2.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button2.Text == "O" && button3.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button1.Text == "O" && button5.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button1.Text == "O" && button9.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button9.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button7.Text == "O" && button5.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button7.Text == "O" && button3.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button3.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button7.Text == "O" && button8.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button7.Text == "O" && button9.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button8.Text == "O" && button9.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button3.Text == "O" && button6.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button3.Text == "O" && button9.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button6.Text == "O" && button9.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button4.Text == "O" && button5.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button4.Text == "O" && button6.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button6.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button1.Enabled = false; }
                        else if (button2.Text == "O" && button5.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button2.Text == "O" && button8.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button8.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button4.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button1.Text == "O" && button7.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button4.Enabled = false; }
                        else if (button4.Text == "O" && button7.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        //BLOCK USER FROM WINNING THE GAME
                        if (button1.Text == "X" && button3.Text == "X" && button2.Enabled == true)
                        {
                            button2.Text = "O"; button2.Enabled = false;
                        }
                        else if (button7.Text == "X" && button3.Text == "X" && button5.Enabled == true)
                        {
                            button5.Text = "O"; button5.Enabled = false;
                        }
                        else if (button5.Text == "X" && button3.Text == "X" && button7.Enabled == true)
                        {
                            button7.Text = "O"; button7.Enabled = false;
                        }
                        else if (button9.Text == "X" && button3.Text == "X" && button6.Enabled == true)
                        {
                            button6.Text = "O"; button6.Enabled = false;
                        }
                        else if (button6.Text == "X" && button3.Text == "X" && button9.Enabled == true)
                        {
                            button9.Text = "O"; button9.Enabled = false;
                        }
                        else if (button2.Text == "X" && button3.Text == "X" && button1.Enabled == true)
                        {
                            button1.Text = "O"; button1.Enabled = false;
                        }
                        else { goto case 7; }
                        judge();
                        break;
                    case 8:
                        checker(++tic);
                        //WIN THE GAME, WHEN THE CHANCE SHOWS UP
                        if (button1.Text == "O" && button3.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button2.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button2.Text == "O" && button3.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button1.Text == "O" && button5.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button1.Text == "O" && button9.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button9.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button7.Text == "O" && button5.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button7.Text == "O" && button3.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button3.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button7.Text == "O" && button8.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button7.Text == "O" && button9.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button8.Text == "O" && button9.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button3.Text == "O" && button6.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button3.Text == "O" && button9.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button6.Text == "O" && button9.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button4.Text == "O" && button5.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button4.Text == "O" && button6.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button6.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button1.Enabled = false; }
                        else if (button2.Text == "O" && button5.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button2.Text == "O" && button8.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button8.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button4.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button1.Text == "O" && button7.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button4.Enabled = false; }
                        else if (button4.Text == "O" && button7.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        //BLOCK USER FROM WINNING THE GAME
                        if (button7.Text == "X" && button8.Text == "X" && button9.Enabled == true)
                        {
                            button9.Text = "O"; button9.Enabled = false;
                        }
                        else if (button9.Text == "X" && button8.Text == "X" && button7.Enabled == true)
                        {
                            button7.Text = "O"; button7.Enabled = false;
                        }
                        else if (button5.Text == "X" && button8.Text == "X" && button2.Enabled == true)
                        {
                            button2.Text = "O"; button2.Enabled = false;
                        }
                        else if (button2.Text == "X" && button8.Text == "X" && button5.Enabled == true)
                        {
                            button5.Text = "O"; button5.Enabled = false;
                        }
                        judge();
                        break;
                    case 1:
                        checker(++tic);
                        //WIN THE GAME, WHEN THE CHANCE SHOWS UP
                        if (button1.Text == "O" && button3.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button2.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button2.Text == "O" && button3.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button1.Text == "O" && button5.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button1.Text == "O" && button9.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button9.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        else if (button7.Text == "O" && button5.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button7.Text == "O" && button3.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button3.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button7.Text == "O" && button8.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button7.Text == "O" && button9.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button8.Text == "O" && button9.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button3.Text == "O" && button6.Text == "O" && button9.Enabled == true) { button9.Text = "O"; button9.Enabled = false; }
                        else if (button3.Text == "O" && button9.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button6.Text == "O" && button9.Text == "O" && button3.Enabled == true) { button3.Text = "O"; button3.Enabled = false; }
                        else if (button4.Text == "O" && button5.Text == "O" && button6.Enabled == true) { button6.Text = "O"; button6.Enabled = false; }
                        else if (button4.Text == "O" && button6.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button6.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button1.Enabled = false; }
                        else if (button2.Text == "O" && button5.Text == "O" && button8.Enabled == true) { button8.Text = "O"; button8.Enabled = false; }
                        else if (button2.Text == "O" && button8.Text == "O" && button5.Enabled == true) { button5.Text = "O"; button5.Enabled = false; }
                        else if (button5.Text == "O" && button8.Text == "O" && button2.Enabled == true) { button2.Text = "O"; button2.Enabled = false; }
                        else if (button1.Text == "O" && button4.Text == "O" && button7.Enabled == true) { button7.Text = "O"; button7.Enabled = false; }
                        else if (button1.Text == "O" && button7.Text == "O" && button4.Enabled == true) { button4.Text = "O"; button4.Enabled = false; }
                        else if (button4.Text == "O" && button7.Text == "O" && button1.Enabled == true) { button1.Text = "O"; button1.Enabled = false; }
                        //BLOCK USER FROM WINNING THE GAME
                        if (button1.Text == "X" && button3.Text == "X" && button2.Enabled == true)
                        {
                            button2.Text = "O"; button2.Enabled = false;
                        }
                        else if (button9.Text == "X" && button1.Text == "X" && button5.Enabled == true)
                        {
                            button5.Text = "O"; button5.Enabled = false;
                        }
                        else if (button4.Text == "X" && button1.Text == "X" && button7.Enabled == true)
                        {
                            button7.Text = "O"; button7.Enabled = false;
                        }
                        else if (button7.Text == "X" && button1.Text == "X" && button4.Enabled == true)
                        {
                            button4.Text = "O"; button4.Enabled = false;
                        }
                        else if (button5.Text == "X" && button1.Text == "X" && button9.Enabled == true)
                        {
                            button9.Text = "O"; button9.Enabled = false;
                        }
                        else if (button1.Text == "X" && button7.Text == "X" && button4.Enabled == true)
                        {
                            button4.Text = "O"; button4.Enabled = false;
                        }
                        else { goto case 8; }
                        judge();
                        break;
                }
            }
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
            userPlay = 1; walterPlay();
            tie();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = checker(tic);
            tic++;
            judge();
            button2.Enabled = false;
            userPlay = 2; walterPlay();
            tie();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = checker(tic);
            tic++;
            judge();
            button3.Enabled = false;
            userPlay = 3; walterPlay();
            tie();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = checker(tic);
            tic++;
            judge();
            button4.Enabled = false;
            userPlay = 4; walterPlay();
            tie();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = checker(tic);
            tic++;
            judge();
            button5.Enabled = false;
            userPlay = 5; walterPlay();
            tie();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = checker(tic);
            tic++;
            judge();
            button6.Enabled = false;
            userPlay = 6; walterPlay();
            tie();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = checker(tic);
            tic++;
            judge();
            button7.Enabled = false;
            userPlay = 7; walterPlay();
            tie();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = checker(tic);
            tic++;
            judge();
            button8.Enabled = false;
            userPlay = 8; walterPlay();
            tie();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = checker(tic);
            tic++;
            judge();
            button9.Enabled = false;
            userPlay = 9; walterPlay();
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

        private void walter_Click(object sender, EventArgs e)
        {
            start = 1;
            startGame(start);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}