using Business.DDEXFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DDEX
{
    public partial class MainForm : Framework.UI.Forms.MRMDIParent
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Properties

        public IXmlGenerationFactory Factory { get; set; } = new Generation.ERN_382.ERN_382GenerationFactory();

        #endregion

        #region Menus And Item Clicks

        private void menuItem_Click(object sender, EventArgs e)
        {
            if (sender == singleToolStripMenuItem)
            {
                var frm = (Form)Factory.GetGenerationFormAudioSingle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsBtnXmlVersion.Text = "Xml Version " + ((ToolStripMenuItem)sender).Text;
            if (sender == tsBtnXmlVersionERN_382)
            {
                Factory = new Generation.ERN_382.ERN_382GenerationFactory();
            }
        }


        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                using (var frm = new Generation.ERN_382.ERN_382GenerationFormAudioSingle())
                {
                    IXmlObject obj = frm.GetXmlObject();
                    IXmlGenerator gen = Factory.GetGenerator();
                    string fileName = @"C:\temp\ddex.xml";



                    string value = System.IO.File.ReadAllText(@"D:\BitBucket\DDEX\Resources\Business Profiles Samples\LiveCycle_InitialWorldwideDeal.xml");
                    //string value = System.IO.File.ReadAllText(@"D:\BitBucket\DDEX\Resources\Release Profiles Samples\Profile_AudioSingle.xml");
                    var obj2 = gen.DeserializeNewReleaseMessage(value);
                    var str = gen.SerializeNewReleaseMessage(obj2);
                    System.IO.File.WriteAllText(fileName, str);

                    string msg = "";
                    //fileName = @"D:\BitBucket\DDEX\Resources\Release Profiles Samples\Profile_AudioSingle.xml";
                    bool isValid = gen.IsValid(fileName, out msg);
                }
            }
        }

        private void validatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Forms.ValidatorForm();
            frm.MdiParent = this;
            frm.Show();
        }

    }
}
    /*
 TODO:
    - prebaciti sve na web
    - napraviti deserijalizaciju audiosingle primjera pa pogledati nejasnoce
    - iz generation forme maknuti izradu fajla - forme su samo za dobivanje objekata
    - proci dva tipa xml i sve sto se ponavlja enkapsulirati u kontrole ili forme
    - soundRecording - mozda voditi u posebnom sifrarniku
    - servisom razgovariti s bazom


     */