using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = richTextBox1.Text.Length;
            if (i>0)
            {
                Label label = new Label();
                label.Text = "贾久乐(" + DateTime.Now.ToLocalTime() + ")" + ":" + richTextBox1.Text;
                label.Font = new Font("微软雅黑", 15);
                label.Height = 40;
                label.Width = richTextBox1.Width - 20;
                flowLayoutPanel1.Controls.Add(label);
                richTextBox1.Text = "";
            }
            else {

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
        }
    }
}
