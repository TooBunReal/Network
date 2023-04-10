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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Bai_6 : Form
    {
        public Bai_6()
        {
            InitializeComponent();
            foreach (DriveInfo path in DriveInfo.GetDrives())
            {
                TreeNode tn = new TreeNode();
                //đặt tên cho nhánh cây
                tn.Name = path.Name;
                //Gán nhãn volumecủa ổ đĩa vào nhánh cây
                tn.Text = path.VolumeLabel;
                //Nhận các đối tượng của class TreeNode rồi gán vào cây
                tw1.Nodes.Add(tn);
            }
            tw1.SelectedNode = null;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string path = tw1.SelectedNode.Name;
                if (ChkFile(path) == false)
                {
                    TreeNode tn = tw1.SelectedNode;
                    //Mảng chứa các thư mục
                    string[] dPath = Directory.GetDirectories(tn.Name);
                    //Mảng chứa các file
                    string[] fPath = Directory.GetFiles(tn.Name);
                    //Liệt kê các thư mục con lên nhánh cây
                    foreach (string subdirec in dPath)
                    {
                        bool nodeExisted = false;
                        foreach (TreeNode chktn in tn.Nodes)
                        {
                            //Kiểm tra các phần tử trong mảng đã tồn tại hết các Node trong cây chưa
                            if (string.Equals(tn.Name, subdirec) == true)
                                nodeExisted = true;
                        }
                        if (nodeExisted == false)
                        {
                            DirectoryInfo df = new DirectoryInfo(subdirec);
                            TreeNode newtn = new TreeNode();
                            newtn.Text = df.Name;
                            newtn.Name = subdirec;
                            tn.Nodes.Add(newtn);
                        }
                    }
                    foreach (string files in fPath)
                    {
                        bool nodeExisted = false;
                        foreach (TreeNode chktn in tn.Nodes)
                        {
                            //Kiểm tra các phần tử trong mảng đã tồn tại hết các Node trong cây chưa
                            if (string.Equals(tn.Name, files) == true)
                                nodeExisted = true;
                        }
                        if (nodeExisted == false)
                        {
                            DirectoryInfo df = new DirectoryInfo(files);
                            TreeNode newtn = new TreeNode();
                            newtn.Text = df.Name;
                            newtn.Name = files;
                            tn.Nodes.Add(newtn);
                        }
                    }
                    tn.Expand();
                }
                else
                {
                    if (path.Contains(".txt"))
                    {
                        gb1.Controls.Clear();
                        RichTextBox rtxtBox = new RichTextBox();
                        //Canh vị trí
                        rtxtBox.Dock = DockStyle.Fill;
                        gb1.Controls.Add(rtxtBox);
                        FileStream fs = new FileStream(path, FileMode.Open);
                        StreamReader sr = new StreamReader(fs);
                        rtxtBox.Text = sr.ReadToEnd();
                        fs.Close();
                    }
                    else if (path.Contains(".png") || path.Contains(".jpg"))
                    {
                        gb1.Controls.Clear();
                        PictureBox pb = new PictureBox();
                        //Địa chỉ
                        pb.ImageLocation = path;
                        //Canh vị trí
                        pb.Dock = DockStyle.Fill;
                        //Canh góc 
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        gb1.Controls.Add(pb);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ChkFile(string path)
        {
            FileAttributes fa = File.GetAttributes(path);
            //Kiểm tra xem file còn có thư mục con không?
            if (fa.HasFlag(FileAttributes.Directory) == true)
                return false;
            return true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
