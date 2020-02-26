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
        }

        void LoadProject()
        {
            
        }
    }
}
