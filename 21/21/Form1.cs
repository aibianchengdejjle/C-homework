using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        List<Image> ear = new List<Image>();
        List<Image> huxv = new List<Image>();
        Boolean ispainting = false;
        int index=0;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
              g = e.Graphics;
            Image image = Image.FromFile(@"D:\桌面练习  V3\桌面练习  V3\girl2.jpeg");
            g.DrawImage(image, new Rectangle(0, 0, 400, 400));
            if (ispainting&&index<ear.Count) {
                g.DrawImage(ear[index], new Rectangle(60, 5, 200, 90));
            }
            if (index<huxv.Count) {
                g.DrawImage(huxv[index], new Rectangle(60,100,200,90));
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ispainting)
            {
                DirectoryInfo di = new DirectoryInfo(@"D:\桌面练习  V3\桌面练习  V3\ear");
                Image image = Image.FromFile(@"D:\桌面练习  V3\桌面练习  V3\girl2.jpeg");
                foreach (FileInfo fi in di.GetFiles())
                {
                    if (fi.Name.ToUpper().EndsWith(".BMP") || fi.Name.ToUpper().EndsWith(".PNG"))
                    {                                           
                            ear.Add(Image.FromFile(fi.FullName));
                    }
                }
                DirectoryInfo di1 = new DirectoryInfo(@"D:\桌面练习  V3\桌面练习  V3\moustache");
                foreach (FileInfo fi1 in di1.GetFiles())
                {
                    if (fi1.Name.ToUpper().EndsWith(".BMP") || fi1.Name.ToUpper().EndsWith(".PNG"))
                    {
                        huxv.Add(Image.FromFile(fi1.FullName));
                    }
                }
                timer1.Enabled = true;
            }
            else {
                ispainting = false;
            }   
            this.Invalidate();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval++;
            index++;
            pictureBox1.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ispainting = true;
        }
    }
}
