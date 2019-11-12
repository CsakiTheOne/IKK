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
        public IKK_data.Tool Tool { get => tool; set { tool = value; RefreshTool(); } }
        public event Action<IKK_data.Tool> ToolRemoveClicked;

        IKK_data.Tool tool;

        public ToolCard()
        {
            InitializeComponent();
            btnRemove.Visible = false;
            btnSettings.Visible = false;
        }
        public ToolCard(IKK_data.Tool tool)
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            UpdateTheme();

            Tool = tool;
            RefreshTool();
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorPrimary;

            foreach (IThemable item in Controls)
            {
                item.UpdateTheme();
            }
        }

        void RefreshTool()
        {
            lblName.Text = Tool.Name;
            lblDesc.Text = Tool.Description;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ToolRemoveClicked?.Invoke(Tool);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Tool.Settings = MsgBox.ShowToolEditorDialog(Tool).Settings;
        }
    }
}
