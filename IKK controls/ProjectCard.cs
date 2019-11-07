using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Drawing.Design;

namespace IKK_controls
{
    public partial class ProjectCard : UserControl, IThemable
    {
        public string PTitle { get => lblTitle.Text; set => lblTitle.Text = value; }
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string PDescription { get => lblDesc.Text; set => lblDesc.Text = value; }
        public string PLabel { get => lblLabel.Text; set => lblLabel.Text = value; }

        public ProjectCard()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorBackground;
            ForeColor = Theme.ColorText;
        }
    }
}
