using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IKK_database
{
    public static class Database
    {
        public static string DB { get => "Server=localhost;User ID=root;Password=rootroot;Database=IKK"; }

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
            if (Database.GetData($"SELECT id FROM user WHERE email LIKE '{email}'").Rows.Count > 0)
            {
                return "Ez az e-mail már foglalt!";
            }
            // Add user to table
            string name = email.Remove(email.IndexOf('@'));
            string sql = $"INSERT INTO `user` (`id`, `email`, `password`, `name`) VALUES (NULL, '{email}', '{pass}', '{name}')";
            Database.GetData(sql);

            return "Sikeres regisztrálás! Jelentkezz be!";
        }
    }
}
