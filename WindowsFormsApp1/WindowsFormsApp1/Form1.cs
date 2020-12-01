using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            if (this.timer1.Interval % 4 == 0) {
                label2.Text = "正在显示";
            }
            if (this.timer1.Interval % 4 == 1)
            {
                label2.Text = "正在显示.";
            }
            if (this.timer1.Interval % 4 == 2)
            {
                label2.Text = "正在显示..";
            }
            if (this.timer1.Interval % 4 == 3)
            {
                label2.Text = "正在显示...";
            }
            timer1.Interval++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
