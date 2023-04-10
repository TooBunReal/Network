using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{

    public partial class Bai_4 : Form
    {
        
        public Bai_4()
        {
            InitializeComponent();
        }

        [Serializable]
        class SinhVien
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string Phone { get; set; }
            public float Course1 { get; set; }
            public float Course2 { get; set; }
            public float Course3 { get; set; }
            public float Avr { get; set; }
            private static List<SinhVien> DSSinhVien { get; set; }

            internal static void _DSSinhVien(SinhVien sv)
            {
                if (DSSinhVien == null)
                    DSSinhVien = new List<SinhVien>();
                DSSinhVien.Add(sv);
            }

            internal static List<SinhVien> _DSSinhVien()
            {
                if (DSSinhVien == null)
                    DSSinhVien = new List<SinhVien>();
                return DSSinhVien;
            }
            public override string ToString()
            {
                return Name + "\n" + ID + "\n" + Phone + "\n" + Course1 + "\n" + Course2 + "\n" + Course3 + "\n";
            }
        }

        int page = 0, size;
        List<SinhVien> ListSV;


        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = CheckInput();
                SinhVien._DSSinhVien(sv);
                ListSV = SinhVien._DSSinhVien();
                rtb_Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rtb_Show()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SinhVien words in ListSV)
            {
                sb.Append(words);
                sb.AppendLine();
            }
            rtb.Text = sb.ToString();
        }

        private SinhVien CheckInput()
        {
            if (txb_Name_i.Text == "")
            {
                txb_Name_i.Focus();
                throw new Exception("Bạn chưa nhập họ tên.");
            }
            if (txb_ID_i.Text == "")
            {
                txb_ID_i.Focus();
                throw new Exception("Bạn chưa nhập họ tên.");
            }
            if (txb_Phone_i.Text == "")
            {
                txb_Phone_i.Focus();
                throw new Exception("Bạn chưa nhập số điện thoại.");
            }
            if (txb_Course1_i.Text == "")
            {
                txb_Course1_i.Focus();
                throw new Exception("Bạn chưa nhập điểm môn thứ 1.");
            }
            if (txb_Course2_i.Text == "")
            {
                txb_Course2_i.Focus();
                throw new Exception("Bạn chưa nhập điểm môn thứ 2.");
            }
            if (txb_Course3_i.Text == "")
            {
                txb_Course3_i.Focus();
                throw new Exception("Bạn chưa nhập điểm môn thứ 3.");
            }
            bool chkPhone = headphone(txb_Phone_i.Text);
            bool chkID = headid(txb_ID_i.Text);
            bool chkCourse1 = checkPoint(txb_Course1_i.Text), chkCourse2 = checkPoint(txb_Course2_i.Text), chkCourse3 = checkPoint(txb_Course3_i.Text);
            if (chkID == false)
            {
                txb_ID_i.Focus();
                txb_ID_i.SelectAll();
                throw new Exception("ID phải có định dạng 2152****.");
            }
            if (chkPhone == false)
            {
                txb_Phone_i.Focus();
                txb_Phone_i.SelectAll();
                throw new Exception("Bạn nhập sai kiểu số điện thoại, vui lòng nhập lại!");
            }
            if (chkCourse1 == false)
            {
                txb_Course1_i.Focus();
                txb_Course1_i.SelectAll();
                throw new Exception("Số điểm môn 1 không hợp lệ.");
            }
            if (chkCourse2 == false)
            {
                txb_Course2_i.Focus();
                txb_Course2_i.SelectAll();
                throw new Exception("Số điểm môn 2 không hợp lệ.");
            }
            if (chkCourse3 == false)
            {
                txb_Course3_i.Focus();
                txb_Course3_i.SelectAll();
                throw new Exception("Số điểm môn 3 không hợp lệ. Vui lòng nhập lại.");
            }
            if (headphone(txb_Phone_i.Text) == true)
            {
                txb_Phone_i.Text = txb_Phone_i.Text.Replace("+84", "0");
            }
            SinhVien sv = new SinhVien()
            {
                Name = txb_Name_i.Text,
                ID = int.Parse(txb_ID_i.Text),
                Phone = txb_Phone_i.Text,
                Course1 = float.Parse(txb_Course1_i.Text),
                Course2 = float.Parse(txb_Course2_i.Text),
                Course3 = float.Parse(txb_Course3_i.Text),
            };
            MessageBox.Show("Thêm thông tin của sinh viên thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return sv;
        }

        private bool checkPoint(string Point)
        {
            if (float.Parse(Point) >= 0 && float.Parse(Point) <= 10)
                return true;
            else
                return false;
        }

        private bool headid(string id)
        {
            if (id.Length == 8)
            {
                if (id[3] == id[0] && id[0] == '2' && id[1] == '1' && id[2] == '5')
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        private bool headphone(string phone)
        {
            if (phone.Length == 10)
            {
                if (phone[0] == '0')
                    return true;
                else
                    return false;
            }
            return false;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_write_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                string path = ofd.FileName;
                WriteFile(ListSV, path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                rtb.Clear();
            }
        }
        private static void WriteFile(List<SinhVien> DSSV, string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, DSSV);
            fs.Close();
        }

        private void bt_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.ShowDialog();          
            string path1 = ofd1.FileName;
            ListSV = ReadFile(ListSV, path1);
            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.ShowDialog();
            string path2 = ofd2.FileName;
            WriteFile(ListSV, path2);
            ShowInfo();
        }

        private List<SinhVien> ReadFile(List<SinhVien> DSSinhVien, string path)
        {
            //List<SinhVien> DSSinhVien = new List<SinhVien>();
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            //Đọc các byte luồng (thread) và chuyển thành object
            object temp = bf.Deserialize(fs);
            temp = DSSinhVien as List<SinhVien>;
            fs.Close();
            return DSSinhVien;
        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            page++;
            if (page > ListSV.Count - 1)
                page = 0;
            ShowInfo();
        }

        private void ShowInfo()
        {
            List<SinhVien> DSach = SinhVien._DSSinhVien();
            SinhVien sv = DSach[page];
            txb_Name_o.Text = sv.Name;
            txb_ID_o.Text = sv.ID.ToString();
            txb_Phone_o.Text = sv.Phone;
            txb_Course1_o.Text = sv.Course1.ToString();
            txb_Course2_o.Text = sv.Course2.ToString();
            txb_Course3_o.Text = sv.Course3.ToString();
            sv.Avr = (sv.Course1 + sv.Course2 + sv.Course3) / 3;
            txb_aver.Text = Math.Round(sv.Avr, 2).ToString();
            lb_page.Text = (page + 1).ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            page--;
            if (page < 0)
                page = ListSV.Count - 1;
            ShowInfo();
        }
    }
}
