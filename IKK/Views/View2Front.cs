using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKK_storage;
using IKK_data;

namespace IKK
{
    public partial class View2Front : IKK_controls.View
    {
        public View2Front()
        {
            InitializeComponent();
        }

        private void View2Front_Load(object sender, EventArgs e)
        {
            if (Storage.OfflineMode) return;
            lblQuote.Text = Database.GetQuote(DateTime.Now.DayOfYear);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Storage.OfflineMode)
            {
                IKK_controls.MsgBox.Show("Offline mód", "Ez a funkció nem működik offline módban.");
                return;
            }

            Profile profile = Database.GetProfileByName(tbSearch.Text);
            if (profile == null)
            {
                IKK_controls.MsgBox.Show("Keresés", "Nincs ilyen nevű felhasználó.");
                return;
            }
            string answer = $"{profile.Email}\n\r{profile.About}\n\r\n\rUtolsó bejelentkezés ideje: {profile.LastLogin.ToString()}";
            IKK_controls.MsgBox.Show(profile.Name, answer);
            tbSearch.Clear();
        }
    }
}
