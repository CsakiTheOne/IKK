using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int length = int.Parse(IKK_data.Database.GetData("SELECT COUNT(id) FROM quote;").Rows[0].ItemArray[0].ToString());
            int rdm = new Random(DateTime.Now.DayOfYear).Next(length);
            object[] cols = IKK_data.Database.GetData("SELECT quote, author FROM quote;").Rows[rdm].ItemArray;
            lblQuote.Text = $"{cols[0]}\n\r- {cols[1]}";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Storage.OfflineMode) IKK_controls.MsgBox.Show("Offline mód", "Ez a funkció nem működik offline módban.");

            DataTable response = IKK_data.Database.GetData($"SELECT id, email, name, about, lastlogin FROM user WHERE name LIKE '%{tbSearch.Text}%';");
            if (response.Rows.Count < 1)
            {
                IKK_controls.MsgBox.Show("Keresés", "Nincs ilyen nevű felhasználó.");
                return;
            }
            object[] cols = response.Rows[0].ItemArray;
            string answer = $"({cols[0]}) {cols[1]}\n\r{cols[3]}\n\r\n\rUtolsó bejelentkezés ideje: {cols[4]}";
            IKK_controls.MsgBox.Show(cols[2].ToString(), answer);
            tbSearch.Clear();
        }
    }
}
