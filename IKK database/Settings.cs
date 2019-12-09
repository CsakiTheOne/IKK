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

        public static void SetIndex(string key, string value, int index)
        {
            new SettingsList(key)[index] = value;
        }

        public static string GetIndex(string key, string defaultValue, int index)
        {
            try
            {
                return new SettingsList(key)[index];
            }
            catch
            {
                return defaultValue;
            }
        }

        public static void Append(string key, string value)
        {
            Settings.Set(key, Settings.Get(key, "") + "|" + value);
        }

        public static bool Contains(string key, string value)
        {
            List<string> list = Settings.Get(key, "").Split('|').ToList();
            return list.Contains(value);
        }
    }

    class SettingsList
    {
        public string Key { get; set; }

        public SettingsList(string key)
        {
            Key = key;
        }

        public string this[int index]
        {
            get => Settings.Get(Key, "").Split('|')[index];
            set => Settings.Set(Key, Settings.Get(Key, "").Replace(this[index], value));
        }
    }
}
