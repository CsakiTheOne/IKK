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
    public partial class Lbl : Label, IThemable
    {
        public Lbl()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
        }

        public void UpdateTheme()
        {
            if (Parent != null) BackColor = Parent.BackColor;
            ForeColor = Theme.ColorText;
        }
    }
}
