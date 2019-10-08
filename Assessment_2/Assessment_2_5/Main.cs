//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 07/10/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Assessment 2 - A program that uses comparators to sort a 1D array.
//******************************************************************
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assessment_2_5
{
    public partial class frmMain : Form
    {
        class ascending : IComparer //class to do ascending sort
        {
            public int Compare(Object x, Object y)
            {
                return String.Compare(Convert.ToString(x), Convert.ToString(y));
            }
        }
        class descending: IComparer //class to do descending sort
        {
            int IComparer.Compare(Object x, Object y)
            {
                return String.Compare(Convert.ToString(y),Convert.ToString(x));
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        string[] letters = new string[10] { "L", "H", "F", "k", "c", "s", "f", "E", "I", "m" };

        private void FrmMain_Load(object sender, EventArgs e)
        {
            foreach (string letter in letters)//displays the unsorted array
            {
                lstDisplay.Items.Add(letter);
            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            IComparer compare = new ascending();

            Array.Sort(letters, compare);

            foreach (string letter in letters)//displays the sorted array
            {
                lstDisplay.Items.Add(letter);
            }

            lblInfo.Visible = false;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            IComparer compare = new descending();

            Array.Sort(letters, compare);

            foreach (string letter in letters)//displays the reverse sorted array
            {
                lstDisplay.Items.Add(letter);
            }

            lblInfo.Visible = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}