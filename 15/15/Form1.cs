using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
          button1.BackColor = Color.Blue;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            textBox1.PasswordChar ='\0';
        }
    }
}
