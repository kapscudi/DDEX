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
    public partial class MRButtonBar : UserControl
    {
        public MRButtonBar()
        {
            InitializeComponent();

            Buttons.Add(btnAdd);
            Buttons.Add(btnEdit);
            Buttons.Add(btnDelete);
        }

        private void BindToControl()
        {
            DockStyle dock = DockStyle.Top;
            Size minSize = new Size(31, 99);
            if (Horizontal)
            {
                dock = DockStyle.Left;
                minSize = new Size(102, 28);
            }
            Buttons.ForEach(x => x.Dock = dock);
            panel1.MinimumSize = minSize;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            OnChanged(this, new ButtonBarChangedEventArgs() { });
        }
        private void btnExpand_Click(object sender, EventArgs e)
        {
            OnChanged(this, new ButtonBarChangedEventArgs() { });
        }

        public enum eButtonType
        {
            Add,
            Delete,
            Edit
        }
        public class ButtonBarChangedEventArgs : EventArgs
        {
            public eButtonType ButtonType;
        }

        public delegate void ChangedEventHandler(object sender, ButtonBarChangedEventArgs e);
        public event ChangedEventHandler Changed;
        public virtual void OnChanged(object sender, ButtonBarChangedEventArgs e)
        {

            //BindedControls.ForEach(x => x.Visible = e.Expanded);
            Changed?.Invoke(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnChanged(this, new ButtonBarChangedEventArgs() { ButtonType = eButtonType.Delete });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnChanged(this, new ButtonBarChangedEventArgs() { ButtonType = eButtonType.Add });
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnChanged(this, new ButtonBarChangedEventArgs() { ButtonType = eButtonType.Edit });
        }

        private bool horizontal = false;
        [DefaultValue(false)]
        public bool Horizontal
        {
            get
            {
                return horizontal;
            }
            set
            {
                horizontal = value;
                BindToControl();
            }
        }

        private List<Button> Buttons { get; } = new List<Button>();
    }
    
}