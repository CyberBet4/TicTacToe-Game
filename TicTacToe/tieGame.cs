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
    public partial class tieGame : UserControl
    {
        public tieGame()
        {
            InitializeComponent();
        }

        private void replay_Click(object sender, EventArgs e)
        {
            new Form1().reset();
            Hide();
        }
    }
}
