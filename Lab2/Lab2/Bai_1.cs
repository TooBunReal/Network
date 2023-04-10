using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai_1 : Form
    {
        public Bai_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();
            path = ofd.FileName;
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            fs.Seek(0, SeekOrigin.Begin);
            richTextBox1.Text = sr.ReadToEnd();
            fs.Close();
        }    
        private void button2_Click(object sender, EventArgs e)
        {
            string[] _path = path.Split('\\');
            string outPath = path.Replace(_path[_path.Length - 1], "output.txt");

            FileStream fs = new FileStream(outPath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter fwiter = new StreamWriter(fs);
            string a = richTextBox1.Text.ToUpper();
            fwiter.Write(richTextBox1.Text.ToUpper());
            fwiter.Close();
            MessageBox.Show("Đã Ghi");
        }
    }
}
