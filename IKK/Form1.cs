using IKK_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKK
{
    public partial class FormMain : Form, IThemable
    {
        public FormMain()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
            UpdateTheme();
        }

        public void UpdateTheme()
        {
            BackColor = Theme.ColorBackground;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Storage.MainContainer = viewContainerMain;

            if (Storage.TestConnection())
            {
                viewContainerMain.SetView(new View1Login());
            }
            else
            {
                Storage.LocalUser = new IKK_data.Profile(-1, "nincs", "Offline felhasználó", "Nincs netem vagy a szerver nem elérhető.", DateTime.Today);
                viewContainerMain.SetView(new View1Main());
            }
        }
    }
}
