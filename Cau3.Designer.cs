namespace WinFormsApp1
{
    partial class Cau3
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
            richTextBox1 = new RichTextBox();
            btnWrite = new Button();
            btnRead = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(411, 78);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(694, 309);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
          
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnWrite.Location = new Point(66, 272);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(288, 115);
            btnWrite.TabIndex = 4;
            btnWrite.Text = "GHI FILE";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRead.Location = new Point(66, 78);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(288, 115);
            btnRead.TabIndex = 3;
            btnRead.Text = "ĐỌC FILE";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 6;
            label1.Text = "Ver 2.0";
            label1.Click += label1_Click;
            // 
            // Cau3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 464);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Name = "Cau3";
            Text = "Câu 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnWrite;
        private Button btnRead;
        private Label label1;
    }
}