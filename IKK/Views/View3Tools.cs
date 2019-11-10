using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
