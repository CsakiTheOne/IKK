﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKK_controls;
using IKK_storage;
using IKK_data;

namespace IKK
{
    public partial class View2Profile : IKK_controls.View
    {
        public View2Profile()
        {
            InitializeComponent();
            RefreshProfile();
        }

        private void nmiLogout_Click(object sender, EventArgs e)
        {
            Storage.LocalUser = null;
            Storage.GetMainContainer<ViewContainer>().SetView(new View1Login());
        }

        private void nmiRefresh_Click(object sender, EventArgs e)
        {
            RefreshProfile();
        }

        void RefreshProfile()
        {
            if (Storage.OfflineMode)
            {
                foreach (Control control in Controls)
                {
                    if (control.GetType() == typeof(Tb) || control.GetType() == typeof(Btn))
                    {
                        control.Enabled = false;
                    }
                }
            }
            else
            {
                Profile profile = Database.GetProfileByID(Storage.LocalUser.ID);
                if (profile == null) return;
                Storage.LocalUser = profile;
            }

            tbEmail.Text = Storage.LocalUser.Email;
            tbName.Text = Storage.LocalUser.Name;
            tbAbout.Text = Storage.LocalUser.About;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Database.UpdateProfile(Storage.LocalUser.ID, tbEmail.Text, tbName.Text, tbAbout.Text);
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            string result = Database.Login(Storage.LocalUser.Email, Secret.Encrypt(tbPassOld.Text));
            if (!result.Contains("PROFILE"))
            {
                MsgBox.Show("Jelszó változtatás", "Írd be helyesen a régi jelszavad, hogy újat tudj állítani!");
                return;
            }

            if (
                MsgBox.Show(
                    "Jelszó változtatás", "Biztos meg akarod változtatni?",
                    new MsgBox.MsgBoxButton[] { new MsgBox.MsgBoxButton("Igen", true, DialogResult.Yes), new MsgBox.MsgBoxButton("Nem", false, DialogResult.No)
                }) != DialogResult.Yes)
                return;
            
            Database.UpdatePassword(Storage.LocalUser.ID, Secret.Encrypt(tbPassNew.Text));
        }
    }
}
