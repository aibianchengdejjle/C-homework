using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image image;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            String path = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                path = openFileDialog.FileName;
                image = Image.FromFile(path);
                Image img2 = image.GetThumbnailImage(400, 400, null, IntPtr.Zero);
                pictureBox1.Image = img2;
                TextureBrush tb=new TextureBrush(img2);
                Graphics g = pictureBox2.CreateGraphics();
                Rectangle rect = new Rectangle(0, 0, 300, 300);
                g.FillEllipse(tb,rect);
                g.Dispose();

            }
        }
    }
}
