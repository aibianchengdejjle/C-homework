using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_8
{
    public partial class FrmDistanceMeasure : Form
    {
        public FrmDistanceMeasure()
        {
            InitializeComponent();
        }
        Graphics g;
        Point clickPoint;//先定义两个坐标
        Point movePoint;
        bool isPaint = false;
        bool isPaintStop = false;
        private void FrmDistanceMeasure_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Image image = Image.FromFile("yaoming.jpg");
            g.DrawImage(image, 0, 0);
            if (isPaint) {
                Brush brush = new SolidBrush(Color.White);
                Pen pen = new Pen(Color.White);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;//让笔画虚线
                pen.DashPattern = new float[] { 5, 5 };
                g.FillEllipse(brush, clickPoint.X - 10, clickPoint.Y - 10, 20, 20);
                g.DrawEllipse(pen, clickPoint.X - 20, clickPoint.Y - 20, 40, 40);
                g.FillEllipse(brush, movePoint.X - 10, movePoint.Y - 10, 20, 20);
                g.DrawEllipse(pen, movePoint.X - 20, movePoint.Y - 20, 40, 40);
                g.DrawLine(new Pen(Color.White, 3), clickPoint, movePoint);
                
            }
            if (isPaintStop) {
                Double distance = Math.Sqrt((clickPoint.X - movePoint.X) * (clickPoint.X - movePoint.X) + (clickPoint.Y - movePoint.Y) * (clickPoint.Y - movePoint.Y)) * 0.34; //距离换算
                g.DrawString(distance.ToString("f0") + "cm", this.Font, Brushes.White, 0, 0);
            }

        }
        private void FrmDistanceMeasure_MouseDown(object sender, MouseEventArgs e)
        {
            isPaint = true;
            clickPoint = new Point(e.X, e.Y);//鼠标点下，把此时鼠标的坐标传递过去
            Invalidate();
        }

        private void FrmDistanceMeasure_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isPaintStop)
            {//如果鼠标按下还没有停止，那么一直更新movePoint的坐标，我们根据这个坐标来画圆，因为这个坐标只有一个，所以我们只会画出一个圆，而如果在这里面写画图形的方法，我们会画出无数个圆，希望能够理解。（PS：其实这里一个bool变量isPaint就能控制，用两个变量可以增大代码的健壮性，方便后续写入功能）
                movePoint = new Point(e.X, e.Y);
                Invalidate();//调用方法是为了调用Paint方法
            }
        }

        private void FrmDistanceMeasure_MouseUp(object sender, MouseEventArgs e)
        {
            isPaintStop = true;
            Invalidate();
        }
    }
 }

