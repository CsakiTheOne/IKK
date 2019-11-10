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
using IKK_data;

namespace IKK
{
    public partial class View1Editor : IKK_controls.View
    {
        Project project;

        public View1Editor()
        {
            InitializeComponent();
            ofd.Filter = IO.PROJECT_FILTER;
            sfd.Filter = IO.PROJECT_FILTER;
            LoadProject(new Project(-1, Storage.LocalUser.ID, "", rtb.Text, "", DateTime.Now, null));
        }

        public View1Editor(Project project)
        {
            InitializeComponent();
            ofd.Filter = IO.PROJECT_FILTER;
            sfd.Filter = IO.PROJECT_FILTER;
            LoadProject(project);
        }

        public View1Editor(string projectFileName)
        {
            InitializeComponent();
            ofd.Filter = IO.PROJECT_FILTER;
            sfd.Filter = IO.PROJECT_FILTER;
            LoadProject(IO.ProjectOpen(projectFileName));
        }

        public override void UpdateTheme()
        {
            base.UpdateTheme();
            rtb.BackColor = Theme.ColorBackground;
            rtb.ForeColor = Theme.ColorText;
            menuStrip.BackColor = Theme.ColorPrimary;
            menuStrip.ForeColor = Theme.ColorText;
        }

        void LoadProject(Project project)
        {
            Storage.CurrentProject = project;
            rtb.Text = project.Content;
            navMenu.SelectedItem = "Szerkesztés";
            split.SplitterDistance = 0;
        }

        private void navMenu1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (split.SplitterDistance < 200) split.SplitterDistance = 250;

            switch (navMenu.SelectedItem)
            {
                case "Kilépés":
                    if (
                        new MsgBox(
                        "Kilépés",
                        "Minden nem mentett változtatás el fog veszni! Folytatod?",
                        new MsgBoxButton[] { new MsgBoxButton("Igen", true, DialogResult.Yes), new MsgBoxButton("Nem", true, DialogResult.No) }
                        ).ShowDialog() == DialogResult.No
                    )
                    {
                        navMenu.SelectedItem = "Szerkesztés";
                        return;
                    }
                    Storage.MainContainer.SetView(new View1Main());
                    break;
                case "Szerkesztés":
                    viewContainer.SetView(new View3Edit());
                    break;
                case "Eszközök":
                    viewContainer.SetView(new View3Tools());
                    break;
            }
        }

        #region ToolStripMenu
        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (
                new MsgBox(
                "Új projekt",
                "Minden nem mentett változtatás el fog veszni! Folytatod?",
                new MsgBoxButton[] { new MsgBoxButton("Igen", true, DialogResult.Yes), new MsgBoxButton("Nem", true, DialogResult.No) }
                ).ShowDialog() == DialogResult.No
            ) return;

            Storage.MainContainer.SetView(new View1Editor());
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadProject(IO.ProjectOpen(ofd.FileName));
            }
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                IO.ProjectSave(Storage.CurrentProject, sfd.FileName);
            }
        }
        #endregion

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            Storage.CurrentProject.Content = rtb.Text;
        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProject(new Project(-2, -1, "Cím", "Tartalom", "vers", DateTime.Now, null));
        }
    }
}
