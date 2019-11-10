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
        public IKK_data.Tool SelectedTool { get; private set; }

        public ToolDialog()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
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
            if (!treeView.SelectedNode.Name.Contains("tool")) return;

            // SelectedTool = ;
        }
    }
}
