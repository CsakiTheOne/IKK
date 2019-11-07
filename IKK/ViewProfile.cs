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
    public partial class ViewProfile : IKK_controls.View
    {
        public ViewProfile()
        {
            InitializeComponent();
            lblProfile.Text = Storage.LocalUser.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Storage.LocalUser = null;
            Storage.MainContainer.SetView(new ViewLogin());
        }
    }
}
