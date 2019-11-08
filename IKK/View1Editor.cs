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
            if (split.SplitterDistance < 200) split.SplitterDistance = 250;

            switch (navMenu.SelectedItem)
            {
                case "Kilépés":
                    if (
                        new MsgBox(
                        "Kilépés",
                        "Minden nem mentett változtatás el fog veszni! Folytatod?",
                        new MsgBoxButton[] { new MsgBoxButton("Igen", true, DialogResult.Yes), new MsgBoxButton("Nem", true, DialogResult.No) }
                        ).ShowDialog() == DialogResult.No
                    )
                    {
                        navMenu.SelectedItem = "Szerkesztés";
                        return;
                    }
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
            rtb.BackColor = Theme.ColorBackground;
            rtb.ForeColor = Theme.ColorText;
            menuStrip.BackColor = Theme.ColorPrimary;
            menuStrip.ForeColor = Theme.ColorText;
        }

        #region ToolStripMenu
        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (
                new MsgBox(
                "Új projekt",
                "Minden nem mentett változtatás el fog veszni! Folytatod?",
                new MsgBoxButton[] { new MsgBoxButton("Igen", true, DialogResult.Yes), new MsgBoxButton("Nem", true, DialogResult.No) }
                ).ShowDialog() == DialogResult.No
            ) return;

            Storage.MainContainer.SetView(new View1Editor());
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void rtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
