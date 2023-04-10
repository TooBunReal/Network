
namespace Lab2
{
    partial class Bai_6
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.tw1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Location = new System.Drawing.Point(464, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(495, 534);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Nội dung";
            this.gb1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tw1
            // 
            this.tw1.Location = new System.Drawing.Point(12, 13);
            this.tw1.Name = "tw1";
            this.tw1.Size = new System.Drawing.Size(445, 533);
            this.tw1.TabIndex = 1;
            this.tw1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Bai_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 558);
            this.Controls.Add(this.tw1);
            this.Controls.Add(this.gb1);
            this.Name = "Bai_6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai_6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TreeView tw1;
    }
}