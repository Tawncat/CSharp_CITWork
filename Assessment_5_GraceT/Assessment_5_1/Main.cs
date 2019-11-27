//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 25/08/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Assessment 5. Utilising a dynamic linked library (Assessment_5_DLL). 
//          This program takes value in k/ph and converts it to other speed units.
//******************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculations;//Name of the dynamic linked library namespace

namespace Assessment_5_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            btnFeet.Enabled = false;
            btnMiles.Enabled = false;
            btnMetre.Enabled = false;
            btnKnot.Enabled = false;
            btnMach.Enabled = false;
        }

        Formulas speed = new Formulas();//name of the dll class

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {//enables buttons once there is a value entered
            btnFeet.Enabled = true;
            btnMiles.Enabled = true;
            btnMetre.Enabled = true;
            btnKnot.Enabled = true;
            btnMach.Enabled = true;
        }
        public void Reset()//clears the previous answer textbox and label
        {
            txtAnswer.Text = "";
            lblAnswer.Text = "";
        }

        private void BtnMiles_Click(object sender, EventArgs e)
        {//calculates miles per hour
            if (double.TryParse(txtInput.Text, out double kph))//checks for valid input
            {
                if (int.TryParse(txtRound.Text, out int round))
                {
                    txtAnswer.Text = Convert.ToString(speed.Miles(kph, round));//calls dll function
                    lblAnswer.Text = "Miles per Hour";
                    txtInput.BackColor = Color.White;
                    txtRound.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Enter a non-decimal number.");
                    txtRound.Text = "";
                    txtRound.BackColor = Color.Salmon;
                    Reset();
                }

                txtInput.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Enter a decimal number to convert.");
                txtInput.Text = "";
                txtInput.BackColor = Color.Salmon;
                Reset();
            }  
        }

        private void BtnFeet_Click(object sender, EventArgs e)
        {//calculates feet per hour
            if (double.TryParse(txtInput.Text, out double kph))//checks for valid input
            {
                if (int.TryParse(txtRound.Text, out int round))
                {
                    txtAnswer.Text = Convert.ToString(speed.Feet(kph, round));//calls dll function
                    lblAnswer.Text = "Feet per Hour";
                    txtInput.BackColor = Color.White;
                    txtRound.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Enter a non-decimal number.");
                    txtRound.Text = "";
                    txtRound.BackColor = Color.Salmon;
                    Reset();
                }

                txtInput.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Enter a decimal number to convert.");
                txtInput.Text = "";
                txtInput.BackColor = Color.Salmon;
                Reset();
            }
        }

        private void BtnMetre_Click(object sender, EventArgs e)
        {//calculates metres per hour
            if (double.TryParse(txtInput.Text, out double kph))//checks for valid input
            {
                if (int.TryParse(txtRound.Text, out int round))
                {
                    txtAnswer.Text = Convert.ToString(speed.Metre(kph, round));//calls dll function
                    lblAnswer.Text = "Metres per Hour";
                    txtInput.BackColor = Color.White;
                    txtRound.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Enter a non-decimal number.");
                    txtRound.Text = "";
                    txtRound.BackColor = Color.Salmon;
                    Reset();
                }

                txtInput.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Enter a decimal number to convert.");
                txtInput.Text = "";
                txtInput.BackColor = Color.Salmon;
                Reset();
            }
        }

        private void BtnKnot_Click(object sender, EventArgs e)
        {//calculates value into knots
            if (double.TryParse(txtInput.Text, out double kph))//checks for valid input
            {
                if (int.TryParse(txtRound.Text, out int round))
                {
                    txtAnswer.Text = Convert.ToString(speed.Knot(kph, round));//calls dll function
                    lblAnswer.Text = "Knots";
                    txtInput.BackColor = Color.White;
                    txtRound.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Enter a non-decimal number.");
                    txtRound.Text = "";
                    txtRound.BackColor = Color.Salmon;
                    Reset();
                }

                txtInput.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Enter a decimal number to convert.");
                txtInput.Text = "";
                txtInput.BackColor = Color.Salmon;
                Reset();
            }
        }

        private void BtnMach_Click(object sender, EventArgs e)
        {//calculates value into the speed of sound
            if (double.TryParse(txtInput.Text, out double kph))//checks for valid input
            {
                if (int.TryParse(txtRound.Text, out int round))
                {
                    txtAnswer.Text = Convert.ToString(speed.Mach(kph, round));//calls dll function
                    lblAnswer.Text = "Mach";
                    txtInput.BackColor = Color.White;
                    txtRound.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Enter a non-decimal number.");
                    txtRound.Text = "";
                    txtRound.BackColor = Color.Salmon;
                    Reset();
                }

                txtInput.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Enter a decimal number to convert.");
                txtInput.Text = "";
                txtInput.BackColor = Color.Salmon;
                Reset();
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
