namespace WinFormsApp1
{
    partial class Cau5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ColumnHeader columnHeader1;
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnReadFolder = new Button();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(3, 69);
            listView1.Name = "listView1";
            listView1.Size = new Size(1227, 422);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên File";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kích Thước";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đuôi Mở Rộng";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ngày Tạo";
            columnHeader4.Width = 300;
            // 
            // btnReadFolder
            // 
            btnReadFolder.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnReadFolder.Location = new Point(912, 12);
            btnReadFolder.Name = "btnReadFolder";
            btnReadFolder.Size = new Size(293, 51);
            btnReadFolder.TabIndex = 1;
            btnReadFolder.Text = "Chọn Folder cần đọc";
            btnReadFolder.UseVisualStyleBackColor = true;
            btnReadFolder.Click += btnReadFolder_Click;
            // 
            // Cau5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 493);
            Controls.Add(btnReadFolder);
            Controls.Add(listView1);
            Name = "Cau5";
            Text = "Câu 5 - File Explorer";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnReadFolder;
    }
}