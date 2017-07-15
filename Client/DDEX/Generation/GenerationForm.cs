using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DDEX.Generation
{
    public partial class GenerationForm : Framework.UI.Forms.MRStatusForm
    {
        public GenerationForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            OnGenerateClicked(sender, e);
        }

        public delegate void ButtonClickEventHandler(object sender, EventArgs e);
        public event ButtonClickEventHandler GenerateClicked;
        protected virtual void OnGenerateClicked(object sender, EventArgs e)
        {
            Framework.UI.Helpers.CrossThreadingHelpers.InvokeControl((Control)sender, null, (x) =>
            {
                GenerateClicked?.Invoke(sender, e);
            });
        }
    }
}
