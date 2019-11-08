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
    public partial class View2Projects : IKK_controls.View
    {
        public View2Projects()
        {
            InitializeComponent();
        }

        private void nmiNew_Click(object sender, EventArgs e)
        {
            Storage.MainContainer.SetView(new View1Editor());
        }
    }
}
