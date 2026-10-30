namespace Demo_kết_nối_service
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnWrite_Click = new Button();
            btnRead_Click = new Button();
            txtInput = new TextBox();
            listBoxData = new ListBox();
            SuspendLayout();
            // 
            // btnWrite_Click
            // 
            btnWrite_Click.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnWrite_Click.Location = new Point(757, 369);
            btnWrite_Click.Name = "btnWrite_Click";
            btnWrite_Click.Size = new Size(155, 59);
            btnWrite_Click.TabIndex = 0;
            btnWrite_Click.Text = "Gửi đi";
            btnWrite_Click.UseVisualStyleBackColor = true;
            btnWrite_Click.Click += btnWrite_Click_Click;
            // 
            // btnRead_Click
            // 
            btnRead_Click.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnRead_Click.Location = new Point(872, 33);
            btnRead_Click.Name = "btnRead_Click";
            btnRead_Click.Size = new Size(147, 61);
            btnRead_Click.TabIndex = 1;
            btnRead_Click.Text = "Tải dữ liệu ";
            btnRead_Click.UseVisualStyleBackColor = true;
            btnRead_Click.Click += btnRead_Click_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(200, 388);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(537, 27);
            txtInput.TabIndex = 2;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // listBoxData
            // 
            listBoxData.FormattingEnabled = true;
            listBoxData.Location = new Point(180, 33);
            listBoxData.Name = "listBoxData";
            listBoxData.Size = new Size(675, 324);
            listBoxData.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 454);
            Controls.Add(listBoxData);
            Controls.Add(txtInput);
            Controls.Add(btnRead_Click);
            Controls.Add(btnWrite_Click);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWrite_Click;
        private Button btnRead_Click;
        private TextBox txtInput;
        private ListBox listBoxData;
    }
}
