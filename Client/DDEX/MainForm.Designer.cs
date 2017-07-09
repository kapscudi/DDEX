namespace DDEX
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsBtnXmlVersion = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsBtnXmlVersionERN_382 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1295, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.validatorToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleToolStripMenuItem,
            this.albumToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem.Text = "Ne&w";
            // 
            // singleToolStripMenuItem
            // 
            this.singleToolStripMenuItem.Name = "singleToolStripMenuItem";
            this.singleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.singleToolStripMenuItem.Text = "&Single";
            this.singleToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.albumToolStripMenuItem.Text = "&Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // validatorToolStripMenuItem
            // 
            this.validatorToolStripMenuItem.Name = "validatorToolStripMenuItem";
            this.validatorToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.validatorToolStripMenuItem.Text = "&Validator";
            this.validatorToolStripMenuItem.Click += new System.EventHandler(this.validatorToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnXmlVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 730);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1295, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsBtnXmlVersion
            // 
            this.tsBtnXmlVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnXmlVersion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnXmlVersionERN_382});
            this.tsBtnXmlVersion.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnXmlVersion.Image")));
            this.tsBtnXmlVersion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnXmlVersion.Name = "tsBtnXmlVersion";
            this.tsBtnXmlVersion.Size = new System.Drawing.Size(163, 24);
            this.tsBtnXmlVersion.Text = "Xml Version ERN_382";
            // 
            // tsBtnXmlVersionERN_382
            // 
            this.tsBtnXmlVersionERN_382.Name = "tsBtnXmlVersionERN_382";
            this.tsBtnXmlVersionERN_382.Size = new System.Drawing.Size(142, 26);
            this.tsBtnXmlVersionERN_382.Text = "ERN_382";
            this.tsBtnXmlVersionERN_382.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1295, 756);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsBtnXmlVersion;
        private System.Windows.Forms.ToolStripMenuItem tsBtnXmlVersionERN_382;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validatorToolStripMenuItem;
    }
}
