using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Drawing.Design;
using IKK_data;

namespace IKK_controls
{
    public partial class ProjectCard : UserControl, IThemable
    {
        public Project Project { get; private set; }
        public bool Removable { get => btnRemove.Visible; set => btnRemove.Visible = value; }
        public bool Selected { get => selected; set { selected = value; Refresh(); } }

        bool selected = false;

        public ProjectCard()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            UpdateTheme();
        }
        public ProjectCard(Project project)
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            UpdateTheme();
            UpdateProject(project);
        }

        public void UpdateTheme()
        {
            BackColor = selected ? Theme.ColorAccent : Theme.ColorPrimary;
            ForeColor = Theme.ColorText;
        }

        public void UpdateProject(Project project)
        {
            Project = project;
            lblTitle.Text = project.Title;
            lblDesc.Text = project.Content;
            lblLabel.Text = project.Label;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Selected) ControlPaint.DrawBorder(e.Graphics, new Rectangle(0, 0, Width - 2, Height - 2), Theme.ColorAccent, ButtonBorderStyle.Solid);
        }

        private void controls_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MsgBox.MsgBoxButton[] btns = {
                new MsgBox.MsgBoxButton("Nem", true, DialogResult.Cancel),
                new MsgBox.MsgBoxButton("Csak a listáról", false, DialogResult.No),
                new MsgBox.MsgBoxButton("Igen, a fájlt is", false, DialogResult.Yes)
            };
            DialogResult result = MsgBox.Show("Projekt törlése", "Biztos ki szeretnéd törölni ezt a projektet?", btns);

            if (result == DialogResult.Cancel) return;

            Settings.ListDelete("latestFiles", Project.FileName);
            Parent.Controls.Remove(this);

            if (result == DialogResult.Yes)
            {
                try
                {
                    IO.Delete(Project.FileName);
                }
                catch (Exception ex)
                {
                    MsgBox.Show("Törlés", ex.Message);
                }
            }
        }
    }
}
