//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 09/10/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Assessment 2 - Use of a nested class.
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

namespace Assessment_2_4
{
    public partial class frmMain : Form
    {
        public class Game
        {
            Details game;
            public Game()//constructor
            {
                game = new Details();
                game.title = "";
                game.year = 0;
            }

            public void AddGame(string title, int year)
            {
                game = new Details();
                game.title = title;
                game.year = year;
            }

            public string Display()
            {
                string result;
                result = game.GetDetails();
                return result;
            }

            private class Details//nested class
            {
                public string title;
                public int year;

                public string GetDetails()
                {
                    string result;
                    result = title + " - " + year;
                    return result;
                }
            }
        }

        public frmMain()
        {
            InitializeComponent();
            lstDisplay.Items.Add("Pokemon Yellow - 1996");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Game one = new Game();
            one.AddGame(txtTitle.Text, Convert.ToInt32(txtYear.Text));
            lstDisplay.Items.Add(one.Display());
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
