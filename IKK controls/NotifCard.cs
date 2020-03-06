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
        public Notification Notification { get; private set; }
        public bool Expanded { get; private set; }

        public NotifCard(Notification notification)
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;

            Notification = notification;
            UpdateTheme();
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorPrimary;
            flpButtons.BackColor = Theme.ColorPrimary;
            ForeColor = Theme.ColorText;

            lblTop.Text = $"{Notification.Sender} • {Notification.Time}";
            lblTitle.Text = Notification.Title;
            lblDesc.Text = Notification.Desc;
            Expanded = Notification.StartExtended;
            Height = Notification.StartExtended ? 110 : 80;
            pbResize.Image = Expanded ? Properties.Resources.sharp_expand_less_white_48dp : Properties.Resources.sharp_expand_more_white_48dp;
            pbResize.Visible = Notification.Resizable;

            flpButtons.Controls.Clear();

            if (Notification.Actions != null)
            {
                foreach (NotifAction action in Notification.Actions)
                {
                    Btn btn = new Btn();
                    btn.Margin = new Padding(0);
                    btn.Text = action.Name;
                    btn.Click += (object sender, EventArgs e) => { action.Action(Notification); };
                    flpButtons.Controls.Add(btn);
                    btn.UpdateTheme();
                }
            }
        }

        private void pbDismiss_Click(object sender, EventArgs e)
        {
            NotifManager.Dismiss(Notification);
        }

        private void resize(object sender, EventArgs e)
        {
            if (!Notification.Resizable) return;

            Expanded = !Expanded;
            Height = Expanded ? 110 : 80;
            pbResize.Image = Expanded ? Properties.Resources.sharp_expand_less_white_48dp : Properties.Resources.sharp_expand_more_white_48dp;
        }
    }
}
