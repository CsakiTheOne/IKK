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
    }
}
