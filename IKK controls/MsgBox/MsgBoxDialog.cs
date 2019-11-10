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
    public partial class MsgBoxDialog : Form, IThemable
    {
        public MsgBoxDialog(string title, string text, MsgBox.MsgBoxButton[] buttons)
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;

            lblTitle.Text = title;
            lblDesc.Text = text;

            foreach (MsgBox.MsgBoxButton mbb in buttons)
            {
                flpBtns.Controls.Add(new Btn() { Text = mbb.Text, Raised = mbb.Raised, DialogResult = mbb.Result });
            }

            UpdateTheme();
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorBackground;
            pBox.BackColor = Theme.ColorBackground;
            pHeader.BackColor = Theme.ColorPrimary;
            lblTitle.UpdateTheme();
            lblDesc.UpdateTheme();
        }
    }
}
