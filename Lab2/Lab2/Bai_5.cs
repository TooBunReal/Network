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
using System.IO.Compression;

namespace Lab2
{
    public partial class Bai_5 : Form
    {
        public Bai_5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Result = openFileDialog1.ShowDialog();
                if (Result == DialogResult.OK)
                {
                    string[] file = openFileDialog1.FileNames;
                    DialogResult saveFile = saveFileDialog1.ShowDialog();
                    saveFileDialog1.Filter = "*.zip | *.zip | *.gz | *.gz";
                    if (saveFile == DialogResult.OK)
                    {
                        ZipArchive zip = ZipFile.Open(saveFileDialog1.FileName, ZipArchiveMode.Create);
                        foreach (string words in file)
                        {
                            zip.CreateEntryFromFile(words, Path.GetFileName(words), CompressionLevel.Optimal);
                        }
                        zip.Dispose();
                        MessageBox.Show("Đã Nén", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_extr_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Result = openFileDialog1.ShowDialog();
                if (Result == DialogResult.OK)
                {
                    DialogResult Result2 = folderBrowserDialog1.ShowDialog();
                    if (Result2 == DialogResult.OK)
                    {
                        ZipFile.ExtractToDirectory(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath);
                        MessageBox.Show("Đã Giải Nén", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
