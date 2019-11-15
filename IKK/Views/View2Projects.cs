using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKK_data;

namespace IKK
{
    public partial class View2Projects : IKK_controls.View
    {
        public View2Projects()
        {
            InitializeComponent();
        }

        void ReloadProjects()
        {
            flpLatest.Controls.Clear();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Application.ExecutablePath.Remove(Application.ExecutablePath.LastIndexOf('\\'));

            if (fbd.ShowDialog() != DialogResult.OK) return;

            List<Project> projects = IO.GetProjectsFromFolder(fbd.SelectedPath);
            foreach (Project project in projects)
            {
                flpLatest.Controls.Add(new IKK_controls.ProjectCard(project));
            }
        }

        private void nmiRefresh_Click(object sender, EventArgs e)
        {
            ReloadProjects();
        }

        private void nmiOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = IO.PROJECT_FILTER;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Storage.MainContainer.SetView(new View1Editor(IO.ProjectOpen(ofd.FileName)));

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
