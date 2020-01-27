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
    public partial class TextBoxMenu : Form, IThemable
    {
        public TextBoxMenu()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            UpdateTheme();
        }

        public void UpdateTheme()
        {
            TransparencyKey = Theme.ColorTransparent;
            BackColor = Theme.ColorTransparent;
            ForeColor = Theme.ColorText;
            card.UpdateTheme();
        }

        public void SetText(string text)
        {
            lblErrors.Text = text;
        }

        public string GetText()
        {
            return lblErrors.Text;
        }
    }
}
