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
            if (tbPass.Text.Length < 1) new MsgBox("Regisztrálás", "Minden mezőt ki kell tölteni!").ShowDialog();
            else
            {
                string result = Database.Login(tbEmail.Text, Secret.Encrypt(tbPass.Text));
                if (result.Contains("PROFILE"))
                {
                    Storage.LocalUser = new Profile(int.Parse(result.Split(';')[1]), result.Split(';')[2], result.Split(';')[3], result.Split(';')[4]);
                    Storage.MainContainer.SetView(new View1Main());
                }
                else new MsgBox("Bejelentkezés", result);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (tbPass.Text.Length < 1) new MsgBox("Regisztrálás", "Minden mezőt ki kell tölteni!").ShowDialog();
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
