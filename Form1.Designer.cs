namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rc4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aesEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aesDecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(717, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(887, 142);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 96);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1256, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.rc4ToolStripMenuItem,
            this.aesEncryptionToolStripMenuItem,
            this.aesDecryptionToolStripMenuItem,
            this.salsaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "file ";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.openToolStripMenuItem.Text = "open ";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.saveToolStripMenuItem.Text = "save ";
            // 
            // rc4ToolStripMenuItem
            // 
            this.rc4ToolStripMenuItem.Name = "rc4ToolStripMenuItem";
            this.rc4ToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.rc4ToolStripMenuItem.Text = "rc4 ";
            this.rc4ToolStripMenuItem.Click += new System.EventHandler(this.rc4ToolStripMenuItem_Click);
            // 
            // aesEncryptionToolStripMenuItem
            // 
            this.aesEncryptionToolStripMenuItem.Name = "aesEncryptionToolStripMenuItem";
            this.aesEncryptionToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.aesEncryptionToolStripMenuItem.Text = "aes encryption ";
            this.aesEncryptionToolStripMenuItem.Click += new System.EventHandler(this.aesEncryptionToolStripMenuItem_Click);
            // 
            // aesDecryptionToolStripMenuItem
            // 
            this.aesDecryptionToolStripMenuItem.Name = "aesDecryptionToolStripMenuItem";
            this.aesDecryptionToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.aesDecryptionToolStripMenuItem.Text = "aes decryption ";
            // 
            // salsaToolStripMenuItem
            // 
            this.salsaToolStripMenuItem.Name = "salsaToolStripMenuItem";
            this.salsaToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.salsaToolStripMenuItem.Text = "salsa ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 472);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rc4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aesEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aesDecryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salsaToolStripMenuItem;
    }
}

