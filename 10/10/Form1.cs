using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            {
                MessageBox.Show("用户名不能为空");

            }else if(textBox1.Text != null) {
                if (textBox1.Text == "20180001" && textBox2.Text == "123456"){
                    MessageBox.Show("登录成功");
                }
                else {
                    MessageBox.Show("登录失败");
                }
            }
        }
    }
}
