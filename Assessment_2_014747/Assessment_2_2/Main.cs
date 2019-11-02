//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 07/10/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Assessment 2 - An application that displays drag and dropped images.
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
using System.IO;

namespace Assessment_2_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;//enable drag and drop

            //event handlers for functionality
            this.DragEnter += new DragEventHandler(FrmMain_DragEnter);
            this.DragDrop += new DragEventHandler(FrmMain_DragDrop);
        }

        private void FrmMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }

        private void FrmMain_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string img in files)//check that file extensiom can be read
            {
                if (Path.GetExtension(img).Equals(".png", StringComparison.CurrentCultureIgnoreCase) || 
                    Path.GetExtension(img).Equals(".jpg", StringComparison.CurrentCultureIgnoreCase) ||
                    Path.GetExtension(img).Equals(".jpeg", StringComparison.CurrentCultureIgnoreCase) || 
                    Path.GetExtension(img).Equals(".tiff", StringComparison.CurrentCultureIgnoreCase) || 
                    Path.GetExtension(img).Equals(".gif", StringComparison.CurrentCultureIgnoreCase))
                {
                    imgDisplay.Visible = true;
                    imgDisplay.Image = Image.FromFile(files[0]);
                    lblInfo.Visible = false;
                    lblTypes.Visible = false;
                }
                else
                {
                    imgDisplay.Visible = false;
                    lblInfo.Text = "Error - Use a png, jpg, jpeg, tiff or gif file only.";
                    lblInfo.Visible = true;
                    lblTypes.Visible = false;
                }
            }

        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}