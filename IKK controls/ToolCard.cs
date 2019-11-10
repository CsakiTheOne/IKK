using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKK_controls
{
    public partial class ToolCard : UserControl, IThemable
    {
        public event EventHandler ToolRemoveClicked;
        public event EventHandler ToolSettingsClicked;

        public ToolCard()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
        }
        public ToolCard(IKK_data.Tool tool)
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            lblName.Text = tool.Name;
            lblDesc.Text = tool.Description;
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorPrimary;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ToolRemoveClicked(this, e);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ToolSettingsClicked(this, e);
        }
    }
}
