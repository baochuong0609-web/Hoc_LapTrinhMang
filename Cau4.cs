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
using System.Text.Json.Serialization;
using System.Drawing.Text;
using System.Linq.Expressions;
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

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn file text chứa danh sách để đọc";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                if (fs.Length == 0)
                {
                    MessageBox.Show("File không có nội dung");
                    fs.Close();
                    return;
                }

                List<HocVien> dshv = new List<HocVien>();
                string mssv;

                while ((mssv = sr.ReadLine()) != null)
                {
                    if (mssv.Trim() == "") continue;

                    HocVien hv = new HocVien();
                    hv.MSSV = mssv;
                    hv.HoTen = sr.ReadLine();
                    hv.Dienthoai = sr.ReadLine();
                    hv.Diemtoan = float.Parse(sr.ReadLine().Trim());
                    hv.Diemvan = float.Parse(sr.ReadLine().Trim());

                    dshv.Add(hv);
                }
                sr.Close();
                fs.Close();

                FileStream fsIn = new FileStream("resinput.txt", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                
                bf.Serialize(fsIn, dshv);
                fsIn.Close();
                MessageBox.Show("Đã nén mảng học viên vào resinput.txt");
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

                    hienthi += hv.MSSV +"\r\n"
                    + hv.HoTen + "\r\n"
                    + hv.Dienthoai + "\r\n"
                    + hv.Diemtoan + "\r\n"
                    + hv.Diemvan + "\r\n"
                    + hv.DTB + "\r\n\r\n";
                }
                    richTextBox1.Text = hienthi;

                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "Chọn vị trí lưu file Output";

                    if(sfd.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fsOut = new FileStream(sfd.FileName, FileMode.Create);
                        bf.Serialize(fsOut, dsHocVien);
                        fsOut.Close();

                        MessageBox.Show("Đã xuất file output!");
                    }
                }
                catch (Exception)
            {
                MessageBox.Show("Chưa có file input để ghi!");
            }
            }
            
        }
    }

