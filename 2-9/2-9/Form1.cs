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

namespace _2_9
{
    public partial class FrmPPMViewer : Form
    {
        public FrmPPMViewer()
        {
            InitializeComponent();
        }
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             OpenFileDialog openFileDialog = new OpenFileDialog();
             try
             {
                 openFileDialog.InitialDirectory = @"D:\桌面练习  V2\桌面练习  V2";
                 openFileDialog.Filter = "(ppm文件)*.ppm|*.ppm";
                 openFileDialog.ShowDialog();
                 StreamReader sr = new StreamReader(openFileDialog.FileName);
                 string strTotal = sr.ReadToEnd();
                 string[] pixels = strTotal.Split(new char[2] {' ','\n'},StringSplitOptions.RemoveEmptyEntries);//以空格为分割点的意思
                 int v = 4;
                 Bitmap bitmap = new Bitmap(int.Parse(pixels[1]), int.Parse(pixels[2]));//创建ppm相对应大小得bitmao
                 for (int i = 0; i < int.Parse(pixels[2]); i++)
                 {
                     for (int j = 0; j < int.Parse(pixels[1]); j++)
                     {
                         int a = int.Parse(pixels[v]);
                         int b = int.Parse(pixels[v+1]);
                         int c = int.Parse(pixels[v+2]);
                        // MessageBox.Show(a.ToString() + "-----" + b.ToString() + "----"+c.ToString());                       
                         bitmap.SetPixel(j, i, Color.FromArgb(a, b, c));
                         v = v + 3;
                     }
                 }
                 this.BackgroundImage = bitmap;
             }
             catch { }
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
