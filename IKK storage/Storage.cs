using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IKK_storage
{
    public static class Storage
    {
        public static string ProgramName { get => "IKK"; }
        public static string ProgramVer { get => "0.1a3"; }
        public static object MainContainer { get; set; }
        public static IKK_data.Profile LocalUser { get; set; }
        public static IKK_data.Project CurrentProject { get; set; }
        public static bool OfflineMode { get; set; }

        public static T GetMainContainer<T>()
        {
            return (T)MainContainer;
        }

        public static void TestConnection(Action<bool> OnTested)
        {
            new Thread(() => {
                OfflineMode = !IKK_data.Database.Test();
                OnTested(!OfflineMode);
            }).Start();
        }
    }
}
