namespace DDEX.Navigation
{
    partial class FilesForm
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
            this.groupBox1 = new Framework.UI.Controls.MRGroupBox(this.components);
            this.lblPath = new Framework.UI.Controls.MRLabel(this.components);
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.tbFiles = new Framework.UI.Controls.MRTitleBar();
            this.csEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.csDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.csTrackTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsValidXml = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(598, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loaded Navigation File";
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPath.Location = new System.Drawing.Point(9, 15);
            this.lblPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(580, 23);
            this.lblPath.TabIndex = 0;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.csEdit,
            this.csDelete,
            this.csTrackTitle,
            this.IsValidXml});
            this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiles.GridColor = System.Drawing.Color.DarkGray;
            this.dgvFiles.Location = new System.Drawing.Point(0, 69);
            this.dgvFiles.MultiSelect = false;
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(598, 312);
            this.dgvFiles.TabIndex = 17;
            this.dgvFiles.TabStop = false;
            this.dgvFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellDoubleClick);
            // 
            // tbFiles
            // 
            this.tbFiles.AddVisible = true;
            this.tbFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFiles.Location = new System.Drawing.Point(0, 45);
            this.tbFiles.Name = "tbFiles";
            this.tbFiles.Size = new System.Drawing.Size(598, 24);
            this.tbFiles.TabIndex = 18;
            this.tbFiles.Title = "Files";
            this.tbFiles.ButtonClicked += new Framework.UI.Controls.MRTitleBar.ButtonClickedEventHandler(this.tbTrackReleases_ButtonClicked);
            // 
            // csEdit
            // 
            this.csEdit.FillWeight = 12.16545F;
            this.csEdit.HeaderText = "";
            this.csEdit.Image = global::DDEX.Properties.Resources.Edit;
            this.csEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.csEdit.MinimumWidth = 20;
            this.csEdit.Name = "csEdit";
            this.csEdit.ReadOnly = true;
            this.csEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.csEdit.ToolTipText = "Edit selected record";
            this.csEdit.Width = 20;
            // 
            // csDelete
            // 
            this.csDelete.FillWeight = 27.22915F;
            this.csDelete.HeaderText = "";
            this.csDelete.Image = global::DDEX.Properties.Resources.Delete;
            this.csDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.csDelete.MinimumWidth = 20;
            this.csDelete.Name = "csDelete";
            this.csDelete.ReadOnly = true;
            this.csDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.csDelete.Width = 20;
            // 
            // csTrackTitle
            // 
            this.csTrackTitle.DataPropertyName = "FileName";
            this.csTrackTitle.FillWeight = 170.5285F;
            this.csTrackTitle.HeaderText = "FileName";
            this.csTrackTitle.Name = "csTrackTitle";
            this.csTrackTitle.ReadOnly = true;
            this.csTrackTitle.Width = 280;
            // 
            // IsValidXml
            // 
            this.IsValidXml.HeaderText = "Is Valid Xml";
            this.IsValidXml.Name = "IsValidXml";
            this.IsValidXml.ReadOnly = true;
            // 
            // FilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(598, 403);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.tbFiles);
            this.Controls.Add(this.groupBox1);
            this.Name = "FilesForm";
            this.Text = "Files Form";
            this.Load += new System.EventHandler(this.FilesForm_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.tbFiles, 0);
            this.Controls.SetChildIndex(this.dgvFiles, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.UI.Controls.MRGroupBox groupBox1;
        private Framework.UI.Controls.MRLabel lblPath;
        private System.Windows.Forms.DataGridView dgvFiles;
        private Framework.UI.Controls.MRTitleBar tbFiles;
        private System.Windows.Forms.DataGridViewImageColumn csEdit;
        private System.Windows.Forms.DataGridViewImageColumn csDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn csTrackTitle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsValidXml;
    }
}
