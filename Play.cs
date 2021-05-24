using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Play : Form
    {
        bool Occupied;
       
        public Play()
        {
            InitializeComponent();
            Occupied = false;
            
        }

        private void Zone1_Click(object sender, EventArgs e)
        {

            if (Occupied == true)
            {

                Zone1.Text = "X";
                Occupied = false;

            }
            else
            {

                Zone1.Text = "O";
                Occupied = true;
            }


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Replay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zone1.Text = "";
            Zone2.Text = "";
            Zone3.Text = "";
            Zone4.Text = "";
            Zone5.Text = "";
            Zone6.Text = "";
            Zone7.Text = "";
            Zone8.Text = "";
            Zone9.Text = "";
            Occupied = false;
            this.Show();

        }

        private void Zone2_Click(object sender, EventArgs e)
        {
            if (Occupied == true)
            {

                Zone2.Text = "X";
                Occupied = false;

            }
            else
            {

                Zone2.Text = "O";
                Occupied = true;
            }
        }

        private void Zone3_Click(object sender, EventArgs e)
        {
            if (Occupied == true)
            {

                Zone3.Text = "X";
                Occupied = false;

            }
            else
            {

                Zone3.Text = "O";
                Occupied = true;
            }
        }

        private void Zone4_Click(object sender, EventArgs e)
        {
            if (Occupied == true)
            {

                Zone4.Text = "X";
                Occupied = false;

            }
            else
            {

                Zone4.Text = "O";
                Occupied = true;
            }
        }

        private void Zone5_Click(object sender, EventArgs e)
        {
            if (Occupied == true)
            {

                Zone5.Text = "X";
                Occupied = false;

            }
            else
            {

                Zone5.Text = "O";
                Occupied = true;
            }
        }

        private void Zone6_Click(object sender, EventArgs e)
        {
            if (Occupied == true)
            {

                Zone6.Text = "X";
                Occupied = false;

            }
            else
            {

                Zone6.Text = "O";
                Occupied = true;
            }
        }

        private void Zone7_Click(object sender, EventArgs e)
        {
            if (Occupied == true)
            {

                Zone7.Text = "X";
                Occupied = false;

            }
            else
            {

                Zone7.Text = "O";
                Occupied = true;
            }
        }

        private void Zone8_Click(object sender, EventArgs e)
        {
            if (Occupied == true)
            {

                Zone8.Text = "X";
                Occupied = false;

            }
            else
            {

                Zone8.Text = "O";
                Occupied = true;
            }
        }

        private void Zone9_Click(object sender, EventArgs e)
        {
            if (Occupied == true)
            {

                Zone9.Text = "X";
                Occupied = false;

            }
            else
            {

                Zone9.Text = "O";
                Occupied = true;
            }
        }
    }
}
