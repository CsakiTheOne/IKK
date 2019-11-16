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
        string text = "";
        bool collapsed = false;
        bool mouseHover = false;

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
            // INIT
            collapsed = Width < Height * 2;
            Brush accentBrush = new SolidBrush(Theme.ColorAccent);
            Brush textBrush = new SolidBrush(Theme.ColorText);

            // ALWAYS DRAW
            int leftDecoMargin = collapsed ? 0 : 4;
            Point[] points = { new Point(leftDecoMargin, 12), new Point(leftDecoMargin + 2, 8), new Point(leftDecoMargin + 2, Height - 8), new Point(leftDecoMargin, Height - 12) };
            byte[] ppt = { 0, 1, 1, 1 };
            GraphicsPath path = new GraphicsPath(points, ppt);
            pe.Graphics.FillPath(accentBrush, path);

            // BACKTINT
            if (Selected || mouseHover)
            {
                int tintWidth = !collapsed && (text == null || text.Length < 1) ? Height + 20 : Width;
                points = new Point[] { new Point(0, 4), new Point(tintWidth - 30, 4), new Point(tintWidth, 30), new Point(tintWidth - 30, Height - 4), new Point(0, Height - 4) };
                ppt = new byte[] { 0, 1, 1, 1, 1 };
                path = new GraphicsPath(points, ppt);
                pe.Graphics.FillPath(Selected ? accentBrush : (mouseHover ? new SolidBrush(Color.FromArgb(32, Theme.ColorAccent)) : new SolidBrush(BackColor)), path);
            }

            // DRAW ICON
            if (Icon != null) pe.Graphics.DrawImage(Icon, new Rectangle(collapsed ? 8 : 16, 16, 28, 28));

            // DRAW TEXT
            if (!collapsed) pe.Graphics.DrawString(Text, Font, textBrush, new Point(68, 20));

            // END
            accentBrush.Dispose();
            textBrush.Dispose();
        }

        private void NavMenuItem_MouseEnter(object sender, EventArgs e)
        {
            mouseHover = true;
            Refresh();
        }

        private void NavMenuItem_MouseLeave(object sender, EventArgs e)
        {
            mouseHover = false;
            Refresh();
        }
    }
}
