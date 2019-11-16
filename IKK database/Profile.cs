using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_data
{
    public class Profile
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string About { get; set; }

        public Profile() { }

        public Profile(int id, string email, string name, string about)
        {
            ID = id;
            Email = email;
            Name = name;
            About = about;
        }
    }
}
