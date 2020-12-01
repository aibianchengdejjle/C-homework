using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point center;
        float sweepAng;
        float startAngle = 180;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //获得绘图对象
            Graphics g = e.Graphics;
            //抗锯齿，增加绘图平滑度
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rectRed = new Rectangle(center.X - 160, center.Y - 160,320,320);
            Rectangle rectOrange = new Rectangle(center.X - 140, center.Y - 140, 280, 280);
            Rectangle rectYellow = new Rectangle(center.X - 120, center.Y - 120, 240, 240);
            Rectangle rectGreen = new Rectangle(center.X - 100, center.Y - 100, 200, 200);
            Rectangle rectGreenYellow = new Rectangle(center.X - 80, center.Y - 80, 160, 160);
            Rectangle rectBlue = new Rectangle(center.X - 60, center.Y - 60, 120, 120);
            Rectangle rectPurple = new Rectangle(center.X - 40, center.Y - 40, 80, 80);

            g.FillPie(Brushes.Red, rectRed, startAngle,sweepAng);
            g.FillPie(Brushes.Orange, rectOrange, startAngle, sweepAng);
            g.FillPie(Brushes.Yellow, rectYellow, startAngle, sweepAng);
            g.FillPie(Brushes.Green, rectGreen, startAngle, sweepAng);
            g.FillPie(Brushes.GreenYellow, rectGreenYellow, startAngle, sweepAng);
            g.FillPie(Brushes.Blue, rectBlue, startAngle, sweepAng);
            g.FillPie(Brushes.Purple, rectPurple, startAngle, sweepAng);
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            center = new Point(this.Width / 2, this.Height / 2);
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sweepAng++;
            if (sweepAng > 180) {
                sweepAng = 0;
            }
            this.Invalidate();
        }
    }
}
