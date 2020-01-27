using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKK_controls;
using IKK_storage;
using IKK_data;

namespace IKK
{
    public partial class View3Tools : IKK_controls.View
    {
        public View3Tools()
        {
            InitializeComponent();
            RefreshTools();
        }

        void RefreshTools()
        {
            flp.Controls.Clear();

            if (Storage.CurrentProject.Tools == null) return;

            ToolCard tc;

            foreach (Tool tool in Storage.CurrentProject.Tools)
            {
                tc = new ToolCard(tool);
                tc.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                tc.ToolRemoveClicked += Tc_ToolRemoveClicked;
                flp.Controls.Add(tc);
            }

            Refresh();
        }

        private void Tc_ToolRemoveClicked(IKK_data.Tool tool)
        {
            Storage.CurrentProject.Tools.Remove(tool);
            RefreshTools();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tool tool = MsgBox.ShowToolDialog();
            if (tool == null) return;

            if (Storage.CurrentProject.Tools == null || Storage.CurrentProject.Tools.Count(r => r.Name == tool.Name) < 1)
            {
                Storage.CurrentProject.Tools.Add(tool);
                tool.OnLoad(Storage.CurrentProject.Content);
                RefreshTools();
            }
            else
            {
                MsgBox.Show("Eszközök", "Ez az eszköz már szerepel a projektben!");
            }
        }

        private void View3Tools_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control item in flp.Controls)
            {
                item.Width = flp.Width;
            }
        }
    }
}
