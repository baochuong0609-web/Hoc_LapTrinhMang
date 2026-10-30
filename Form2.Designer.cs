namespace WinFormsApp1
{
    partial class Cau1
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
            btnRead = new Button();
            btnWrite = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRead.Location = new Point(57, 82);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(288, 115);
            btnRead.TabIndex = 0;
            btnRead.Text = "ĐỌC FILE";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnWrite.Location = new Point(57, 276);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(288, 115);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "GHI FILE";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(402, 82);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(694, 309);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Cau1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 483);
            Controls.Add(richTextBox1);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Name = "Cau1";
            Text = "Câu 1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private Button btnWrite;
        private RichTextBox richTextBox1;
    }
}