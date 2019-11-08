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
    public partial class MsgBox : Form, IThemable
    {
        public MsgBox(string title, string text)
        {
            InitializeComponent();

            UpdateTheme();

            lblTitle.Text = title;
            lblText.Text = text;

            flpButtons.Controls.Add(new Btn() { Text = "Ok", Raised = true, DialogResult = DialogResult.OK });
        }

        public MsgBox(string title, string text, MsgBoxButton[] buttons)
        {
            InitializeComponent();

            UpdateTheme();

            lblTitle.Text = title;
            lblText.Text = text;

            Btn btnNext;
            foreach (MsgBoxButton item in buttons)
            {
                btnNext = new Btn() { Text = item.Text, Raised = item.Raised, DialogResult = item.Result };
                flpButtons.Controls.Add(btnNext);
            }
        }

        public void UpdateTheme()
        {
            ForeColor = Theme.ColorText;
            pBox.BackColor = Theme.ColorBackground;
            pHead.BackColor = Theme.ColorPrimary;
        }
    }

    public struct MsgBoxButton
    {
        public string Text;
        public bool Raised;
        public DialogResult Result;

        public MsgBoxButton(string text, bool raised, DialogResult result)
        {
            Text = text;
            Raised = raised;
            Result = result;
        }
    }
}
