using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                image = Image.FromFile(path);
                MessageBox.Show(path);
                pictureBox1.Image = image;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(image);
            for (int i = 0; i < bitmap.Width; i++) {
                for (int j = 0; j < bitmap.Height; j++) {
                    Color rgb = bitmap.GetPixel(i, j);
                    int a = 255 - rgb.R;
                    int b = 255 - rgb.G;
                    int c = 255 - rgb.B;
                    bitmap.SetPixel(i, j, Color.FromArgb(a,b,c));
                }
            }
            pictureBox2.Image = bitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(image);
            int ret;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color rgb = bitmap.GetPixel(i, j);
                    ret = (int)(rgb.R * 0.229 + rgb.G * 0.587 + rgb.B * 0.114);
                    bitmap.SetPixel(i, j, Color.FromArgb(ret, ret, ret));
                }
            }
            pictureBox3.Image = bitmap;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(image);
            int ret1;
            int ret2;
            int ret3;
            for (int i = 1; i < bitmap.Width-1; i++)
            {
                for (int j = 1; j < bitmap.Height-1; j++)
                {
                    Color rgb1 = bitmap.GetPixel(i-1, j-1);
                    Color rgb2 = bitmap.GetPixel(i, j-1);
                    Color rgb3 = bitmap.GetPixel(i+1, j-1);
                    Color rgb4 = bitmap.GetPixel(i-1, j);
                    Color rgb5 = bitmap.GetPixel(i, j);
                    Color rgb6 = bitmap.GetPixel(i+1, j);
                    Color rgb7 = bitmap.GetPixel(i-1, j+1);
                    Color rgb8 = bitmap.GetPixel(i, j+1);
                    Color rgb9 = bitmap.GetPixel(i+1, j+1);
                   ret1 = (rgb1.R + rgb2.R + rgb3.R + rgb4.R + rgb5.R + rgb6.R + rgb7.R + rgb8.R + rgb9.R) /9;
                   ret2 = (rgb1.G + rgb2.G + rgb3.G + rgb4.G + rgb5.G + rgb6.G + rgb7.G + rgb8.G + rgb9.G) / 9;
                    ret3 = (rgb1.B + rgb2.B + rgb3.B + rgb4.B + rgb5.B + rgb6.B + rgb7.B + rgb8.B + rgb9.B) / 9;
                  bitmap.SetPixel(i, j, Color.FromArgb(ret1, ret2, ret3));
                }
            }
            pictureBox4.Image = bitmap;

        }
    }
}
