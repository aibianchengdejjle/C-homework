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

namespace _19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            String path = null;
            int height = 25;
            int i = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                path  = openFileDialog.FileName;
                 StreamReader streamReader = new StreamReader(path);
                 String line;
                 while ((line = streamReader.ReadLine()) != null) {
                    richTextBox1.AppendText(i.ToString()+" : "+line+"\r\n");
                    i++;
                }
            }
        }
    }
}
