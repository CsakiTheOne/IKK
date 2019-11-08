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
    public partial class View1Editor : IKK_controls.View
    {
        public View1Editor()
        {
            InitializeComponent();
        }

        private void navMenu1_SelectedItemChanged(object sender, EventArgs e)
        {
            switch (navMenu1.SelectedItem)
            {
                case "Kilépés":
                    Storage.MainContainer.SetView(new View1Main());
                    break;
                case "Szerkesztés":
                    viewContainer1.SetView(new View3Edit());
                    break;
                case "Eszközök":
                    viewContainer1.SetView(new IKK_controls.View());
                    break;
            }
        }

        public override void UpdateTheme()
        {
            base.UpdateTheme();
            richTextBox1.BackColor = Theme.ColorBackground;
            richTextBox1.ForeColor = Theme.ColorText;
        }
    }
}
