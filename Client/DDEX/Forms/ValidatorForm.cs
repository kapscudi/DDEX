using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.DDEXFactory;
using Business.DDEXFactory.Interfaces;

namespace DDEX.Forms
{
    public partial class ValidatorForm : Framework.UI.Forms.MRStatusForm
    {
        public ValidatorForm()
        {
            InitializeComponent();
        }

        public object Factory { get; private set; }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtPath.Text))
            {
                IXmlGenerationFactory Factory = new Generation.ERN_382.ERN_382GenerationFactory();
                IXmlGenerator gen = Factory.GetGenerator();
                string msg = "";
                bool isValid = gen.IsValid(txtPath.Text, out msg);
                if (isValid)
                {
                    lblResult.Text = "... VALID ...";
                    lblResult.ForeColor = Color.Green;
                    richTextBox1.Text = "";
                }
                else
                {
                    lblResult.Text = "... INVALID ...";
                    lblResult.ForeColor = Color.Red;
                    richTextBox1.Text = msg;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = dlg.FileName;
                    richTextBox1.Text = "";
                    lblResult.Text = "";
                }
            }
        }
    }
}
