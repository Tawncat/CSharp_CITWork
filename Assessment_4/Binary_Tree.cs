//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 14/11/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Assessment 4 - Binary Search Tree
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
    public partial class frmBinaryTree : Form
    {
        const int minsize = 10;//the amount of integers needed

        class Node
        {
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
            public int Data { get; set; }
        }

        class BinaryTree
        {
            public Node Root { get; set; }

            //add the input value to the binary tree
            public bool Add(int value)
            {

                Node newNode = new Node();
                newNode.Data = value;

                if (this.Root == null)//Tree is empty
                {
                    this.Root = newNode;//New root node
                }
                else
                {
                    Node after = this.Root;
                    Node before;

                    while (true)
                    {
                        before = after;//before copys the root data
                        if (value < after.Data)//if value is less than the root
                        {
                            after = after.LeftNode;//move pointer to the left
                            if (after == null)//if after points to nothing
                            {
                                before.LeftNode = newNode;//add new node containing value to the left
                                break;
                            }
                        }
                        else
                        {
                            after = after.RightNode;//move pointer to the right
                            if (after == null)//if after points to nothing
                            {
                                before.RightNode = newNode;//add new node containing value to the right
                                break;
                            }
                        }
                    }
                }

                return true;
            }

            //counts the amount of nodes in the tree including the root
            public int Count_Recursive(Node node)
            {
                int count = 1;

                if (node.LeftNode != null)
                {
                    count += Count_Recursive(node.LeftNode);
                }
                if (node.RightNode != null)
                {
                    count += Count_Recursive(node.RightNode);
                }

                return count;
            }
            public int Count(Node node)
            {
                int count = 0;
                if (this.Root != null)
                {
                    count = Count_Recursive(this.Root);
                }
                return count;
            }
            public int DisplayCount()
            {
                return this.Count(this.Root);
            }

            //removes selected node that matches specifies key
            private Node Remove(Node parent, int key)
            {
                if (parent == null)
                {
                    return parent;
                }

                if (key < parent.Data)
                {
                    parent.LeftNode = Remove(parent.LeftNode, key);
                }
                else if (key > parent.Data)
                {
                    parent.RightNode = Remove(parent.RightNode, key);
                }
                else//if value is the same as parents value, then this is the node to be deleted
                {
                    //node with only one or no child
                    if (parent.LeftNode == null)
                    {
                        return parent.RightNode;
                    }
                    else if (parent.RightNode == null)
                    {
                        return parent.LeftNode;
                    }

                    //node with 2 children: Get the inorder successor(smallest in the right subtree)
                    parent.Data = MinValue(parent.RightNode);

                    //delete the  inoder successor
                    parent.RightNode = Remove(parent.RightNode, parent.Data);
                }

                return parent;
            }
            public void Remove(int value)
            {
                Remove(this.Root, value);
            }

            //finds the smallest value node in the tree
            private int MinValue(Node node)
            {
                int minv = node.Data;

                while (node.LeftNode != null)
                {
                    minv = node.LeftNode.Data;
                    node = node.LeftNode;
                }

                return minv;
            }

            //finds the specified value from the tree
            private Node Find(int value, Node parent)
            {
                if (parent != null)
                {
                    if (value == parent.Data)
                    {
                        return parent;
                    }

                    if (value < parent.Data)
                    {
                        return Find(value, parent.LeftNode);
                    }
                    else
                    {
                        return Find(value, parent.RightNode);
                    }
                }
                return null;
            }
            public Node Find(int value)
            {
                return this.Find(value, this.Root);
            }

            //Displays the data in each node in numerical order
            public string TraverseInOrder(Node parent)
            {
                string display = "";
                if (parent != null)
                {
                    display += TraverseInOrder(parent.LeftNode);
                    display += parent.Data + " \n";
                    display += TraverseInOrder(parent.RightNode);
                }
                return display;
            }
        }

        public frmBinaryTree()
        {
            InitializeComponent();

            btnSearch.Enabled = false;
            txtSearch.Enabled = false;
            btnDisplay.Enabled = false;

            BinaryTree tree = new BinaryTree();//Creation of the Binary Tree

            //custom event handlers to allow passing parameters to the event
            btnSubmit.Click += delegate (object sender, EventArgs e) { btnSubmit_Click(sender, e, tree); };
            btnDisplay.Click += delegate (object sender, EventArgs e) { btnDisplay_Click(sender, e, tree); };
            btnSearch.Click += delegate (object sender, EventArgs e) { btnSearch_Click(sender, e, tree); };
            btnReset.Click += delegate (object sender, EventArgs e) { btnReset_Click(sender, e, tree); };
        }

        //adds the inputted integers to the binary tree
        private void btnSubmit_Click(object sender, EventArgs e, BinaryTree tree)
        {
            int input;
            bool intcheck = int.TryParse(txtIntegers.Text, out input);//checks that the string entered can be converted to an int.

            if (intcheck == true)//if it can be converted
            {
                tree.Add(Convert.ToInt32(txtIntegers.Text));//add the input to the Binary Tree
                lblDisplay.Text = Convert.ToString(tree.DisplayCount()) + " Numbers Entered";
                txtIntegers.Clear();

                if (tree.DisplayCount() >= minsize)//enables the display button when enough integers have been entered
                {
                    btnDisplay.Enabled = true;
                }

            }
            else//error message shown and input box it cleared
            {
                System.Windows.Forms.MessageBox.Show("Enter a non-decimal integer only.");
                txtIntegers.Clear();
            }
        }

        //displays the binary tree node data in the listbox
        private void btnDisplay_Click(object sender, EventArgs e, BinaryTree tree)
        {
            List<string> list = new List<string>();//creates a list to hold the in order binary tree data

            if (tree.DisplayCount() >= minsize)//binary tree must contain more than 10 integers
            {
                list.Clear();
                lstDisplay.Items.Clear();//clear the previous data from list

                string treedata = tree.TraverseInOrder(tree.Root);
                list = treedata.Split(' ').ToList();//split the data from the binary tree and input it into a list for display.

                for (int i = 0; i < list.Count; i++)//display the list data
                {
                    lstDisplay.Items.Add(list[i]);
                }

                txtSearch.Enabled = true;
            }
  
        }

        //searches the binary tree for the inputted key
        private void btnSearch_Click(object sender, EventArgs e, BinaryTree tree)
        {
            int key = Convert.ToInt32(txtSearch.Text);
            if (tree.Find(key) == null)
            {
                lblDisplay.Text = key + " is Not Found";
                txtSearch.Text = "";
            }
            else
            {
                lblDisplay.Text = key + " is Found!";
                txtSearch.Text = "";
            }
        }

        //clears the tree and any input, resets application
        private void btnReset_Click(object sender, EventArgs e, BinaryTree tree)
        {
            lstDisplay.Items.Clear();
            tree.Root = null;
            lblDisplay.Text = "Waiting for input...";
            txtSearch.Text = "";
            btnSearch.Enabled = false;
            txtSearch.Enabled = false;
            btnDisplay.Enabled = false;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {//only enables the search button if text is entered

            btnSearch.Enabled = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
