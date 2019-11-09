using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_data
{
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
