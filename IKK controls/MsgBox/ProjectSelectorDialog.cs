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
    public partial class ProjectSelectorDialog : Form, IThemable
    {
        public Project SelectedProject = null;

        public ProjectSelectorDialog(List<Project> projects)
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            UpdateTheme();

            flp.Controls.Clear();
            ProjectCard pc;
            foreach (Project p in projects)
            {
                pc = new ProjectCard(p);
                pc.Removable = true;
                pc.Click += ProjectCard_Click;
                flp.Controls.Add(pc);
            }
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorBackground;
            ForeColor = Theme.ColorText;
            flp.BackColor = Theme.ColorPrimary;
        }

        private void ProjectCard_Click(object sender, EventArgs e)
        {
            foreach (ProjectCard item in flp.Controls)
            {
                item.Selected = false;
            }
            ((ProjectCard)sender).Selected = true;
            SelectedProject = ((ProjectCard)sender).Project;
        }
    }
}
