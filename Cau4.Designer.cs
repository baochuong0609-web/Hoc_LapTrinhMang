namespace WinFormsApp1
{
    partial class Cau4
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
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            btnWrite = new Button();
            btnRead = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(411, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 32);
            label1.TabIndex = 0;
            label1.Text = "Dùng BinaryFormatter";
            label1.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(411, 127);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(694, 309);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnWrite.Location = new Point(66, 321);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(288, 115);
            btnWrite.TabIndex = 8;
            btnWrite.Text = "GHI FILE";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRead.Location = new Point(66, 127);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(288, 115);
            btnRead.TabIndex = 7;
            btnRead.Text = "ĐỌC FILE";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // Cau4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 494);
            Controls.Add(richTextBox1);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Controls.Add(label1);
            Name = "Cau4";
            Text = "Câu 4";
            Load += Cau4_Load;
            Click += Cau4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Button btnWrite;
        private Button btnRead;
    }
}