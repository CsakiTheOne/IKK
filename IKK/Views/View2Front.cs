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
            int length = int.Parse(Database.ExecuteSQL("SELECT COUNT(id) FROM quote;").Rows[0].ItemArray[0].ToString());
            int rdm = new Random(DateTime.Now.DayOfYear).Next(length);
            object[] cols = Database.ExecuteSQL("SELECT quote, author FROM quote;").Rows[rdm].ItemArray;
            lblQuote.Text = $"{cols[0]}\n\r- {cols[1]}";
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
