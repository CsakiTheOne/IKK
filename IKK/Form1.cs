﻿using IKK_controls;
using IKK_notif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKK
{
    public partial class FormMain : Form, IThemable
    {
        public FormMain()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            UpdateTheme();
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorBackground;
            btnNotifOpen.UpdateTheme();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Storage.MainContainer = viewContainerMain;

            NotifManager.Notified += NotifManager_Refresh;
            NotifManager.Dismissed += NotifManager_Refresh;

            MsgBox.MsgBoxButton[] buttons = { new MsgBox.MsgBoxButton("Publikus", true, DialogResult.OK), new MsgBox.MsgBoxButton("Helyi", false, DialogResult.Ignore) };
            bool test = MsgBox.Show("Válassz szervert!", "Ha nem a fejlesztő vagy, akkor a publikus szerverrel próbálkozz!", buttons) == DialogResult.Ignore;

            if (!test)
            {
                IKK_data.Database.DB = "Server=remotemysql.com;User ID=BwbvoshEex;Password=LJtxlTZdiF;Database=BwbvoshEex";
            }

            Storage.TestConnection(ConnectionTestFinnished, true);
        }

        private void ConnectionTestFinnished(bool connection)
        {
            Invoke(new Action(() =>
            {
                if (connection)
                {
                    viewContainerMain.SetView(new View1Login());
                }
                else
                {
                    Storage.LocalUser = new IKK_data.Profile(-1, "Nincs bejelentkezve", "Offline felhasználó", "", DateTime.Now);
                    viewContainerMain.SetView(new View1Main());
                }
            }));
        }

        private void btnNotifOpen_Click(object sender, EventArgs e)
        {
            pNotifArea.Visible = !pNotifArea.Visible;
        }

        private void NotifManager_Refresh(Notification sender)
        {
            flpNotifArea.Controls.Clear();

            foreach (Notification notif in NotifManager.Notifications)
            {
                // TODO
                flpNotifArea.Controls.Add();
            }
        }
    }
}
