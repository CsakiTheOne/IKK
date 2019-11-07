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
    public partial class Tb : TextBox, IThemable
    {
        public bool Secret { get => secret; set { secret = value; PasswordChar = secret ? '●' : '\0'; } }

        bool secret;

        public Tb()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            if (Secret) PasswordChar = '●';
        }

        public void UpdateTheme()
        {
            if (Parent != null) BackColor = Parent.BackColor;
            ForeColor = Theme.ColorText;
            Graphics g = CreateGraphics();
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, Width, Height);
        }

        private void Tb_MouseDown(object sender, MouseEventArgs e)
        {
            if (Secret && e.Button == MouseButtons.Left) PasswordChar = '\0';
        }

        private void Tb_MouseUp(object sender, MouseEventArgs e)
        {
            if (Secret && e.Button == MouseButtons.Left) PasswordChar = '●';
        }
    }
}
