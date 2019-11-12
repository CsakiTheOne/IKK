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
        public IKK_data.Tool Tool { get; private set; }

        public event Action<IKK_data.Tool> ToolRemoveClicked;
        public event EventHandler ToolSettingsClicked;

        public ToolCard(IKK_data.Tool tool)
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            UpdateTheme();

            Tool = tool;
            lblName.Text = tool.Name;
            lblDesc.Text = tool.Description;
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorPrimary;

            foreach (IThemable item in Controls)
            {
                item.UpdateTheme();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ToolRemoveClicked?.Invoke(Tool);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // TODO
            Tool.Settings = "";
        }
    }
}
