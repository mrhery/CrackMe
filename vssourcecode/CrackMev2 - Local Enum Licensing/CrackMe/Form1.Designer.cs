namespace CrackMe
{
    partial class Home
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
            this.start = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertLicenseKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCrackMev1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(21, 50);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(178, 34);
            this.start.TabIndex = 0;
            this.start.Text = "Start Program Now";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseToolStripMenuItem,
            this.aboutCrackMev1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(231, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertLicenseKeyToolStripMenuItem});
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.licenseToolStripMenuItem.Text = "License";
            // 
            // insertLicenseKeyToolStripMenuItem
            // 
            this.insertLicenseKeyToolStripMenuItem.Name = "insertLicenseKeyToolStripMenuItem";
            this.insertLicenseKeyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.insertLicenseKeyToolStripMenuItem.Text = "Insert License Key";
            this.insertLicenseKeyToolStripMenuItem.Click += new System.EventHandler(this.insertLicenseKeyToolStripMenuItem_Click);
            // 
            // aboutCrackMev1ToolStripMenuItem
            // 
            this.aboutCrackMev1ToolStripMenuItem.Name = "aboutCrackMev1ToolStripMenuItem";
            this.aboutCrackMev1ToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.aboutCrackMev1ToolStripMenuItem.Text = "About this CrackMe";
            this.aboutCrackMev1ToolStripMenuItem.Click += new System.EventHandler(this.aboutCrackMev1ToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 109);
            this.Controls.Add(this.start);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrackMe version 2";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertLicenseKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCrackMev1ToolStripMenuItem;
    }
}

