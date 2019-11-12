using IKK_data;
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
    public partial class ToolEditorDialog : Form, IThemable
    {
        public ToolEditorDialog()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            UpdateTheme();
        }
        public ToolEditorDialog(Tool tool)
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            UpdateTheme();

            toolCard.Tool = tool;
            tbSettings.Text = tool.Settings;
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorBackground;
        }
    }
}
