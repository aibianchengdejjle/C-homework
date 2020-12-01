using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Point MyPoint1, MyPoint2;
        Boolean isdrawing = false;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isdrawing = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isdrawing = true;
        }
        Graphics g;
        List<Point> plist = new List<Point>();
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isdrawing && e.Button == MouseButtons.Left) {
                plist.Add(e.Location);
                this.Invalidate();
            }
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen MyPen = new Pen(Color.White, 3);
            if (plist.Count >= 2) {
                g.DrawLines(MyPen, plist.ToArray());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
