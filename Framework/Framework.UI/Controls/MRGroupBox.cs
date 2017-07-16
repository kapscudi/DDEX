using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework.UI.Controls
{
    public partial class MRGroupBox : GroupBox
    {
        public MRGroupBox()
        {
            InitializeComponent();
        }

        public MRGroupBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
