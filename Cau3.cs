using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Cau3 : Form
    {
        public Cau3()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            fs.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;

            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            foreach (string line in richTextBox1.Lines)
            {
                string templine = line.Trim();

                if (templine == "") continue;

                double kq = 0;
                char pheptinh = ' ';

                if (templine.Contains('+')) pheptinh = '+';
                else if (templine.Contains("-")) pheptinh = '-';
                else if (templine.Contains("/")) pheptinh = '/';
                else if (templine.Contains("*")) pheptinh = '*';

                if (pheptinh != ' ')
                {
                    string[] haiso = templine.Split(pheptinh);

                    if (haiso.Length == 2)
                    {
                        double so1 = double.Parse(haiso[0].Trim());
                        double so2 = double.Parse(haiso[1].Trim());

                        if (pheptinh == '+') kq = so1 + so2;
                        else if (pheptinh == '-') kq = so1 - so2;
                        else if (pheptinh == '/') kq = so1 / so2;
                        else if (pheptinh == '*') kq = so1 * so2;

                        sw.WriteLine(templine + "=" + kq);
                    }
                }
            }
            sw.Close();
            fs.Close();
            MessageBox.Show("Kết quả đã được trả về!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}