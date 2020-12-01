using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                    Application.Exit();  
            }
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval++;                        int j = 0;            String[] a = new String[9];            a[0] = "j";            a[1] = "i";            a[2] = "a";            a[3] = "j";            a[4] = "i";            a[5] = "u";            a[6] = "l";            a[7] = "e";            if (timer1.Interval > 500)
            {                Random random = new Random();                this.BackColor = Color.FromArgb(random.Next(250), random.Next(250), random.Next(250));                if (i < 9){
                    label1.Text = a[i];                    i++;                }
                else{                    i = 0;                }            }
        }
    }
}
