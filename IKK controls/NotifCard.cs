using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKK_notif;

namespace IKK_controls
{
    public partial class NotifCard : UserControl, IThemable
    {
        public Notification notification { get; private set; }

        public NotifCard()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorPrimary;
        }

        // TODO
    }
}
