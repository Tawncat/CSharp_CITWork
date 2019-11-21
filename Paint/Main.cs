using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class frmMain : Form
    {
        bool paint = false;
        public SolidBrush b = new SolidBrush(Color.Black);
        Graphics g;
        int size = 10;
        const int maxSize = 20;
        const int minSize = 2;

        public frmMain()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                g.FillEllipse(b, e.X, e.Y, size, size);
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                b.Color = dlgColor.Color;
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int BrushBig(int size)
        {
            if (size < maxSize)
            {
                size += 1;
                return size;
            }
            else
            {
                size = 20;
                return size;
            }
        }

        private int BrushSmall(int size)
        {
            if (size == minSize)
            {
                size = 2;
                return size;
            }
            else if (size > minSize)
            {
                size -= 1;
                return size;
            }

            return size;
        }
        private void BtnBig_Click(object sender, EventArgs e)
        {
            size = BrushBig(size);
            lblSize.Text = size.ToString();
        }

        private void BtnSmall_Click(object sender, EventArgs e)
        {
            size = BrushSmall(size);
            lblSize.Text = size.ToString();
            
        }
    }
}
