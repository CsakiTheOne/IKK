using IKK_controls;
using IKK_database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DialogResult = System.Windows.Forms.DialogResult;

namespace IKK
{
    public static class Storage
    {
        public static string ProgramName { get => "IKK"; }
        public static string ProgramVer { get => "0.1a1"; }
        public static bool OfflineMode { get; set; }
        public static ViewContainer MainContainer { get; set; }
        public static Profile LocalUser { get; set; }

        public static bool TestConnection()
        {
            MsgBox msgTest = new MsgBox(
                "Offline mód",
                "A szerver nem elérhető vagy nincs internet.\n\rA program offline módban van.",
                new MsgBoxButton[] { new MsgBoxButton("Offline mód", true, DialogResult.OK), new MsgBoxButton("Újra", true, DialogResult.Retry) }
            );

            OfflineMode = !Database.Test();

            if (OfflineMode)
            {
                if (msgTest.ShowDialog() == DialogResult.Retry) return TestConnection();
                
                return false;
            }
            
            return true;
        }
    }

    public class Profile
    {
        public string Email { get; }
        public string Name { get; }
        public string About { get; }

        public Profile() { }

        public Profile(string email, string name, string about)
        {
            Email = email;
            Name = name;
            About = about;
        }

        public override string ToString()
        {
            return $"E-mail: {Email}\n\rNév: {Name}\n\rLeírás: {About}\n\r";
        }
    }
}
