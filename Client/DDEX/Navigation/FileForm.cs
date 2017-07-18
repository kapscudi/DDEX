using Framework.UI.Forms;
using Business.DDEXSchemaERN_382.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DDEX.Navigation;

namespace DDEX.Navigation
{
    public partial class FileForm : MREditForm
    {
        public FileForm()
        {
            InitializeComponent();
            tbTrackRelease.BindedControls.Add(pnlMainRelease);
        }
        public FileForm(EditXmlFileModel model) : this()
        {
            Model = model;
        }

        public EditXmlFileModel Model { get; set; }
        
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            InitBindings();
        }

        private void InitBindings()
        {
            txtOrdinal.DataBindings.Add("Text", Model, "FileName");
            chxbIsValid.DataBindings.Add("Checked", Model, "IsValidXml");            
        }

        private void Form_DialogResultClicked(object sender, DialogResultEventArgs e)
        {
            if (e.Result == DialogResult.OK)
            {
                string message = "";
                if (Model.IsValid(out message))
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MRMessageBox.Show(string.Format("Data not valid.\n{0}", message), MRMessageBox.eMessageBoxStyle.OK, MRMessageBox.eMessageBoxType.Error);
                }
            }
            else if (e.Result == DialogResult.Cancel)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
