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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
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
            richTextBox1.Location = new Point(98, 151);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(855, 318);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnWrite.Location = new Point(959, 426);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(146, 43);
            btnWrite.TabIndex = 8;
            btnWrite.Text = "GHI FILE";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRead.Location = new Point(914, 70);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(165, 46);
            btnRead.TabIndex = 7;
            btnRead.Text = "THÊM";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnThem_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(295, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(445, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(596, 70);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(745, 70);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 14;
            // 
            // Cau4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 494);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}