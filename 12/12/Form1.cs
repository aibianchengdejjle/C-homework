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

namespace _12
{
    public partial class FrmKuwoMusic : Form
    {
        public FrmKuwoMusic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            String path = openFileDialog.FileName;
            StreamReader streamReader = new StreamReader(path,Encoding.Default);
            String line;
            int j = 0;
            List<String> songs=new List<string>();
            while ((line = streamReader.ReadLine())!=null){
                if (line.Length > 0) {
                String line1= line.Substring(10);
               // MessageBox.Show(line1);
               songs.Add(line1);
                j++;
                }
            }
            int height = 20;
            for (int i = 0; i < j; i++) {
                Label label = new Label();
                label.Text = songs[i];
                label.Location = new Point(100, height);
                height += 20;
                this.Controls.Add(label);
                
            }
        }
    }
}
