using Newtonsoft;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DDEX.Navigation
{
    public partial class FilesForm : Framework.UI.Forms.MRStatusForm
    {
        public FilesForm()
        {
            InitializeComponent();
        }
        
        private NavigationModel Model
        {
            get
            {
                return Globals.Model;
            }
        }

        private void FilesForm_Load(object sender, EventArgs e)
        {
            lblPath.Text = Properties.Settings.Default.NavigationFileName;
            Globals.SaveNavigation();
            Globals.LoadNavigation();
            InitBindings();
        }
        private void InitBindings()
        {
            if (Model != null)
            {
                dgvFiles.AutoGenerateColumns = false;
                dgvFiles.DataSource = Model.Files;
                dgvFiles.ClearSelection();
            }
        }

        private void tbTrackReleases_ButtonClicked(object sender, Framework.UI.Controls.MRTitleBar.ActionButtonEventArgs e)
        {
            if (e.Action == Framework.UI.Controls.MRTitleBar.eButtonAction.Add)
            {
                var record = new EditXmlFileModel();


                using (var frm = new FileForm(record))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Model.Files.Add(record);
                        dgvFiles.ClearSelection();
                    }
                }
            }

        }
        private void dgvFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditXmlFileModel record = (EditXmlFileModel)dgvFiles.CurrentRow.DataBoundItem;
            if (record != null)
            {
                using (var frm = new FileForm((EditXmlFileModel)record.Copy()) { Editable = false })
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}
