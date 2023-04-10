namespace Lab2
{
    partial class Bai_5
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
            this.bt_zip = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_extr = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // bt_zip
            // 
            this.bt_zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_zip.Location = new System.Drawing.Point(12, 12);
            this.bt_zip.Name = "bt_zip";
            this.bt_zip.Size = new System.Drawing.Size(153, 81);
            this.bt_zip.TabIndex = 0;
            this.bt_zip.Text = "Nén";
            this.bt_zip.UseVisualStyleBackColor = true;
            this.bt_zip.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_exit.Location = new System.Drawing.Point(384, 12);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(153, 81);
            this.bt_exit.TabIndex = 1;
            this.bt_exit.Text = "Thoát";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_extr
            // 
            this.bt_extr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_extr.Location = new System.Drawing.Point(199, 12);
            this.bt_extr.Name = "bt_extr";
            this.bt_extr.Size = new System.Drawing.Size(153, 81);
            this.bt_extr.TabIndex = 2;
            this.bt_extr.Text = "Giải Nén";
            this.bt_extr.UseVisualStyleBackColor = true;
            this.bt_extr.Click += new System.EventHandler(this.bt_extr_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bai_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 110);
            this.Controls.Add(this.bt_extr);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_zip);
            this.Name = "Bai_5";
            this.Text = "Bai_5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_zip;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_extr;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}