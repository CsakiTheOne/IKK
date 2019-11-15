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
    public partial class View2Projects : IKK_controls.View
    {
        public View2Projects()
        {
            InitializeComponent();
            projectSelected.UpdateProject(new IKK_data.Project(-1, -1, "Válassz egy projektet!", "Kattints egy kártyára szerkesztéshez.", "", DateTime.Now, null));
        }

        private void flp_Paint(object sender, PaintEventArgs e)
        {
            lblSectionLocal.Width = flp.Width - flp.Margin.Left * 2;
            lblSectionOnline.Width = flp.Width - flp.Margin.Left * 2;
        }

        private void nmiOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = IKK_data.IO.PROJECT_FILTER;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Storage.MainContainer.SetView(new View1Editor(IKK_data.IO.ProjectOpen(ofd.FileName)));

                }
                catch (Exception ex)
                {
                    IKK_controls.MsgBox.Show("Megnyitás", ex.Message);
                }
            }
        }

        private void nmiNew_Click(object sender, EventArgs e)
        {
            Storage.MainContainer.SetView(new View1Editor());
        }
    }
}
