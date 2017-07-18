namespace DDEX.Navigation
{
    partial class FileForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlMainReleaseParent = new Framework.UI.Controls.MRPanel(this.components);
            this.pnlMainRelease = new Framework.UI.Controls.MRPanel(this.components);
            this.label2 = new Framework.UI.Controls.MRLabel(this.components);
            this.label1 = new Framework.UI.Controls.MRLabel(this.components);
            this.txtOrdinal = new Framework.UI.Controls.MRTextBox(this.components);
            this.tbTrackRelease = new Framework.UI.Controls.MRTitleBar();
            this.chxbIsValid = new Framework.UI.Controls.MRCheckBox(this.components);
            this.pnlData.SuspendLayout();
            this.pnlMainReleaseParent.SuspendLayout();
            this.pnlMainRelease.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.pnlMainReleaseParent);
            this.pnlData.Size = new System.Drawing.Size(338, 174);
            // 
            // pnlMainReleaseParent
            // 
            this.pnlMainReleaseParent.AutoSize = true;
            this.pnlMainReleaseParent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainReleaseParent.Controls.Add(this.pnlMainRelease);
            this.pnlMainReleaseParent.Controls.Add(this.tbTrackRelease);
            this.pnlMainReleaseParent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainReleaseParent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainReleaseParent.Name = "pnlMainReleaseParent";
            this.pnlMainReleaseParent.Size = new System.Drawing.Size(338, 70);
            this.pnlMainReleaseParent.TabIndex = 16;
            // 
            // pnlMainRelease
            // 
            this.pnlMainRelease.AutoSize = true;
            this.pnlMainRelease.Controls.Add(this.chxbIsValid);
            this.pnlMainRelease.Controls.Add(this.label2);
            this.pnlMainRelease.Controls.Add(this.label1);
            this.pnlMainRelease.Controls.Add(this.txtOrdinal);
            this.pnlMainRelease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainRelease.Location = new System.Drawing.Point(0, 24);
            this.pnlMainRelease.Name = "pnlMainRelease";
            this.pnlMainRelease.Size = new System.Drawing.Size(338, 46);
            this.pnlMainRelease.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(2, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Is Valid Xml";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "FileName";
            // 
            // txtOrdinal
            // 
            this.txtOrdinal.Location = new System.Drawing.Point(171, 1);
            this.txtOrdinal.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrdinal.Name = "txtOrdinal";
            this.txtOrdinal.Size = new System.Drawing.Size(148, 20);
            this.txtOrdinal.TabIndex = 10;
            // 
            // tbTrackRelease
            // 
            this.tbTrackRelease.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrackRelease.Location = new System.Drawing.Point(0, 0);
            this.tbTrackRelease.Name = "tbTrackRelease";
            this.tbTrackRelease.Size = new System.Drawing.Size(338, 24);
            this.tbTrackRelease.TabIndex = 12;
            this.tbTrackRelease.Title = "XML Metadata File";
            // 
            // chxbIsValid
            // 
            this.chxbIsValid.AutoSize = true;
            this.chxbIsValid.Location = new System.Drawing.Point(171, 26);
            this.chxbIsValid.Name = "chxbIsValid";
            this.chxbIsValid.Size = new System.Drawing.Size(80, 17);
            this.chxbIsValid.TabIndex = 14;
            this.chxbIsValid.Text = "Is Valid Xml";
            this.chxbIsValid.UseVisualStyleBackColor = true;
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(338, 220);
            this.Name = "FileForm";
            this.Text = "Track Release Edit";
            this.DialogResultClicked += new Framework.UI.Forms.MREditForm.ButtonClickEventHandler(this.Form_DialogResultClicked);
            this.Load += new System.EventHandler(this.Form_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlMainReleaseParent.ResumeLayout(false);
            this.pnlMainReleaseParent.PerformLayout();
            this.pnlMainRelease.ResumeLayout(false);
            this.pnlMainRelease.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.UI.Controls.MRPanel pnlMainReleaseParent;
        private Framework.UI.Controls.MRPanel pnlMainRelease;
        private Framework.UI.Controls.MRLabel label2;
        private Framework.UI.Controls.MRLabel label1;
        private Framework.UI.Controls.MRTextBox txtOrdinal;
        private Framework.UI.Controls.MRTitleBar tbTrackRelease;
        private Framework.UI.Controls.MRCheckBox chxbIsValid;
    }
}
