namespace Lab2
{
    partial class Bai_1
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
            this.bt_doc = new System.Windows.Forms.Button();
            this.bt_ghi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_doc
            // 
            this.bt_doc.Location = new System.Drawing.Point(50, 101);
            this.bt_doc.Name = "bt_doc";
            this.bt_doc.Size = new System.Drawing.Size(156, 77);
            this.bt_doc.TabIndex = 0;
            this.bt_doc.Text = "Đọc File";
            this.bt_doc.UseVisualStyleBackColor = true;
            this.bt_doc.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_ghi
            // 
            this.bt_ghi.Location = new System.Drawing.Point(50, 225);
            this.bt_ghi.Name = "bt_ghi";
            this.bt_ghi.Size = new System.Drawing.Size(156, 77);
            this.bt_ghi.TabIndex = 1;
            this.bt_ghi.Text = "Ghi File";
            this.bt_ghi.UseVisualStyleBackColor = true;
            this.bt_ghi.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(267, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(521, 482);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(50, 358);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(156, 77);
            this.bt_clear.TabIndex = 3;
            this.bt_clear.Text = "Làm Mới";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_dong
            // 
            this.bt_dong.Location = new System.Drawing.Point(50, 482);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(156, 77);
            this.bt_dong.TabIndex = 4;
            this.bt_dong.Text = "Đóng";
            this.bt_dong.UseVisualStyleBackColor = true;
            this.bt_dong.Click += new System.EventHandler(this.button4_Click);
            // 
            // Bai_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.bt_dong);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bt_ghi);
            this.Controls.Add(this.bt_doc);
            this.Name = "Bai_1";
            this.Text = "Bai_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_doc;
        private System.Windows.Forms.Button bt_ghi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_dong;
    }
}