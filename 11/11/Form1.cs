using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class FrmDrawRect : Form
    {
        public FrmDrawRect()
        {
            InitializeComponent();
        }
        Point clickPoint;
        Point movePoint;
        int dashOffset = 1;
        Boolean isPaint = false;
        private void FrmDrawRect_Load(object sender, EventArgs e)
        {

        }

        private void FrmDrawRect_MouseDown(object sender, MouseEventArgs e)
        {
            clickPoint = e.Location;
            this.Invalidate();
        }

        private void FrmDrawRect_MouseMove(object sender, MouseEventArgs e)
        {
            movePoint = e.Location;
            isPaint = true;
           
            this.Invalidate();
        }

        private void FrmDrawRect_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen.DashOffset = dashOffset;
            if (isPaint) {
                g.DrawRectangle(pen, clickPoint.X, clickPoint.Y, movePoint.X - clickPoint.X, movePoint.Y - clickPoint.Y);
            }
          

         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dashOffset++;
        }
    }
}
