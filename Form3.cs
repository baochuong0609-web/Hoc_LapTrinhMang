using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            int charCount, lineCount;
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;

            charCount = content.Length;

            content = content.Replace("\r\n", "\r");
            lineCount = richTextBox1.Lines.Count();
            content = content.Replace("\r", " ");

            string[] source = content.Split(new char[] {'.','?','!',' ',':', ';',','},StringSplitOptions.RemoveEmptyEntries);
           
            int wordCount = source.Count();

            textBox1.Text = ofd.SafeFileName;
            textBox2.Text = fs.Name;

            textBox3.Text = lineCount.ToString();
            textBox4.Text = wordCount.ToString();
            textBox5.Text = charCount.ToString();

            sr.Close();
            fs.Close();
        }
    }
}
