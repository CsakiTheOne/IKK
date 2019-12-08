using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_data
{
    public static class Settings
    {
        public static void Set(string key, object value)
        {
            Properties.Settings.Default[key] = value;
            Properties.Settings.Default.Save();
        }

        public static T Get<T>(string key, T defaultValue)
        {
            if (Properties.Settings.Default[key] == null) return defaultValue;
            return (T)Properties.Settings.Default[key];
        }

        /// <summary>
        /// This method is not safe to use and can delete data.
        /// </summary>
        public static void Clear()
        {
            Properties.Settings.Default.Reset();
        }
    }
}
