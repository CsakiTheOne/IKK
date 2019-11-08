using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKK_database;
using IKK_controls;
using System.Diagnostics;

namespace IKK
{
    public partial class View1Login : IKK_controls.View
    {
        public View1Login()
        {
            InitializeComponent();
            lblTitle.Text = Storage.ProgramName;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check empty strings
            if (tbEmail.Text.Trim().Length < 1 || tbPass.Text.Length < 1)
            {
                new MsgBox("Bejelentkezés", "Minden mezőt ki kell tölteni!").ShowDialog();
                return;
            }
            // Search for user
            DataTable foundUser = Database.GetData($"SELECT email, name, about FROM user WHERE email LIKE '{tbEmail.Text}' AND password LIKE '{Secret.Encrypt(tbPass.Text)}'");
            if (foundUser == null || foundUser.Rows.Count < 1)
            {
                new MsgBox("Bejelentkezés", "E-mail vagy jelszó hibás!").ShowDialog();
                return;
            }
            // Log in
            Storage.LocalUser = new Profile(foundUser.Rows[0].Field<string>("email"), foundUser.Rows[0].Field<string>("name"), foundUser.Rows[0].Field<string>("about"));
            ((ViewContainer)Parent).SetView(new View1Main());
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (tbPass.Text.Length < 6) new MsgBox("Regisztrálás", "A jelszó túl rövid! (twss xddd)").ShowDialog();
            else new MsgBox("Regisztrálás", Database.Register(tbEmail.Text, Secret.Encrypt(tbPass.Text))).ShowDialog();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            MsgBoxButton[] buttons = { new MsgBoxButton("Ok", true, DialogResult.OK), new MsgBoxButton(":(", false, DialogResult.Yes) };
            if (new MsgBox("This is so sad", "Alexa, play Despasito", buttons).ShowDialog() == DialogResult.Yes)
            {
                Process.Start("https://www.youtube.com/watch?v=kJQP7kiw5Fk");
            }
        }
    }
}
