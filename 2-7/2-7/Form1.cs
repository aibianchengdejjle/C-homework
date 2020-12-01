using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            label2.Visible = false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightGray;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }
        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button1.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor= Color.FromArgb(18, 150, 17);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(26, 173, 25);
        }
    }
}
