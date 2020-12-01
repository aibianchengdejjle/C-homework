using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_实验五
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image image ;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            String path = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                path = openFileDialog.FileName;
                image = Image.FromFile(path);
                pictureBox1.Image = image;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(image);
            for (int i = 0; i < bmp.Width; i++) {
                for (int j = 0; j < bmp.Height; j++) {
                    Color rgb = bmp.GetPixel(i, j);
                    int grey = (rgb.R + rgb.G + rgb.B) / 3;
                    bmp.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }
            }
            pictureBox2.Image = bmp;
        }
    }
}
