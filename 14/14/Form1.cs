using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String x = textBox1.Text;
            String y = textBox1.Text;
            String[] x1 = x.Split('+');
            String s = x1[0];
            int a= int.Parse(s);
            String s2= x1[1].Substring(0,3);
            int b = int.Parse(s2);
            String X = textBox2.Text;
            String Y = textBox2.Text;
            String[] X1 = X.Split('+');
            String S = x1[0];
            int A = int.Parse(S);
            String S2 = x1[1].Substring(0, 3);
            int B = int.Parse(S2);
            int c = a + A;
            int d = b + B;
            String show = c.ToString() + "+" + d.ToString() + "i";
            textBox3.Text = show;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String x = textBox1.Text;
            String y = textBox1.Text;
            String[] x1 = x.Split('+');
            String s = x1[0];
            int a = int.Parse(s);
            String s2 = x1[1].Substring(0, 3);
            int b = int.Parse(s2);
            String X = textBox2.Text;
            String Y = textBox2.Text;
            String[] X1 = X.Split('+');
            String S = x1[0];
            int A = int.Parse(S);
            String S2 = x1[1].Substring(0, 3);
            int B = int.Parse(S2);
            int c = a - A;
            int d = b - B;
            String show = c.ToString() + "+" + d.ToString() + "i";
            textBox3.Text = show;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String x = textBox1.Text;
            String y = textBox1.Text;
            String[] x1 = x.Split('+');
            String s = x1[0];
            int a = int.Parse(s);
            String s2 = x1[1].Substring(0, 3);
            int b = int.Parse(s2);
            String X = textBox2.Text;
            String Y = textBox2.Text;
            String[] X1 = X.Split('+');
            String S = x1[0];
            int A = int.Parse(S);
            String S2 = x1[1].Substring(0, 3);
            int B = int.Parse(S2);
            int c = a * A - b * B;
            int d = A * b + a * B;
            String show = c.ToString() + "+" + d.ToString() + "i";
            textBox3.Text = show;
        }
    }
}
