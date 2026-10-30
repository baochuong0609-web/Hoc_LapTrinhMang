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
    public partial class Cau5 : Form
    {
        public Cau5()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReadFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description="Chọn Folder cần duyệt!";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                listView1.Items.Clear();

                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                FileInfo[] fiArr = di.GetFiles();

                foreach (FileInfo fi in fiArr)
                {
                    ListViewItem item = new ListViewItem(fi.Name);

                    item.SubItems.Add(fi.Length.ToString());
                    item.SubItems.Add(fi.Extension);
                    item.SubItems.Add(fi.CreationTime.ToString());

                    listView1.Items.Add(item);
                }
            }
        }
    }
}
