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
    public partial class View3Edit : IKK_controls.View
    {
        public View3Edit()
        {
            InitializeComponent();
            if (Storage.CurrentProject != null)
            {
                tbTitle.Text = Storage.CurrentProject.Title;
                cbLabel.Text = Storage.CurrentProject.Label;
                tbCreateTime.Text = Storage.CurrentProject.CreateTime.ToString();
                lblIdInfo.Text = $"Mű azonosító: {Storage.CurrentProject.ID}\n\rKöltő / szerző azonosító: {Storage.LocalUser.ID}";
            }
            ready = true;
        }

        bool ready = false;

        private void valuesChanged(object sender, EventArgs e)
        {
            if (!ready) return;

            Storage.CurrentProject.Title = tbTitle.Text;
            Storage.CurrentProject.Label = cbLabel.Text;
        }
    }
}
