using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_data
{
    public class Profile
    {
        public int ID { get; }
        public string Email { get; }
        public string Name { get; }
        public string About { get; }

        public Profile() { }

        public Profile(int id, string email, string name, string about)
        {
            ID = id;
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
