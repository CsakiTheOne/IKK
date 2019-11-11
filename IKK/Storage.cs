using IKK_controls;
using IKK_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DialogResult = System.Windows.Forms.DialogResult;

namespace IKK
{
    public static class Storage
    {
        public static string ProgramName { get => "IKK"; }
        public static string ProgramVer { get => "0.1a1"; }
        public static ViewContainer MainContainer { get; set; }
        public static Profile LocalUser { get; set; }
        public static Project CurrentProject { get; set; } = new Project();
        public static bool OfflineMode { get; private set; }

        public static void TestConnection(Action<bool> OnTested, bool showDialog = true)
        {
            new Thread(() => {

                if (showDialog)
                {
                    if (!Database.Test())
                    {
                        OfflineMode = true;
                        while (ShowConnectionErrorDialog() == DialogResult.Retry && OfflineMode)
                            OfflineMode = !Database.Test();
                    }
                    else
                    {
                        OfflineMode = false;
                    }
                }
                else
                {
                    OfflineMode = !Database.Test();
                }

                OnTested(!OfflineMode);
                
            }).Start();
        }
        static DialogResult ShowConnectionErrorDialog()
        {
            return MsgBox.Show("Offline mód",
                    "A szerver nem elérhető vagy nincs internet.\n\rA program offline módban van.",
                    new MsgBox.MsgBoxButton[] { new MsgBox.MsgBoxButton("Offline mód", true, DialogResult.OK), new MsgBox.MsgBoxButton("Újra", true, DialogResult.Retry) });
        }
    }
}
