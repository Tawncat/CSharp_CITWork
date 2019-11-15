//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 02/11/2019
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

            Hashtable hashtable = new Hashtable();
            hashtable.Add("Password", "Cat");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
