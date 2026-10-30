using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO; 

namespace WinFormsApp1
{
    public partial class Cau4 : Form
    {
        [Serializable]
        public class HocVien
        {
            public string MSSV;
            public string HoTen;
            public string Dienthoai;
            public float Diemtoan;
            public float Diemvan;
            public float DTB;
        }

       
        List<HocVien> danhsachHV = new List<HocVien>();
        bool vuaMoiGhiFile = false;

        public Cau4()
        {
            InitializeComponent();
        }

        private void Cau4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (vuaMoiGhiFile == true)
                {
                    richTextBox1.Clear();    
                    vuaMoiGhiFile = false;   
                }

                HocVien hv = new HocVien();
                hv.MSSV = textBox1.Text;
                hv.HoTen = textBox2.Text;
                hv.Dienthoai = textBox3.Text;
                hv.Diemtoan = float.Parse(textBox4.Text);
                hv.Diemvan = float.Parse(textBox5.Text);


                danhsachHV.Add(hv);


                FileStream fsIn = new FileStream("resinput.txt", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fsIn, danhsachHV);
                fsIn.Close();


                richTextBox1.Text += "Đã thêm thành công MSSV: " + hv.MSSV + "\r\n";

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và nhập số hợp lệ cho điểm!");
            }
        }


        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fsIn = new FileStream("resinput.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();

                List<HocVien> dsHocVien = (List<HocVien>)bf.Deserialize(fsIn);
                fsIn.Close();

                string hienthi = "";
                foreach (HocVien hv in dsHocVien)
                {
                    hv.DTB = (hv.Diemtoan + hv.Diemvan) / 2.0f;

                    hienthi += hv.MSSV + "\r\n"
                    + hv.HoTen + "\r\n"
                    + hv.Dienthoai + "\r\n"
                    + hv.Diemtoan + "\r\n"
                    + hv.Diemvan + "\r\n"
                    + hv.DTB + "\r\n\r\n";
                }
                richTextBox1.Text = hienthi;
                vuaMoiGhiFile = true;

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Chọn vị trí lưu file Output";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fsOut = new FileStream(sfd.FileName, FileMode.Create);
                    bf.Serialize(fsOut, dsHocVien);
                    fsOut.Close();

                    MessageBox.Show("Đã xuất file output!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có dữ liệu để ghi, hãy THÊM sinh viên trước!");
            }
        }

    }
}