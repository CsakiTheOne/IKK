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
            lblProfile.Text = Storage.LocalUser.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogout.Enabled = false;
            Storage.TestConnection(ConnectionTestFinnished, false);
        }

        private void ConnectionTestFinnished(bool connection)
        {
            Invoke(new Action(() => {
                if (connection)
                {
                    Storage.LocalUser = null;
                    Storage.MainContainer.SetView(new View1Login());
                }
                else
                {
                    MsgBox.Show("Offline mód", "Jelenleg nem tudsz kijelentkezni.");
                    btnLogout.Enabled = true;
                }
            }));
        }
    }
}
