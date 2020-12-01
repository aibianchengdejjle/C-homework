using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval++;
            int i = 0;
            int j = 0;
            String[] a = new String[9];
            a[0] = "j";
            a[1] = "i";
            a[2] = "a";
            a[3] = "j";
            a[4] = "i";
            a[5] = "u";
            a[6] = "l";
            a[7] = "e";
            if (timer1.Interval > 500) {
                Random random = new Random();
                this.BackColor= Color.FromArgb(random.Next(250), random.Next(250), random.Next(250));
                if (i < 9)
                {
                    label1.Text = a[i++];
                }else {
                    i = 0;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
