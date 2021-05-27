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
            if (Zone1.Text =="") {
                if (Occupied == true)
                {

                    Zone1.Text = "X";
                    Occupied = false;
                    Zone1.ForeColor = Color.Blue;
                    lbl_turn.Text = "O";
                    lbl_turn.ForeColor = Color.Red;

                }
                else
                {

                    Zone1.Text = "O";
                    Occupied = true;
                    Zone1.ForeColor = Color.Red;
                    lbl_turn.Text = "X";
                    lbl_turn.ForeColor = Color.Blue;
                }
            }
            

            //Winning Coniditons
            //Horizontal
            if (Zone1.Text == "O" && Zone2.Text == "O" && Zone3.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone1.Text == "X" && Zone2.Text == "X" && Zone3.Text == "X")
            {
                MessageBox.Show("Congratulations Blue Player!", "Winner");
            }

            //Diagonal
            if(Zone1.Text == "O" && Zone5.Text == "O" && Zone9.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone1.Text == "X" && Zone5.Text == "X" && Zone9.Text == "X")
            {
                MessageBox.Show("Congratulations Blue Player!", "Winner");
            }

            //Vertical
            if(Zone1.Text == "O" && Zone4.Text == "O" && Zone7.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone1.Text == "X" && Zone4.Text == "X" && Zone7.Text == "X")
            {
                MessageBox.Show("Congratulations Blue Player!", "Winner");
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Replay_Click(object sender, EventArgs e)
        {
            
            Zone1.Text = "";
            Zone2.Text = "";
            Zone3.Text = "";
            Zone4.Text = "";
            Zone5.Text = "";
            Zone6.Text = "";
            Zone7.Text = "";
            Zone8.Text = "";
            Zone9.Text = "";
            lbl_turn.Text = "O";
            lbl_turn.ForeColor = Color.Red;
            Occupied = false;
            

        }

        private void Zone2_Click(object sender, EventArgs e)
        {
            if (Zone2.Text == "") {
                if (Occupied == true)
                {

                    Zone2.Text = "X";
                    Occupied = false;
                    Zone2.ForeColor = Color.Blue;
                    lbl_turn.Text = "O";
                    lbl_turn.ForeColor = Color.Red;

                }
                else
                {

                    Zone2.Text = "O";
                    Occupied = true;
                    Zone2.ForeColor = Color.Red;
                    lbl_turn.Text = "X";
                    lbl_turn.ForeColor = Color.Blue;
                }
            }
            
            //Tic tac toe winning conditions
            //Horizontal
            if (Zone1.Text == "O" && Zone2.Text == "O" && Zone3.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone1.Text == "X" && Zone2.Text == "X" && Zone3.Text == "X")
            {
                MessageBox.Show("Congratulations Blue Player!", "Winner");
            }
            //Vertical
            if (Zone2.Text == "O" && Zone5.Text == "O" && Zone8.Text == "O") {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone2.Text == "X" && Zone5.Text == "X" && Zone8.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }
        }

        private void Zone3_Click(object sender, EventArgs e)
        {
            if (Zone3.Text == "") {
                if (Occupied == true)
                {

                    Zone3.Text = "X";
                    Occupied = false;
                    Zone3.ForeColor = Color.Blue;
                    lbl_turn.Text = "O";
                    lbl_turn.ForeColor = Color.Red;

                }
                else
                {

                    Zone3.Text = "O";
                    Occupied = true;
                    Zone3.ForeColor = Color.Red;
                    lbl_turn.Text = "X";
                    lbl_turn.ForeColor = Color.Blue;
                }
            }
            

            //Winning Conditions
            //Horizontal
            if (Zone1.Text == "O" && Zone2.Text == "O" && Zone3.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone1.Text == "X" && Zone2.Text == "X" && Zone3.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }

            //Diagonal
            if (Zone5.Text == "O" && Zone7.Text == "O" && Zone3.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone5.Text == "X" && Zone7.Text == "X" && Zone3.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }

            //Vertical
            if (Zone6.Text == "O" && Zone9.Text == "O" && Zone3.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone6.Text == "X" && Zone9.Text == "X" && Zone3.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }
            
        }

        private void Zone4_Click(object sender, EventArgs e)
        {
            if (Zone4.Text == "")
            {
                if (Occupied == true)
                {

                    Zone4.Text = "X";
                    Occupied = false;
                    Zone4.ForeColor = Color.Blue;
                    lbl_turn.Text = "O";
                    lbl_turn.ForeColor = Color.Red;

                }
                else
                {

                    Zone4.Text = "O";
                    Occupied = true;
                    Zone4.ForeColor = Color.Red;
                    lbl_turn.Text = "X";
                    lbl_turn.ForeColor = Color.Blue;
                }
            }
           

            //winning condtions
            //Vertical
            if (Zone1.Text == "O" && Zone4.Text == "O" && Zone7.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone1.Text == "X" && Zone4.Text == "X" && Zone7.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }

            //horizontal
            if (Zone5.Text == "O" && Zone4.Text == "O" && Zone6.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone5.Text == "X" && Zone4.Text == "X" && Zone6.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }
        }

        private void Zone5_Click(object sender, EventArgs e)
        {
            if (Zone5.Text == "") {
                if (Occupied == true)
                {

                    Zone5.Text = "X";
                    Occupied = false;
                    Zone5.ForeColor = Color.Blue;
                    lbl_turn.Text = "O";
                    lbl_turn.ForeColor = Color.Red;


                }
                else
                {

                    Zone5.Text = "O";
                    Occupied = true;
                    Zone5.ForeColor = Color.Red;
                    lbl_turn.Text = "X";
                    lbl_turn.ForeColor = Color.Blue;

                }
            }
           
            
            

            //Winning Conditions
            //Vertical
            if (Zone2.Text == "O" && Zone5.Text == "O" && Zone8.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone2.Text == "X" && Zone5.Text == "X" && Zone8.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }

            //Diagonal 1
            if (Zone1.Text == "O" && Zone5.Text == "O" && Zone9.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone1.Text == "X" && Zone5.Text == "X" && Zone9.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }

            //Diagonal 2
            if (Zone5.Text == "O" && Zone7.Text == "O" && Zone3.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone5.Text == "X" && Zone7.Text == "X" && Zone3.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }

            //horizontal
            if (Zone5.Text == "O" && Zone4.Text == "O" && Zone6.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone5.Text == "X" && Zone4.Text == "X" && Zone6.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }

        }

        private void Zone6_Click(object sender, EventArgs e)
        {
            if (Zone6.Text == "") {
                if (Occupied == true)
                {

                    Zone6.Text = "X";
                    Occupied = false;
                    Zone6.ForeColor = Color.Blue;
                    lbl_turn.Text = "O";
                    lbl_turn.ForeColor = Color.Red;

                }
                else
                {

                    Zone6.Text = "O";
                    Occupied = true;
                    Zone6.ForeColor = Color.Red;
                    lbl_turn.Text = "X";
                    lbl_turn.ForeColor = Color.Blue;
                }
            }
            

            //winning conditions
            //Vertical
            if (Zone6.Text == "O" && Zone9.Text == "O" && Zone3.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone6.Text == "X" && Zone9.Text == "X" && Zone3.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }

            //horizontal
            if (Zone5.Text == "O" && Zone4.Text == "O" && Zone6.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone5.Text == "X" && Zone4.Text == "X" && Zone6.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }
           
        }

        private void Zone7_Click(object sender, EventArgs e)
        {
            if (Zone7.Text == "") {
                if (Occupied == true)
                {

                    Zone7.Text = "X";
                    Occupied = false;
                    Zone7.ForeColor = Color.Blue;
                    lbl_turn.Text = "O";
                    lbl_turn.ForeColor = Color.Red;
                }
                else
                {

                    Zone7.Text = "O";
                    Occupied = true;
                    Zone7.ForeColor = Color.Red;
                    lbl_turn.Text = "X";
                    lbl_turn.ForeColor = Color.Blue;
                }
            }
            

            //winning condtions
            //Vertical
            if (Zone1.Text == "O" && Zone4.Text == "O" && Zone7.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone1.Text == "X" && Zone4.Text == "X" && Zone7.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }
            else
            {//Diagonal
                if (Zone5.Text == "O" && Zone7.Text == "O" && Zone3.Text == "O")
                {
                     MessageBox.Show("Congratulations Red Player!", "Winner");
                }
                if (Zone5.Text == "X" && Zone7.Text == "X" && Zone3.Text == "X")
                {
                     MessageBox.Show("Congratulations Blue Player!", "Winner");
                }
                else {
                    //horizontal
                    if (Zone7.Text == "O" && Zone8.Text == "O" && Zone9.Text == "O")
                    {
                         MessageBox.Show("Congratulations Red Player!", "Winner");
                    }
                    if (Zone8.Text == "X" && Zone7.Text == "X" && Zone9.Text == "X")
                    {
                         MessageBox.Show("Congratulations Blue Player!", "Winner");
                    }
                   
                }

                
            }
            

        }

        private void Zone8_Click(object sender, EventArgs e)
        {
            if (Zone8.Text == "") {
                if (Occupied == true)
                {
                    Zone8.Text = "X";
                    Occupied = false;
                    Zone8.ForeColor = Color.Blue;
                    lbl_turn.Text = "O";
                    lbl_turn.ForeColor = Color.Red;
                }
                else
                {
                    Zone8.Text = "O";
                    Occupied = true;
                    Zone8.ForeColor = Color.Red;
                    lbl_turn.Text = "X";
                    lbl_turn.ForeColor = Color.Blue;
                }
            }
            
            //Winning Condtions
            //Vertical
            if (Zone2.Text == "O" && Zone5.Text == "O" && Zone8.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            if (Zone2.Text == "X" && Zone5.Text == "X" && Zone8.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }
            else
            {
                //horizontal
                if (Zone7.Text == "O" && Zone8.Text == "O" && Zone9.Text == "O")
                {
                     MessageBox.Show("Congratulations Red Player!", "Winner");
                }
                if (Zone8.Text == "X" && Zone7.Text == "X" && Zone9.Text == "X")
                {
                     MessageBox.Show("Congratulations Blue Player!", "Winner");
                }
                
            }
        }

        private void Zone9_Click(object sender, EventArgs e)
        {
            if (Zone9.Text == "") {
                if (Occupied == true)
                {

                    Zone9.Text = "X";
                    Occupied = false;
                    Zone9.ForeColor = Color.Blue;
                    lbl_turn.Text = "O";
                    lbl_turn.ForeColor = Color.Red;
                }
                else
                {

                    Zone9.Text = "O";
                    Occupied = true;
                    Zone9.ForeColor = Color.Red;
                    lbl_turn.Text = "X";
                    lbl_turn.ForeColor = Color.Blue;
                }
            }
            

            //Winning Conditions
            //Diagonal
            if (Zone1.Text == "O" && Zone5.Text == "O" && Zone9.Text == "O")
            {
                 MessageBox.Show("Congratulations Red Player!", "Winner");
            }
            
            if (Zone1.Text == "X" && Zone5.Text == "X" && Zone9.Text == "X")
            {
                 MessageBox.Show("Congratulations Blue Player!", "Winner");
            }
            else
            { //Vertical
                if (Zone6.Text == "O" && Zone9.Text == "O" && Zone3.Text == "O")
                {
                     MessageBox.Show("Congratulations Red Player!", "Winner");
                }
                if (Zone6.Text == "X" && Zone9.Text == "X" && Zone3.Text == "X")
                {
                     MessageBox.Show("Congratulations Blue Player!", "Winner");
                }
                else {
                    //horizontal
                    if (Zone7.Text == "O" && Zone8.Text == "O" && Zone9.Text == "O")
                    {
                         MessageBox.Show("Congratulations Red Player!", "Winner");
                    }
                    if (Zone8.Text == "X" && Zone7.Text == "X" && Zone9.Text == "X")
                    {
                         MessageBox.Show("Congratulations Blue Player!", "Winner");
                    }
                   
                }
                 
            }
            
        }
    }
}
