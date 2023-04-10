namespace Lab2
{
    partial class Bai_3
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
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_cal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_doc
            // 
            this.bt_doc.Location = new System.Drawing.Point(9, 276);
            this.bt_doc.Name = "bt_doc";
            this.bt_doc.Size = new System.Drawing.Size(103, 52);
            this.bt_doc.TabIndex = 6;
            this.bt_doc.Text = "Đọc File";
            this.bt_doc.UseVisualStyleBackColor = true;
            this.bt_doc.Click += new System.EventHandler(this.bt_doc_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(462, 276);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(103, 52);
            this.bt_exit.TabIndex = 7;
            this.bt_exit.Text = "Đóng";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(310, 276);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(103, 52);
            this.bt_del.TabIndex = 10;
            this.bt_del.Text = "Xóa";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(556, 258);
            this.textBox1.TabIndex = 11;
            // 
            // bt_cal
            // 
            this.bt_cal.Location = new System.Drawing.Point(153, 276);
            this.bt_cal.Name = "bt_cal";
            this.bt_cal.Size = new System.Drawing.Size(103, 52);
            this.bt_cal.TabIndex = 13;
            this.bt_cal.Text = "Tính";
            this.bt_cal.UseVisualStyleBackColor = true;
            this.bt_cal.Click += new System.EventHandler(this.bt_cal_Click);
            // 
            // Bai_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 350);
            this.Controls.Add(this.bt_cal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_doc);
            this.Name = "Bai_3";
            this.Text = "Bai_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_doc;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_cal;
    }
}