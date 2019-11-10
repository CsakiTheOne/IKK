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
    public partial class ToolDialog : Form, IThemable
    {
        public Tool SelectedTool { get; private set; }

        public ToolDialog()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            UpdateTheme();

            foreach (Tool tool in ToolStorage.Tools)
            {
                treeView.Nodes[tool.Category].Nodes.Add(new TreeNode(tool.Name) { ToolTipText = tool.Description });
            }
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorBackground;
            treeView.BackColor = Theme.ColorBackground;
            treeView.ForeColor = Theme.ColorText;
            treeView.LineColor = Theme.ColorPrimary;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                SelectedTool = ToolStorage.Tools.First(r => r.Name == treeView.SelectedNode.Text);
            }
            catch
            {
                SelectedTool = null;
            }
        }
    }
}
