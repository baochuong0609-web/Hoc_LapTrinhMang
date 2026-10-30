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

namespace WinFormsApp1
{
    public partial class Cau1 : Form
    {
        public Cau1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            fs.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();  
            sfd.ShowDialog();

            FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(fs);

            string content = richTextBox1.Text.ToUpper();

            sw.Write(content);

            sw.Close();
            fs.Close();

            MessageBox.Show("Đã xuất file thành công!");
        }
    }
}
