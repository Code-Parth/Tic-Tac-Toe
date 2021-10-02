using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe__Tut
{
    public partial class StartNewGameMessage : Form
    {
        public StartNewGameMessage()
        {
            InitializeComponent();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
