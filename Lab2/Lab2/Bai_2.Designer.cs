namespace Lab2
{
    partial class Bai_2
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bt_doc = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_url = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_size = new System.Windows.Forms.TextBox();
            this.txb_line = new System.Windows.Forms.TextBox();
            this.txb_words = new System.Windows.Forms.TextBox();
            this.txb_char = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(474, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(521, 527);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // bt_doc
            // 
            this.bt_doc.Location = new System.Drawing.Point(12, 12);
            this.bt_doc.Name = "bt_doc";
            this.bt_doc.Size = new System.Drawing.Size(456, 59);
            this.bt_doc.TabIndex = 4;
            this.bt_doc.Text = "Đọc File";
            this.bt_doc.UseVisualStyleBackColor = true;
            this.bt_doc.Click += new System.EventHandler(this.bt_doc_Click);
            // 
            // bt_dong
            // 
            this.bt_dong.Location = new System.Drawing.Point(12, 487);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(456, 52);
            this.bt_dong.TabIndex = 5;
            this.bt_dong.Text = "Đóng";
            this.bt_dong.UseVisualStyleBackColor = true;
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(3, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(3, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Line";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(3, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Words";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(3, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Char";
            // 
            // txb_url
            // 
            this.txb_url.Location = new System.Drawing.Point(71, 237);
            this.txb_url.Name = "txb_url";
            this.txb_url.ReadOnly = true;
            this.txb_url.Size = new System.Drawing.Size(397, 22);
            this.txb_url.TabIndex = 12;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(71, 113);
            this.txb_name.Name = "txb_name";
            this.txb_name.ReadOnly = true;
            this.txb_name.Size = new System.Drawing.Size(397, 22);
            this.txb_name.TabIndex = 13;
            // 
            // txb_size
            // 
            this.txb_size.Location = new System.Drawing.Point(71, 174);
            this.txb_size.Name = "txb_size";
            this.txb_size.ReadOnly = true;
            this.txb_size.Size = new System.Drawing.Size(397, 22);
            this.txb_size.TabIndex = 14;
            // 
            // txb_line
            // 
            this.txb_line.Location = new System.Drawing.Point(71, 305);
            this.txb_line.Name = "txb_line";
            this.txb_line.ReadOnly = true;
            this.txb_line.Size = new System.Drawing.Size(397, 22);
            this.txb_line.TabIndex = 15;
            // 
            // txb_words
            // 
            this.txb_words.Location = new System.Drawing.Point(71, 365);
            this.txb_words.Name = "txb_words";
            this.txb_words.ReadOnly = true;
            this.txb_words.Size = new System.Drawing.Size(397, 22);
            this.txb_words.TabIndex = 16;
            // 
            // txb_char
            // 
            this.txb_char.Location = new System.Drawing.Point(71, 426);
            this.txb_char.Name = "txb_char";
            this.txb_char.ReadOnly = true;
            this.txb_char.Size = new System.Drawing.Size(397, 22);
            this.txb_char.TabIndex = 17;
            // 
            // Bai_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 551);
            this.Controls.Add(this.txb_char);
            this.Controls.Add(this.txb_words);
            this.Controls.Add(this.txb_line);
            this.Controls.Add(this.txb_size);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.txb_url);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_dong);
            this.Controls.Add(this.bt_doc);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Bai_2";
            this.Text = "Url";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bt_doc;
        private System.Windows.Forms.Button bt_dong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_url;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_size;
        private System.Windows.Forms.TextBox txb_line;
        private System.Windows.Forms.TextBox txb_words;
        private System.Windows.Forms.TextBox txb_char;
    }
}