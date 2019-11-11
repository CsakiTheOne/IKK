using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_controls
{
    public static class Theme
    {
        public static Color ColorBackground { get; private set; } = Color.FromArgb(62, 39, 35);
        public static Color ColorPrimary { get; private set; } = Color.FromArgb(93, 64, 55);
        public static Color ColorAccent { get; private set; } = Color.FromArgb(221, 44, 0);
        public static Color ColorText { get; private set; } = Color.FromArgb(255, 255, 255);
        public static Color ColorTransparent { get; private set; } = Color.Magenta;

        public static event Action ThemeChanged;

        public static void SetColorBackground(Color color) { ColorBackground = color; ThemeChanged(); }
        public static void SetColorPrimary(Color color) { ColorPrimary = color; ThemeChanged(); }
        public static void SetColorAccent(Color color) { ColorAccent = color; ThemeChanged(); }
        public static void SetColorText(Color color) { ColorText = color; ThemeChanged(); }

        public static void ForceUpdate()
        {
            ThemeChanged();
        }
    }
}
