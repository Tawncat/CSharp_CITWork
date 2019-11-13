//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 02/11/2019
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

            //custom event handlers to recieve parameters
            btnForward.Click += delegate (object sender, EventArgs e) { btnForward_Click(sender, e, data); };
            btnBackward.Click += delegate (object sender, EventArgs e) { btnBackward_Click(sender, e, data); };
            btnSubmit.Click += delegate (object sender, EventArgs e) { btnSubmit_Click(sender, e, data); };
        }

        public string Forward(LinkedList<char> list)
        {
            string result = "";

            for (LinkedListNode<char> node = list.Last; node != null; node = node.Previous)
            {
                char letter = node.Value;
                result += letter;
            }
            return result;
        }
        public string Backward(LinkedList<char> list)
        {
            string result = "";

            for (LinkedListNode<char> node = list.First; node != null; node = node.Next)
            {
                char letter = node.Value;
                result += letter;
            }
            return result;
        }

        public void Input(LinkedList<char> data)
        {
            lblDisplay.Text = "";
            data.Clear();

            btnBackward.Enabled = false;
            btnForward.Enabled = false;

            string temp = "";
            temp = txtInput.Text;
            var input = temp.ToCharArray();
            if (input.Length >= 7)
            {
                foreach (char letter in input)
                {
                    data.AddFirst(letter);
                    lblDisplay.Text += Convert.ToString(letter);
                }

                if (Backward(data) != temp)
                {
                    lblDisplay.Text = "That is not a palindrome.";
                }
                else
                {
                    btnBackward.Enabled = true;
                    btnForward.Enabled = true;
                }
            }
            else
            {
                lblDisplay.Text = "Enter a 7 letter palindrome.";
            }
        }

        private void btnForward_Click(object sender, EventArgs e, LinkedList<char> data)
        {
            lblDisplay.Text = "Forwards: " + Convert.ToString(Forward(data));
        }

        private void btnBackward_Click(object sender, EventArgs e, LinkedList<char> data)
        {
            lblDisplay.Text = "Backwards: " + Convert.ToString(Backward(data));
        }

        private void btnSubmit_Click(object sender, EventArgs e, LinkedList<char> data)
        {
            Input(data);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
