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

namespace IKK
{
    public partial class ViewLogin : IKK_controls.View
    {
        public ViewLogin()
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
            ((ViewContainer)Parent).SetView(new ViewMain());
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            // No empty strings!
            if (tbEmail.Text.Trim().Length < 1 || tbPass.Text.Length < 1)
            {
                new MsgBox("Regisztrálás", "Írd be az e-mail címed és jelszavad!").ShowDialog();
                return;
            }
            // Valid email check
            if (!tbEmail.Text.Contains('@'))
            {
                new MsgBox("Regisztrálás", "Írj be egy helyes e-mail címet!").ShowDialog();
                return;
            }
            // Check for duplicated email
            if (Database.GetData($"SELECT id FROM user WHERE email LIKE '{tbEmail.Text}'").Rows.Count > 0)
            {
                new MsgBox("Regisztrálás", "Ez az e-mail már foglalt!").ShowDialog();
                return;
            }
            // Add user to table
            string sql = $"INSERT INTO `user` (`id`, `email`, `password`, `name`, `about`, `lastquote`, `projects`, `posts`) VALUES (NULL, '{tbEmail.Text}', '{Secret.Encrypt(tbPass.Text)}', {tbEmail.Text.Remove(tbEmail.Text.IndexOf('@'))}, NULL, NULL, NULL, NULL)";
            new MsgBox("Sikeres regisztrálás!", "Jelentkezz be!").ShowDialog();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            new MsgBox("This is so sad", "Alexa, play Despasito").ShowDialog();
        }
    }
}
