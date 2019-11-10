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
        public DateTime LastQuote { get; set; }

        public Profile() { }

        public Profile(int id, string email, string name, string about, DateTime lastQuote)
        {
            ID = id;
            Email = email;
            Name = name;
            About = about;
            LastQuote = lastQuote;
        }

        public override string ToString()
        {
            return $"ID: {ID}\n\rE-mail: {Email}\n\rNév: {Name}\n\rLeírás: {About}\n\rUtolsó idézet beküldés ideje: {LastQuote}";
        }
    }
}
