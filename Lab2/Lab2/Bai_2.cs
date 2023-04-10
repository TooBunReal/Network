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

namespace Lab2
{
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
        }
        string path,line;
        int lineCount,wordsCount;

        private void bt_doc_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();
            path = ofd.FileName;
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            fs.Seek(0, SeekOrigin.Begin);
            richTextBox1.Text = sr.ReadToEnd();
            string[] name = fs.Name.Split('\\');
            fs.Seek(0, SeekOrigin.Begin);
            while (sr.ReadLine() != null)
            {
                lineCount++;
            }
            fs.Seek(0, SeekOrigin.Begin);
            do
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    wordsCount += line.Split(' ').Length;
                }
            }
            while (line != null);
      
            txb_name.Text = name[name.Length -1];
            txb_url.Text = ofd.FileName;
            txb_size.Text = fs.Length.ToString() + " bytes";
            txb_line.Text = lineCount.ToString();
            txb_words.Text = wordsCount.ToString();
            txb_char.Text = fs.Length.ToString();
            fs.Close();
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
