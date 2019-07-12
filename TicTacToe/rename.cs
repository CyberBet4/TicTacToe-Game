using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class rename : UserControl
    {
        
        public rename()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1.player1name = textBox1.Text;
            Form1 obj = new Form1();
            obj.label1.Text = Form1.player1name;
            Hide();
        }
    }
}
