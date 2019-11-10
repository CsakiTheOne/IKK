using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;

namespace IKK_data
{
    public static class Database
    {
        public static string DB { get => "Server=localhost;User ID=ikk_user;Password=a12345678b;Database=IKK"; }

        public static bool Test()
        {
            try
            {
                GetData("SELECT id FROM user;");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable GetData(string sql)
        {
            DataTable dataTable = new DataTable();

            using (var connection = new MySqlConnection(DB))
            {
                connection.Open();

                using (var command = new MySqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }

                connection.Close();
            }

            return dataTable;
        }

        public static string Register(string email, string pass)
        {
            if (pass.Length != 32) throw new Exception("A JELSZÓT TIKOSÍTANI KELL!");

            // No empty strings!
            if (email.Trim().Length < 1 || pass.Length < 1)
            {
                return "Írd be az e-mail címed és jelszavad!";
            }
            // Valid email check
            if (!email.Contains('@'))
            {
                return "Írj be egy helyes e-mail címet!";
            }
            // Check for duplicated email
            if (GetData($"SELECT id FROM user WHERE email LIKE '{email}'").Rows.Count > 0)
            {
                return "Ez az e-mail már foglalt!";
            }
            // Add user to table
            string name = email.Remove(email.IndexOf('@'));
            string sql = $"INSERT INTO `user` (`id`, `email`, `password`, `name`) VALUES (NULL, '{email}', '{pass}', '{name}')";
            GetData(sql);

            return "Sikeres regisztrálás! Jelentkezz be!";
        }

        public static string Login(string email, string pass)
        {
            // Check empty strings
            if (email.Trim().Length < 1)
            {
                return "Minden mezőt ki kell tölteni!";
            }
            // Search for user
            DataTable foundUser = GetData($"SELECT id, email, name, about FROM user WHERE email LIKE '{email}' AND password LIKE '{pass}'");
            if (foundUser == null || foundUser.Rows.Count < 1)
            {
                return "E-mail vagy jelszó hibás!";
            }

            return $"PROFILE;{foundUser.Rows[0].Field<string>("id")};{foundUser.Rows[0].Field<string>("email")};{foundUser.Rows[0].Field<string>("name")};{foundUser.Rows[0].Field<string>("about")}";
        }
    }
}
