//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 12/10/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Assessment 2 - A 2D graphic created using the C# Graphics class.
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

namespace Assessment_2_1
{

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();//graphics object

            //Tail curve points
            Point point1 = new Point(400, 177);
            Point point2 = new Point(450, 180);
            Point point3 = new Point(450, 100);
            Point point4 = new Point(490, 90);
            Point point5 = new Point(500, 110);
            Point[] tailPoints = { point1, point2, point3, point4, point5 };

            //Pens and Brushes
            Pen pBrown = new Pen(Color.SaddleBrown, 20);
            Pen pTan = new Pen(Color.Tan, 20);
            Pen pBlack = new Pen(Color.Black);
            Brush bBrown = new SolidBrush(Color.SaddleBrown);
            Brush bTan = new SolidBrush(Color.Tan);
            Brush bGold = new SolidBrush(Color.Gold);

            //shapes to make a cat (in my house a cat is an everyday object!)
            g.FillRectangle(bBrown, 250, 210, 20, 120);//front leg
            g.DrawLine(pBrown, 250, 210, 210, 320);//front leg

            g.FillRectangle(bBrown, 400, 210, 20, 120);//back leg
            g.DrawLine(pBrown, 410, 210, 470, 310);//back leg

            g.FillEllipse(bBrown, 230, 150, 200, 100);//body

            g.FillEllipse(bTan, 170, 120, 50, 50);//snout
            g.FillEllipse(bBrown, 180, 80, 100, 100);//head
            g.FillPie(bBrown, 160, -15, 120, 120, 50, 45);//ear
            g.FillEllipse(bGold, 200, 110, 15, 15);//eye
            g.FillEllipse(bBrown, 201, 111, 10, 10);//pupil
            g.FillEllipse(bBrown, 165, 130, 10, 10);//nose

            g.DrawLine(pBlack, 180, 150, 230, 160);//whiskers
            g.DrawLine(pBlack, 180, 145, 230, 150);
            g.DrawLine(pBlack, 180, 140, 230, 130);

            g.DrawCurve(pBrown, tailPoints);//tail

            Font drawFont = new Font("Arial", 16);
            PointF drawPoint = new PointF(100.0F, 100.0F);
            g.DrawString("Meow!", drawFont, bGold, drawPoint);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
