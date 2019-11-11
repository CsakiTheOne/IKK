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

            Storage.TestConnection(ConnectionTestFinnished, true);
        }

        private void ConnectionTestFinnished(bool connection)
        {
            Invoke(new Action(() =>
            {
                if (connection)
                {
                    viewContainerMain.SetView(new View1Login());
                }
                else
                {
                    Storage.LocalUser = new IKK_data.Profile(-1, "Nincs bejelentkezve", "Offline felhasználó", "", DateTime.Now);
                    viewContainerMain.SetView(new View1Main());
                }
            }));
        }
    }
}
