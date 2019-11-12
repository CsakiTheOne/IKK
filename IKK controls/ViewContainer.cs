using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKK_controls
{
    public partial class ViewContainer : Panel
    {
        public ViewContainer()
        {
            InitializeComponent();
        }

        public void SetView(View view)
        {
            Controls.Clear();
            view.Dock = DockStyle.Fill;
            Controls.Add(view);
            Theme.ForceUpdate();
        }
    }
}
