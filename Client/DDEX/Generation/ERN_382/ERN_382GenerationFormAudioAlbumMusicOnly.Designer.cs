namespace DDEX.Generation.ERN_382
{
    partial class ERN_382GenerationFormAudioAlbumMusicOnly
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbUpdateIndicator = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dpMessageCreatedDateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessageRecipient_PartyName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessageRecipient_PartyID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessageSender_PartyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessageSender_PartyID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessageID = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(169, 4);
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbOutput);
            this.panel1.Controls.Add(this.btnLoadXml);
            this.panel1.Location = new System.Drawing.Point(0, 538);
            this.panel1.Size = new System.Drawing.Size(1131, 71);
            this.panel1.Controls.SetChildIndex(this.btnGenerate, 0);
            this.panel1.Controls.SetChildIndex(this.btnLoadXml, 0);
            this.panel1.Controls.SetChildIndex(this.rtbOutput, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Učitana datoteka";
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPath.Location = new System.Drawing.Point(12, 18);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(1107, 28);
            this.lblPath.TabIndex = 0;
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.Location = new System.Drawing.Point(25, 3);
            this.btnLoadXml.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(123, 64);
            this.btnLoadXml.TabIndex = 4;
            this.btnLoadXml.Text = "Load XML";
            this.btnLoadXml.UseVisualStyleBackColor = true;
            this.btnLoadXml.Click += new System.EventHandler(this.btnLoadXml_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1131, 483);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Učitani xml";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbUpdateIndicator);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(593, 281);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "NewReleaseMessage";
            // 
            // cbUpdateIndicator
            // 
            this.cbUpdateIndicator.FormattingEnabled = true;
            this.cbUpdateIndicator.Items.AddRange(new object[] {
            "OriginalMessage",
            "UpdateMessage"});
            this.cbUpdateIndicator.Location = new System.Drawing.Point(257, 15);
            this.cbUpdateIndicator.Name = "cbUpdateIndicator";
            this.cbUpdateIndicator.Size = new System.Drawing.Size(196, 24);
            this.cbUpdateIndicator.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(15, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "UpdateIndicator";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dpMessageCreatedDateTime);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtMessageRecipient_PartyName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtMessageRecipient_PartyID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMessageSender_PartyName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtMessageSender_PartyID);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtMessageID);
            this.groupBox3.Location = new System.Drawing.Point(13, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 157);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message header";
            // 
            // dpMessageCreatedDateTime
            // 
            this.dpMessageCreatedDateTime.CustomFormat = "dd.MM.yyyy HH:mm.ss";
            this.dpMessageCreatedDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpMessageCreatedDateTime.Location = new System.Drawing.Point(244, 128);
            this.dpMessageCreatedDateTime.Name = "dpMessageCreatedDateTime";
            this.dpMessageCreatedDateTime.Size = new System.Drawing.Size(196, 22);
            this.dpMessageCreatedDateTime.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "MessageCreatedDateTime";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "MessageRecipient_PartyName";
            // 
            // txtMessageRecipient_PartyName
            // 
            this.txtMessageRecipient_PartyName.Location = new System.Drawing.Point(244, 106);
            this.txtMessageRecipient_PartyName.Name = "txtMessageRecipient_PartyName";
            this.txtMessageRecipient_PartyName.Size = new System.Drawing.Size(196, 22);
            this.txtMessageRecipient_PartyName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "MessageRecipient_PartyID";
            // 
            // txtMessageRecipient_PartyID
            // 
            this.txtMessageRecipient_PartyID.Location = new System.Drawing.Point(244, 84);
            this.txtMessageRecipient_PartyID.Name = "txtMessageRecipient_PartyID";
            this.txtMessageRecipient_PartyID.Size = new System.Drawing.Size(196, 22);
            this.txtMessageRecipient_PartyID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "MessageSender_PartyName";
            // 
            // txtMessageSender_PartyName
            // 
            this.txtMessageSender_PartyName.Location = new System.Drawing.Point(244, 62);
            this.txtMessageSender_PartyName.Name = "txtMessageSender_PartyName";
            this.txtMessageSender_PartyName.Size = new System.Drawing.Size(196, 22);
            this.txtMessageSender_PartyName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "MessageSender_PartyID";
            // 
            // txtMessageSender_PartyID
            // 
            this.txtMessageSender_PartyID.Location = new System.Drawing.Point(244, 40);
            this.txtMessageSender_PartyID.Name = "txtMessageSender_PartyID";
            this.txtMessageSender_PartyID.Size = new System.Drawing.Size(196, 22);
            this.txtMessageSender_PartyID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message ID";
            // 
            // txtMessageID
            // 
            this.txtMessageID.Location = new System.Drawing.Point(244, 18);
            this.txtMessageID.Name = "txtMessageID";
            this.txtMessageID.Size = new System.Drawing.Size(196, 22);
            this.txtMessageID.TabIndex = 1;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.Location = new System.Drawing.Point(299, 6);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(820, 61);
            this.rtbOutput.TabIndex = 5;
            this.rtbOutput.Text = "";
            // 
            // ERN_382GenerationFormAudioAlbumMusicOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1131, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ERN_382GenerationFormAudioAlbumMusicOnly";
            this.Load += new System.EventHandler(this.ERN_382GenerationFormAudioAlbumMusicOnly_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMessageID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessageSender_PartyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessageSender_PartyID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessageRecipient_PartyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMessageRecipient_PartyID;
        private System.Windows.Forms.DateTimePicker dpMessageCreatedDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbUpdateIndicator;
        private System.Windows.Forms.Label label12;
    }
}
