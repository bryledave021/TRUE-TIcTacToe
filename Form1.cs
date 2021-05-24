using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Instructions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructions HowForm = new Instructions();
            HowForm.Show();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play PlayForm = new Play();
            PlayForm.Show();
        }
    }
}
