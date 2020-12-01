using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String a, b, c, a1, b1, c1;

        private void button5_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int x1 = int.Parse(textBox4.Text);
            int y = int.Parse(textBox2.Text);
            int y1 = int.Parse(textBox5.Text);
            int z = int.Parse(textBox3.Text);
            int z1 = int.Parse(textBox6.Text);
            MessageBox.Show((x * x1).ToString() + " x+ " + (y * y1).ToString() + " y+ " + (z * z1).ToString() + " z+ ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int x1 = int.Parse(textBox4.Text);
            int y = int.Parse(textBox2.Text);
            int y1 = int.Parse(textBox5.Text);
            int z = int.Parse(textBox3.Text);
            int z1 = int.Parse(textBox6.Text);
            MessageBox.Show((x - x1).ToString() + " x+ " + (y - y1).ToString() + " y+ " + (z - z1).ToString() + " z+ ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           int x= int.Parse(textBox1.Text);
           int x1=  int.Parse(textBox4.Text);
            int y = int.Parse(textBox2.Text);
            int y1 = int.Parse(textBox5.Text);
            int z = int.Parse(textBox3.Text);
            int z1 = int.Parse(textBox6.Text);
            MessageBox.Show((x + x1).ToString()+" x+ "+(y+y1).ToString()+" y+ "+(z+z1).ToString()+" z+ ");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* a = textBox4.Text;
             b = textBox5.Text;
             c = textBox6.Text;
             a1 = textBox1.Text;
             b1 = textBox1.Text;
             c1 = textBox1.Text;*/
            a1 = textBox4.Text;
            b1 = textBox5.Text;
            c1 = textBox6.Text;
            Vector3D vector3D = new Vector3D(a1, b1, c1);
            MessageBox.Show(vector3D.getLength());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
          //  MessageBox.Show(a);
            b = textBox2.Text;
            c = textBox3.Text;
            Vector3D vector3D = new Vector3D(a, b, c);
            MessageBox.Show( vector3D.getLength());

        }
    }
}
