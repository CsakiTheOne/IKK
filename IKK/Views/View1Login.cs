using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKK_data;
using IKK_controls;
using System.Diagnostics;
using IKK_notif;
using IKK_storage;

namespace IKK
{
    public partial class View1Login : IKK_controls.View
    {
        public View1Login()
        {
            InitializeComponent();
            lblTitle.Text = Storage.ProgramName;
            lblVersion.Text = Storage.ProgramVer;
            btnModeNet.PerformClick();
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            e.SuppressKeyPress = false;
            e.Handled = true;
            btnLogin.PerformClick();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Storage.OfflineMode)
            {
                Storage.LocalUser = new Profile(-1, "Nincs bejelentkezve", "Offline felhasználó", "Ez a felhasználó aktív, mikor a program offline módban van.");
                Storage.GetMainContainer<ViewContainer>().SetView(new View1Main());
                return;
            }

            if (tbPass.Text.Length < 1) MsgBox.Show("Bejelentkezés", "Minden mezőt ki kell tölteni!");
            else
            {
                string result = Database.Login(tbEmail.Text, Secret.Encrypt(tbPass.Text));
                if (result.Contains("PROFILE"))
                {
                    string[] data = result.Split(';');
                    Storage.LocalUser = new Profile(int.Parse(data[1]), data[2], data[3], data[4]);
                    Storage.GetMainContainer<ViewContainer>().SetView(new View1Main());
                }
                else MsgBox.Show("Bejelentkezés", result);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (tbPass.Text.Length < 1) MsgBox.Show("Regisztrálás", "Minden mezőt ki kell tölteni!");
            else MsgBox.Show("Regisztrálás", Database.Register(tbEmail.Text, Secret.Encrypt(tbPass.Text)));
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text.Length < 1) MsgBox.Show("Elfelejtett jelszó", "Írd be az e-mail címed, hogy tudjunk segíteni!");
            else
            {
                string newPass = new Random().Next(100000, 999999).ToString();
                Database.ForgotPassword(tbEmail.Text, Secret.Encrypt(newPass));
                Email.Send(tbEmail.Text, Storage.ProgramName + ": Elfelejtett jelszó", "Új jelszót állítottunk be neked, amivel be tudsz jelentkezni. Ne felejtsd megváltoztatni!\n\r" + newPass);
                MsgBox.Show("Elfelejtett jelszó", "Küldtünk neked egy e-mailt egy új jelszóval, amivel bejelentkezhetsz. Ne felejtsd megváltoztatni!");
            }
        }

        #region ModeSwitch
        void InitModeChanger()
        {
            btnModeNet.Enabled = false;
            btnModeDebug.Enabled = false;
            btnModeOffline.Enabled = false;
            btnModeNet.Raised = false;
            btnModeDebug.Raised = false;
            btnModeOffline.Raised = false;
            tbEmail.Enabled = true;
            tbPass.Enabled = true;
            btnPass.Enabled = true;
            btnReg.Enabled = true;

            tbEmail.Enabled = false;
            tbPass.Enabled = false;
            btnPass.Enabled = false;
            btnReg.Enabled = false;
            btnLogin.Enabled = false;
        }
        private void btnModeNet_Click(object sender, EventArgs e)
        {
            InitModeChanger();
            btnModeNet.Raised = true;

            Database.DB = IKK_data.SECRET.OnlineDatabase;
            Storage.TestConnection(ConnectionTestFinnished);
        }
        private void btnModeDebug_Click(object sender, EventArgs e)
        {
            InitModeChanger();
            btnModeDebug.Raised = true;

            Database.DB = "Server=localhost;User ID=ikk_user;Password=a12345678b;Database=ikk";
            Storage.TestConnection(ConnectionTestFinnished);
        }
        private void btnModeOffline_Click(object sender, EventArgs e)
        {
            InitModeChanger();
            btnModeOffline.Raised = true;

            btnModeNet.Enabled = true;
            btnModeDebug.Enabled = true;
            btnModeOffline.Enabled = true;

            btnLogin.Enabled = true;

            Storage.OfflineMode = true;
        }
        void ConnectionTestFinnished(bool connection)
        {
            Invoke(new Action(() => {
                btnModeNet.Enabled = true;
                btnModeDebug.Enabled = true;
                btnModeOffline.Enabled = true;
                if (!connection)
                {
                    btnModeOffline.PerformClick();
                    NotifManager.Send(new Notification("Csatlakozás kezelő", "Az adatbázis nem elérhető", "A program offline módba lépett.", new NotifAction[] { new NotifAction("ÚJRA", TryReconnect) }, true));
                }
                else
                {
                    tbEmail.Enabled = true;
                    tbPass.Enabled = true;
                    btnPass.Enabled = true;
                    btnReg.Enabled = true;
                    btnLogin.Enabled = true;
                    NotifManager.Dismiss("Csatlakozás kezelő");
                }
            }));
        }
        private void TryReconnect(Notification sender)
        {
            NotifManager.Dismiss("Csatlakozás kezelő");
            Database.DB = SECRET.OnlineDatabase;
            Storage.TestConnection((connection) => {
                Invoke(new Action(() => {
                    if (connection) NotifManager.Send(new Notification("Csatlakozás kezelő", "Van net!", "Jelentkezz ki és válts Internet módra!"));
                    else NotifManager.Send(new Notification("Csatlakozás kezelő", "Továbbra sem érhető el az adatbázis", "A program offline módban van.", new NotifAction[] { new NotifAction("ÚJRA", TryReconnect) }, true));
                }));
            });
        }
        #endregion
    }
}
