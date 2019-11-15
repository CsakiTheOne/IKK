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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Storage.OfflineMode) IKK_controls.MsgBox.Show("Offline mód", "Ez a funkció nem működik offline módban.");

            DataTable response = IKK_data.Database.GetData($"SELECT id, email, name, about FROM user WHERE name LIKE '%{tbSearch.Text}%';");
            if (response.Rows.Count < 1) return;
            object[] cols = response.Rows[0].ItemArray;
            string answer = $"({cols[0]}) {cols[1]}: {cols[2]}\n\r{cols[3]}";
            IKK_controls.MsgBox.Show(tbSearch.Text, answer);
            tbSearch.Clear();
        }
    }
}
