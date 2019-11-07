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
        public MsgBox(string title, string text, string btn1Text = "Ok", bool btn1Raise = true, string btn2Text = "", bool btn2Raise = false, string btn3Text = "", bool btn3Raise = false)
        {
            InitializeComponent();

            UpdateTheme();

            lblTitle.Text = title;
            lblText.Text = text;
            btn1.Text = btn1Text;
            btn1.Raised = btn1Raise;
            if (btn2Text == "") btn2.Visible = false;
            else
            {
                btn2.Visible = true;
                btn2.Text = btn2Text;
                btn2.Raised = btn2Raise;
            }
            if (btn3Text == "") btn3.Visible = false;
            else
            {
                btn3.Visible = true;
                btn2.Text = btn3Text;
                btn2.Raised = btn3Raise;
            }
        }

        public void UpdateTheme()
        {
            ForeColor = Theme.ColorText;
            pBox.BackColor = Theme.ColorBackground;
            pHead.BackColor = Theme.ColorPrimary;
        }
    }
}
