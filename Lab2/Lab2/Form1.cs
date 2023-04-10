using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai_1 Bai_1 = new Bai_1();
            Bai_1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai_2 Bai_2 = new Bai_2();
            Bai_2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai_3 Bai_3 = new Bai_3();
            Bai_3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai_4 bai_4 = new Bai_4();
            bai_4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai_5 bai_5 = new Bai_5();
            bai_5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai_6 bai_6 = new Bai_6();
            bai_6.Show();
        }
    }
}
