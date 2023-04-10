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
    public partial class Bai_3 : Form
    {
        public Bai_3()
        {
            InitializeComponent();
        }
        string path;
        private void bt_doc_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            fs.Seek(0, SeekOrigin.Begin);
            textBox1.Text = sr.ReadToEnd();
            path = ofd.FileName;
            sr.Close();
            fs.Close();
        }
        private void cal()
        {
            string[] eq = textBox1.Text.Split('\n', '\r');
            path = path.Replace("input3.txt", "output3.txt");
            StreamWriter sw = new StreamWriter(path);
            foreach (var equation in eq)
            {
                if (equation != "")
                {
                    double result = Convert.ToDouble(new System.Data.DataTable().Compute(equation, ""));
                    string res = $"{equation}={result}\n";
                    sw.WriteLine(res);
                }
            }
            sw.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cal_Click(object sender, EventArgs e)
        {
            cal();
            MessageBox.Show("Tính xong r đó ba");
        }
    }
}
