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
        public Tool Tool { get; private set; }

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
            Tool = tool;
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorBackground;
            foreach (IThemable item in Controls)
            {
                item.UpdateTheme();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Tool.Settings = tbSettings.Text;
        }
    }
}
