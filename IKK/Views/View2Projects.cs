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
using IKK_controls;
using IKK_storage;

namespace IKK
{
    public partial class View2Projects : IKK_controls.View
    {
        Project selectedProject;

        public View2Projects()
        {
            InitializeComponent();
            LoadLatest();
        }

        #region Latest projects
        void LoadLatest()
        {
            flpLatest.Controls.Clear();
            List<Project> latestProjects = IO.LatestProjects();
            ProjectCard pc;
            foreach (Project p in latestProjects)
            {
                pc = new ProjectCard(p);
                pc.Removable = true;
                pc.Click += ProjectCard_Click;
                flpLatest.Controls.Add(pc);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = IO.PROJECT_FILTER;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IO.ProjectOpen(ofd.FileName);
                    Settings.ListAppend("latestFiles", ofd.FileName);
                }
                catch (Exception ex)
                {
                    MsgBox.Show("Hozzáadás a legutóbbikhoz", ex.Message);
                }
                LoadLatest();
            }
        }
        #endregion

        #region New & Open
        private void nmiOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = IO.PROJECT_FILTER;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Storage.GetMainContainer<ViewContainer>().SetView(new View1Editor(IO.ProjectOpen(ofd.FileName)));
                }
                catch (Exception ex)
                {
                    MsgBox.Show("Megnyitás", ex.Message);
                }
            }
        }

        private void nmiNew_Click(object sender, EventArgs e)
        {
            Storage.GetMainContainer<ViewContainer>().SetView(new View1Editor());
        }
        #endregion

        private void ProjectCard_Click(object sender, EventArgs e)
        {
            foreach (ProjectCard item in flpLatest.Controls)
            {
                item.Selected = false;
            }
            ((ProjectCard)sender).Selected = true;
            selectedProject = ((ProjectCard)sender).Project;
            cardManageSelected.Visible = true;
            lblSelected.Text = selectedProject.Title;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Storage.GetMainContainer<ViewContainer>().SetView(new View1Editor(selectedProject));
        }
    }
}
