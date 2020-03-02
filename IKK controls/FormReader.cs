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
    public partial class FormReader : Form, IThemable
    {
        Project project;

        public FormReader()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            UpdateTheme();

            project = new Project();
            LoadProject();
        }

        public FormReader(Project projectToRead)
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            UpdateTheme();

            project = projectToRead;
            LoadProject();
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorBackground;
            ForeColor = Theme.ColorText;
            cardContent.BackColor = Theme.ColorPrimary;
        }

        void LoadProject()
        {
            Text = $"IKK olvasó - {project.Title}";
            lblTitle.Text = project.Title;
            lblContent.Text = project.Content;
        }

        void LoadDetails()
        {
            lblTitle.Text = $"Részletek erről: {project.Title}";

            string content = $"Műfaj / címke: {project.Label}\n\r\n\rKészült ekkor: {project.CreateTime}";

            if (project.Tools == null || project.Tools.Count < 1) content += "\n\r\n\rNincsenek eszközök.";
            else content += "\n\r\n\rEszközök:\n\r";

            foreach (Tool tool in project.Tools)
            {
                content += $"\n\r{tool.Name}: {tool.Settings}\n\r";
            }

            lblContent.Text = content;
        }

        private void navMenu1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (navMenu1.SelectedItem == "Olvasás") LoadProject();
            else LoadDetails();
        }
    }
}
