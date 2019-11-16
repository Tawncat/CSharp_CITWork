//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 16/11/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Assessment 4 - Hash Tables
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
using System.Collections;

namespace Assessment_4
{
    public partial class frmHashTables : Form
    {
        public frmHashTables()
        {
            InitializeComponent();

            btnClear.Enabled = false;
            btnSearch.Enabled = false;

            Hashtable hashtable = new Hashtable();//creates a new empty hashtable

            //custom event handlers to recieve variables
            btnSubmit.Click += delegate (object sender, EventArgs e) { BtnSubmit_Click(sender, e, hashtable); };
            btnSearch.Click += delegate (object sender, EventArgs e) { BtnSearch_Click(sender, e, hashtable); };
            btnClear.Click += delegate (object sender, EventArgs e) { BtnClear_Click(sender, e, hashtable); };
        }

        //generates a *secret* value for each inputted key and adds them to the hashtable
        public void AddToHashtable(Hashtable hashtable)
        {
            double value;
            char key;
            bool check = char.TryParse(txtInput.Text, out key);//checks that the string entered can be converted to a char.

            if (check)
            {
                if (hashtable.ContainsKey(key) == false)//checks that the inputted key doesnt already exist
                {
                    value = key * .1;
                    hashtable.Add(key, value);
                    btnSearch.Enabled = true;
                    btnClear.Enabled = true;
                }
                else
                {
                    lblDisplay.Text = "That key already exists.";
                }
            }
            else
            {
                lblDisplay.Text = "Enter one character only.";
            }
        }

        //calls the AddToHashtable function, displays all keys entered and the amount of hashtable entries.
        private void BtnSubmit_Click(object sender, EventArgs e, Hashtable hashtable)
        {
            AddToHashtable(hashtable);
            lstDisplay.Items.Clear();

            foreach(DictionaryEntry entry in hashtable)//displays all the entered keys from the hashtable
            {
                lstDisplay.Items.Add(Convert.ToString(entry.Key));
            }

            int count = hashtable.Count;//returns the amount of entries in the hashtable
            lblTitle.Text = "Your Keys: " + Convert.ToString(count) + " entries.";

            txtInput.Text = "";

        }

        //searches for a key and outputs what its generated *secret* value is
        private void BtnSearch_Click(object sender, EventArgs e, Hashtable hashtable)
        {
            char key;
            bool check = char.TryParse(txtFind.Text, out key);//checks that the string entered can be converted to a char.

            if (check)
            {
                if (hashtable.ContainsKey(key))//checks that the char entered exists in the hashtable
                {
                    double value = (double)hashtable[key];//retrives the value of the found key
                    lblDisplay.Text = Convert.ToString("Key: " + key + " was found, it's value is: " + value);
                }
                else
                {
                    lblDisplay.Text = key + " was not found";
                }
            }
            else
            {
                lblDisplay.Text = "Enter one character only.";
            }

            txtFind.Text = "";
        }

        //clears the hashtable and resets the application
        private void BtnClear_Click(object sender, EventArgs e, Hashtable hashtable)
        {
            lstDisplay.Items.Clear();
            hashtable.Clear();
            lblDisplay.Text = "Hashtable Cleared";
            btnClear.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
        this.Close();
        }
    }
}
