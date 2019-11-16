using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKK_controls;

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
            Storage.MainContainer.SetView(new View1Login());
        }

        private void nmiRefresh_Click(object sender, EventArgs e)
        {
            RefreshProfile();
        }

        void RefreshProfile()
        {
            if (Storage.OfflineMode)
            {
                MsgBox.Show("Offline mód", "Nem vagy bejelentkezve!");
                return;
            }

            DataTable response = IKK_data.Database.GetData($"SELECT id, email, name, about, lastquote FROM user WHERE id = {Storage.LocalUser.ID}");

            if (response.Rows.Count < 1) return;

            object[] cols = response.Rows[0].ItemArray;

            if (cols[4].ToString().Length < 1) cols[4] = DateTime.MinValue.ToString();
            Storage.LocalUser = new IKK_data.Profile((int)cols[0], cols[1].ToString(), cols[2].ToString(), cols[3].ToString(), DateTime.Parse((string)cols[4]));

            tbEmail.Text = Storage.LocalUser.Email;
            tbName.Text = Storage.LocalUser.Name;
            tbAbout.Text = Storage.LocalUser.About;
            lblOther.Text = $"({Storage.LocalUser.ID}) {Storage.LocalUser.LastQuote}";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Storage.OfflineMode)
            {
                MsgBox.Show("Offline mód", "Nem vagy bejelentkezve!");
                return;
            }
            IKK_data.Database.GetData($"UPDATE user SET email = '{tbEmail.Text}', name = '{tbName.Text}', about = '{tbAbout.Text}' WHERE id = {Storage.LocalUser.ID};");
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            if (Storage.OfflineMode)
            {
                MsgBox.Show("Offline mód", "Nem vagy bejelentkezve!");
                return;
            }
            string result = IKK_data.Database.Login(Storage.LocalUser.Email, Secret.Encrypt(tbPassOld.Text));
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
            
            IKK_data.Database.GetData($"UPDATE user SET password = '{Secret.Encrypt(tbPassNew.Text)}' WHERE id = {Storage.LocalUser.ID};");
        }
    }
}
