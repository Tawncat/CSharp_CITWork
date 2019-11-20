//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 02/11/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Assessment 4 - Main form with menu links to 3 other applications and an about message.
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void LinkedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLinkedList Linked_List = new frmLinkedList();
            Linked_List.ShowDialog();
        }

        private void BinaryTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBinaryTree Binary_Tree = new frmBinaryTree();
            Binary_Tree.ShowDialog();
        }

        private void HashTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHashTables Hash_Tables = new frmHashTables();
            Hash_Tables.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grace Toyer \nCIT014747 \nNovember 2019");
        }
    }
}
