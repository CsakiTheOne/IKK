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
using IKK_storage;

namespace IKK
{
    public partial class View1Editor : IKK_controls.View
    {
        TextBoxMenu formTbMenu = new TextBoxMenu();

        public View1Editor()
        {
            InitializeComponent();
            ofd.Filter = IO.PROJECT_FILTER;
            sfd.Filter = IO.PROJECT_FILTER;
            LoadProject(new Project(-1, Storage.LocalUser.ID, "", tb.Text, "", DateTime.Now, new List<Tool>(), ""));
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

            IKK_notif.NotifManager.Notified += NotifManager_Notified;
        }

        private void NotifManager_Notified(IKK_notif.Notification sender)
        {
            if (sender.Sender == "Eszköz")
            {
                formTbMenu.SetText($"{sender.Title}\n\r{sender.Desc}");
                IKK_notif.NotifManager.Dismiss(sender);
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
                    formTbMenu.Close();
                    Storage.GetMainContainer<ViewContainer>().SetView(new View1Main());
                    break;
                case "Szerkesztés":
                    viewContainer.SetView(new View3Edit());
                    break;
                case "Eszközök":
                    viewContainer.SetView(new View3Tools());
                    break;
            }

            tb.Refresh();
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

            Storage.GetMainContainer<ViewContainer>().SetView(new View1Editor());
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

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                formTbMenu.Show();
                ParentForm.Focus();
            }
        }

        private void tb_KeyUp(object sender, KeyEventArgs e)
        {
            tb_Update();
        }

        private void tb_Click(object sender, EventArgs e)
        {
            formTbMenu.Hide();
            textBoxMenuToolStripMenuItem.Checked = false;
        }

        private void tb_Update()
        {
            Point atChar = tb.GetPositionFromCharIndex(tb.SelectionStart);
            Point point = new Point(64 + split.SplitterDistance + atChar.X, 70 + atChar.Y);
            formTbMenu.Location = point;
        }

        private void textBoxMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxMenuToolStripMenuItem.Checked)
            {
                formTbMenu.Show();
                ParentForm.Focus();
                tb_Update();
            }
            else
            {
                formTbMenu.Hide();
            }
        }
    }
}
