using IKK_controls;
using IKK_data;
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
        public static Project CurrentProject { get; set; } = new Project();

        public static bool TestConnection()
        {
            OfflineMode = !Database.Test();

            if (OfflineMode)
            {
                if (
                    MsgBox.Show(
                    "Offline mód",
                    "A szerver nem elérhető vagy nincs internet.\n\rA program offline módban van.",
                    new MsgBox.MsgBoxButton[] { new MsgBox.MsgBoxButton("Offline mód", true, DialogResult.OK), new MsgBox.MsgBoxButton("Újra", true, DialogResult.Retry) })
                    == DialogResult.Retry
                )
                {
                    return TestConnection();
                }
                
                return false;
            }
            
            return true;
        }
    }
}
