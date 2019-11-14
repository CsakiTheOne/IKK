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
        public static bool OfflineMode { get; set; }

        public static void TestConnection(Action<bool> OnTested)
        {
            new Thread(() => {
                OfflineMode = !Database.Test();
                OnTested(!OfflineMode);
            }).Start();
        }
    }
}
