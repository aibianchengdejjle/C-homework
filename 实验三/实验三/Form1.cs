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

namespace 实验三
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog dlg = new OpenFileDialog();



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            String path = null;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = fdlg.FileName;
                path = fdlg.FileName;
                Random random=new Random();
                if (path != null)
                {
                    FileStream aFile = new FileStream(path, FileMode.Open);
                    try{
                        StreamReader streamReader = new StreamReader(aFile);
                        String line = null;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            Label label = new Label();
                            label.Text = line;
                            label.Font = new Font("微软雅黑", 20);
                            label.ForeColor = Color.FromArgb(random.Next(250), random.Next(250), random.Next(250));
                            label.Height = 40;
                            label.Width = flowLayoutPanel1.Width-10;
                            textBox1.Text = line;
                            flowLayoutPanel1.Controls.Add(label);
                        }
                    }
                    catch(Exception error) {
                        Console.Write(error.Message);
                    }
                   
                }
            }else {
                Console.WriteLine("文件路径为空");
            }
        }
    }
}
