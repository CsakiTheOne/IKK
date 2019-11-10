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
            if (tbPass.Text.Length < 1) new MsgBox("Bejelentkezés", "Minden mezőt ki kell tölteni!").ShowDialog();
            else
            {
                string result = Database.Login(tbEmail.Text, Secret.Encrypt(tbPass.Text));
                if (result.Contains("PROFILE"))
                {
                    string[] data = result.Split(';');
                    if (data[5].Length < 1) data[5] = DateTime.MinValue.ToString();
                    Storage.LocalUser = new Profile(int.Parse(data[1]), data[2], data[3], data[4], DateTime.Parse(data[5]));
                    Storage.MainContainer.SetView(new View1Main());
                }
                else new MsgBox("Bejelentkezés", result).ShowDialog();
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            new MsgBox(
                "Mit jelent az IKK?",
                "Integrált Költészeti Környezet.\n\rA program, ami beépített eszközökkel segít írni és költeni.\n\r" +
                "Honnan jött az ötlet? Integrált Fejlesztői Környezet (IDE) a programozók eszköze. A magyar költők ezköze pedig az IKK."
            ).ShowDialog();
        }
    }
}
