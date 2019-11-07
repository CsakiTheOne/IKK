using IKK_controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK
{
    public static class Storage
    {
        public static string ProgramName { get => "IKK"; }
        public static string ProgramVer { get => "0.1a1"; }
        public static bool OfflineMode;
        public static ViewContainer MainContainer { get; set; }
        public static Profile LocalUser { get; set; }
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
