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
    public partial class Btn : Button, IThemable
    {
        public Btn()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
        }

        public bool Raised { get => raised; set { raised = value; UpdateTheme(); } }

        bool raised;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void UpdateTheme()
        {
            if (raised)
            {
                BackColor = Theme.ColorAccent;
                ForeColor = Theme.ColorText;
            }
            else
            {
                if (Parent != null) BackColor = Parent.BackColor;
                ForeColor = Theme.ColorAccent;
            }
        }
    }
}
