using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKK_controls
{
    public partial class NavMenuItem : Control, IThemable
    {
        public bool Selected { get; set; } = false;
        public Image Icon { get => icon; set { icon = value; Refresh(); } }
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public override string Text { get => text; set { text = value; Refresh(); } }

        Image icon;
        string text;
        bool collapsed = false;

        public NavMenuItem()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
        }
        public NavMenuItem(string text, Image icon = null)
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;

            Text = text;
            if (icon != null) Icon = icon;
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorBackground;
            ForeColor = Theme.ColorText;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Width = Parent.Width;
            collapsed = Width < Height * 2;

            ttText.SetToolTip(this, collapsed ? Text : "");

            if (Selected)
            {
                Brush accentBrush = new SolidBrush(Theme.ColorAccent);
                Point[] points = { new Point(0, 4), new Point(Width - 30, 4), new Point(Width, 30), new Point(Width - 30, Height - 4), new Point(0, Height - 4) };
                byte[] ppt = { 0, 1, 1, 1, 1 };
                GraphicsPath path = new GraphicsPath(points, ppt);
                pe.Graphics.FillPath(accentBrush, path);
                accentBrush.Dispose();
            }

            if (Icon != null) pe.Graphics.DrawImage(Icon, new Rectangle(collapsed ? 8 : 16, 16, 28, 28));

            if (collapsed) return;

            Brush textBrush = new SolidBrush(Theme.ColorText);
            pe.Graphics.DrawString(Text, Font, textBrush, 68, 20);
            textBrush.Dispose();
        }
    }
}
