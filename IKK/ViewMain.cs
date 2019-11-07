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
    public partial class ViewMain : IKK_controls.View
    {
        public ViewMain()
        {
            InitializeComponent();
            navMenu1.SelectedItem = "Főoldal";
        }

        private void navMenu1_SelectedItemChanged(object sender, EventArgs e)
        {
            switch (navMenu1.SelectedItem)
            {
                case "Főoldal":
                    viewContainer1.SetView(new ViewFront());
                    break;
                case "Profil":
                    viewContainer1.SetView(new ViewProfile());
                    break;
                case "Verses fal":
                    viewContainer1.SetView(new IKK_controls.View());
                    break;
                case "Művek":
                    viewContainer1.SetView(new IKK_controls.View());
                    break;
            }
        }
    }
}
