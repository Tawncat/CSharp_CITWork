//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 13/11/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Assessment 4 - Doubly Linked List Application
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

namespace Assessment_4
{
    public partial class frmLinkedList : Form
    {
        public frmLinkedList()
        {
            InitializeComponent();

            btnBackward.Enabled = false;
            btnForward.Enabled = false;
            LinkedList<char> data = new LinkedList<char>();//creating the linked list

            //custom event handlers to allow passing parameters to the event
            btnForward.Click += delegate (object sender, EventArgs e) { btnForward_Click(sender, e, data); };
            btnBackward.Click += delegate (object sender, EventArgs e) { btnBackward_Click(sender, e, data); };
            btnSubmit.Click += delegate (object sender, EventArgs e) { btnSubmit_Click(sender, e, data); };
        }

        public string Forward(LinkedList<char> list)
        {//function that returns the contents of the doubly linked list from the first to last node.
            string result = "";

            for (LinkedListNode<char> node = list.First; node != null; node = node.Next)
            {
                char letter = node.Value;
                result += letter;
            }

            return result;
        }
        public string Backward(LinkedList<char> list)
        {//function that returns the contents of the doubly linked list from the last to first node.
            string result = "";

            for (LinkedListNode<char> node = list.Last; node != null; node = node.Previous)
            {
                char letter = node.Value;
                result += letter;
            }
 
            return result;
        }

        public void Input(LinkedList<char> data)
        {//This function adds the inputed text to the doubly linked list if it meets certain conditions
            lblDisplay.Text = "";
            data.Clear();//clear all nodes in the list

            btnBackward.Enabled = false;
            btnForward.Enabled = false;

            string temp = "";
            temp = txtInput.Text;
            var input = temp.ToCharArray();//convert the input string into a character array

            if (input.Length >= 7)//check that the number of characters in the inputted word is 7 or more.
            {
                foreach (char letter in input)//adds each char in the array to the linked list and prints out the inputted word
                {
                    data.AddFirst(letter);
                    lblDisplay.Text += Convert.ToString(letter);
                }

                if (Forward(data) != temp)//checks if the characters entered form a palindrome.
                {
                    lblStatus.Text = temp + " is NOT a palindrome.";
                }
                else
                {
                    lblStatus.Text = temp + " IS a palindrome.";
                }

                btnBackward.Enabled = true;
                btnForward.Enabled = true;
                txtInput.Text = "";

            }
            else
            {
                lblDisplay.Text = "Enter at least 7 letters.";
                lblStatus.Text = "";
            }
        }

        private void btnForward_Click(object sender, EventArgs e, LinkedList<char> data)
        {//uses the opposite function as the linked list is populated by adding to the front
            lblDisplay.Text = Convert.ToString(Backward(data));
            btnForward.BackColor = Color.Gold;
            btnBackward.BackColor = Color.Transparent;
        }

        private void btnBackward_Click(object sender, EventArgs e, LinkedList<char> data)
        {//uses the opposite function as the linked list is populated by adding to the front
            lblDisplay.Text = Convert.ToString(Forward(data));
            btnBackward.BackColor = Color.Gold;
            btnForward.BackColor = Color.Transparent;
        }

        private void btnSubmit_Click(object sender, EventArgs e, LinkedList<char> data)
        {
            Input(data);
            btnBackward.BackColor = Color.Transparent;
            btnForward.BackColor = Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
