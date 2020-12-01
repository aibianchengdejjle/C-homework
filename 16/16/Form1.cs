using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //正方形
            Pen pen = new Pen(Color.Red, 5);
            g = e.Graphics;
            g.DrawRectangle(pen, 100, 50, 200,200);
            Brush rectbush = new SolidBrush(Color.Yellow);
            g.FillRectangle(rectbush, 100, 50, 200, 200);
            //圆
            Pen Circlepen = new Pen(Color.Black, 5);
            Rectangle circleR = new Rectangle(350, 50, 200, 200);
            g.FillEllipse(Brushes.Blue, circleR);
            g.DrawEllipse(Circlepen, 350, 50, 200, 200);
            //直线
            g.FillRectangle(Brushes.Gray, 100, 350, 200, 20);

            //扇形
            Pen shanpen = new Pen(Color.Green,5);
            Rectangle shanr = new Rectangle(330, 230, 200, 200);
            g.DrawPie(shanpen, shanr, 45, 90);
            
        }
    }
}
