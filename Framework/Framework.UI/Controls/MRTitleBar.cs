using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework.UI.Controls
{
    public partial class MRTitleBar : UserControl
    {
        public MRTitleBar()
        {
            InitializeComponent();
        }

        private Color titleColor = Color.LightGoldenrodYellow;
        [DefaultValue(typeof(Color), "LightGoldenrodYellow")]
        public Color TitleColor
        {
            get
            {
                return titleColor;
            }
            set
            {
                titleColor = value;
                BindToControl();
            }
        }
            

        private string title = "Title";
        [DefaultValue("Title")]
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                BindToControl();
            }
        }
        private void BindToControl()
        {
            lblTitle.Text = Title;
            pnlTitle.BackColor = titleColor;
            btnCollapse.Visible = expanded;
            btnExpand.Visible = !expanded;
        }

        private bool expanded = true;
        [DefaultValue(true)]
        public bool Expanded
        {
            get
            {
                return expanded;
            }
            set
            {
                expanded = value;
                BindToControl();
            }
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            OnChanged(this, new TitleBarChangedEventArgs() { Expanded = false });
        }
        private void btnExpand_Click(object sender, EventArgs e)
        {            
            OnChanged(this, new TitleBarChangedEventArgs() { Expanded = true });
        }

        public class TitleBarChangedEventArgs : EventArgs
        {
            public bool Expanded { get; set; }
        }

        public delegate void ChangedEventHandler(object sender, TitleBarChangedEventArgs e);
        public event ChangedEventHandler Changed;
        public virtual void OnChanged(object sender, TitleBarChangedEventArgs e)
        {
            Expanded = e.Expanded;
            BindedControls.ForEach(x => x.Visible = e.Expanded);
            Changed?.Invoke(sender, e);
        }
        public List<Control> BindedControls { get; } = new List<Control>();
    }
}

