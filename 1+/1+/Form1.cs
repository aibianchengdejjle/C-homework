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

namespace _1_
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
            int i = 0;
            String path = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                StreamReader streamReader = new StreamReader(path);
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    richTextBox1.AppendText(line);
                }
            }
            openFileDialog.InitialDirectory = @"D:\新建文件夹.txt";
            openFileDialog.Filter = "(ppm文件)*.text|*.text";
            openFileDialog.ShowDialog();
            StreamReader sr = new StreamReader(openFileDialog.FileName);
            String s = sr.ReadToEnd();
            string[] pixels = s.Split(' ');
            Dictionary<string, int> dicWords = new Dictionary<string, int>();
            for (; i < pixels.Length; i++) {
                String word = pixels[i];
                if (dicWords.ContainsKey(word))
                {
                    dicWords[word]++;
                }
                else { //发现新单词
                    dicWords.Add(word, 1);
                }
            }
            var dicSort = from objDic in dicWords orderby objDic.Value descending select objDic;
            foreach (KeyValuePair<string, int> kvp in dicSort) {
                richTextBox2.AppendText(kvp.Key + " : " + kvp.Value.ToString() + "\r\n");
            }
        }
    }
}
