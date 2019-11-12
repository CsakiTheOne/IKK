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
        public View1Editor()
        {
            InitializeComponent();
            ofd.Filter = IO.PROJECT_FILTER;
            sfd.Filter = IO.PROJECT_FILTER;
            LoadProject(new Project(-1, Storage.LocalUser.ID, "", tb.Text, "", DateTime.Now, new List<Tool>()));
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
            tb.BackColor = Theme.ColorBackground;
            tb.ForeColor = Theme.ColorText;
            menuStrip.BackColor = Theme.ColorPrimary;
            menuStrip.ForeColor = Theme.ColorText;
        }

        void LoadProject(Project project)
        {
            Storage.CurrentProject = project;
            tb.Text = project.Content;
            navMenu.SelectedItem = "Szerkesztés";
            split.SplitterDistance = 0;

            foreach (Tool tool in Storage.CurrentProject.Tools)
            {
                tool.OnLoad(tb.Text);
            }
        }

        private void navMenu1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (split.SplitterDistance < 200) split.SplitterDistance = 250;

            switch (navMenu.SelectedItem)
            {
                case "Kilépés":
                    if (
                        MsgBox.Show(
                        "Kilépés",
                        "Minden nem mentett változtatás el fog veszni! Folytatod?",
                        new MsgBox.MsgBoxButton[] { new MsgBox.MsgBoxButton("Igen", true, DialogResult.Yes), new MsgBox.MsgBoxButton("Nem", true, DialogResult.No) })
                        == DialogResult.No
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
                MsgBox.Show(
                "Új projekt",
                "Minden nem mentett változtatás el fog veszni! Folytatod?",
                new MsgBox.MsgBoxButton[] { new MsgBox.MsgBoxButton("Igen", true, DialogResult.Yes), new MsgBox.MsgBoxButton("Nem", true, DialogResult.No) })
                == DialogResult.No
            ) return;

            Storage.MainContainer.SetView(new View1Editor());
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadProject(IO.ProjectOpen(ofd.FileName));
                }
                catch (Exception ex)
                {
                    MsgBox.Show("Megnyitás", ex.Message);
                }
            }
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IO.ProjectSave(Storage.CurrentProject, sfd.FileName);
                }
                catch (Exception ex)
                {
                    MsgBox.Show("Mentés", ex.Message);
                }
            }
        }

        private void weboldalKészítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportDialog = new SaveFileDialog();
            exportDialog.Title = "Weboldal készítése";
            exportDialog.Filter = "HTML only|*.html";
            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IO.ProjectExport(Storage.CurrentProject, exportDialog.FileName);
                }
                catch (Exception ex)
                {
                    MsgBox.Show("Exportálás", ex.Message);
                }
            }
        }
        #endregion

        private void tb_TextChanged(object sender, EventArgs e)
        {
            Storage.CurrentProject.Content = tb.Text;
            foreach (Tool tool in Storage.CurrentProject.Tools)
            {
                tool.OnChange(tb.Text);
            }
            
        }
    }
}
