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

            foreach (IKK_data.Tool tool in Storage.CurrentProject.Tools)
            {
                flp.Controls.Add(new IKK_controls.ToolCard());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IKK_data.Tool tool = MsgBox.ShowToolDialog();
            if (tool == null) return;
            MsgBox.Show("Eszköz választó debug", tool.Name + "\n\r" + tool.Description);
        }
    }
}
