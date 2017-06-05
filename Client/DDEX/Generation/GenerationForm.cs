using Business.DDEXFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DDEX.Generation
{
    public partial class GenerationForm : Framework.UI.Forms.MRStatusForm, IXmlGenerationForm
    {
        public GenerationForm()
        {
            InitializeComponent();
        }

        protected IXmlGenerationFactory _Factory = null;
        public IXmlGenerationFactory Factory
        {
            get
            {
                return _Factory;
            }
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

            var obj = GetXmlObject();
            IXmlGenerator gen = Factory.GetGenerator();
            string fileName = @"C:\temp\ddex.xml";
            var str = gen.SerializeNewReleaseMessage(obj);
            System.IO.File.WriteAllText(fileName, str);

            //Helpers.FilesHelper.ExecuteFile(fileName);
            string msg = "";
            bool isValid = gen.IsValid(fileName, out msg);

        }

        public virtual IXmlObject GetXmlObject()
        {
            return null;
        }
        
    }
}
