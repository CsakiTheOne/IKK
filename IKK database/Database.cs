using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;
using System.Threading;

namespace IKK_data
{
    public static class Database
    {
        public static string DB { get; set; } = "Server=localhost;User ID=ikk_user;Password=a12345678b;Database=ikk";

        #region Helper
        public static bool Test()
        {
            try
            {
                GetData("SELECT id FROM user LIMIT 1;");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string ConvertToSqlDate(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
        #endregion

        [Obsolete]
        public static DataTable ExecuteSQL(string sql)
        {
            return GetData(sql);
        }

        static DataTable GetData(string sql)
        {
            try
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Profiles
        public static Profile GetProfileByID(int id)
        {
            Profile profile;

            DataTable dt = GetData($"SELECT id, email, name, about, lastlogin FROM user WHERE id = {id};");

            if (dt.Rows.Count < 1) return null;

            object[] cols = dt.Rows[0].ItemArray;
            profile = new Profile((int)cols[0], cols[1].ToString(), cols[2].ToString(), cols[3].ToString()) { LastLogin = DateTime.Parse(cols[4].ToString()) };

            return profile;
        }
        public static Profile GetProfileByName(string name)
        {
            Profile profile;

            DataTable dt = GetData($"SELECT id, email, name, about, lastlogin FROM user WHERE name LIKE '%{name}%';");

            if (dt.Rows.Count < 1) return null;

            object[] cols = dt.Rows[0].ItemArray;
            profile = new Profile((int)cols[0], cols[1].ToString(), cols[2].ToString(), cols[3].ToString()) { LastLogin = DateTime.Parse(cols[4].ToString()) };

            return profile;
        }
        public static void UpdateProfile(int id, string email, string name, string about)
        {
            GetData($"UPDATE user SET email = '{email}', name = '{name}', about = '{about}' WHERE id = {id};");
        }
        public static void UpdatePassword(int id, string newPass)
        {
            GetData($"UPDATE user SET password = '{newPass}' WHERE id = {id};");
        }
        #endregion

        #region Posts
        public static void CreatePost(int userID, string text, Project project)
        {
            if (project == null)
            {
                GetData($"INSERT INTO post (time, author, text) VALUES ('{Database.ConvertToSqlDate(DateTime.Now)}', '{userID}', '{text}');");
            }
            else
            {
                GetData($"INSERT INTO post (time, author, text, project) VALUES ('{Database.ConvertToSqlDate(DateTime.Now)}', '{userID}', '{text}', '{project.ID}');");
            }
        }
        public static List<PostData> GetPosts()
        {
            List<PostData> posts = new List<PostData>();

            DataTable dtPosts = GetData("SELECT post.*, user.name, project.title, project.type, " +
                "(SELECT COUNT(id) FROM post_like WHERE post_like.post = post.id) " +
                "FROM post LEFT JOIN project ON project.id = post.project " +
                "INNER JOIN user ON post.author = user.id ORDER BY post.time DESC");

            foreach (DataRow row in dtPosts.Rows)
            {
                posts.Add(
                    new PostData(row.ItemArray[0], row.ItemArray[1],
                    row.ItemArray[2], row.ItemArray[3], row.ItemArray[4],
                    row.ItemArray[5], row.ItemArray[6],
                    row.ItemArray[7], row.ItemArray[8])
                );
            }

            return posts;
        }
        public static bool GetLike(int postID, int userID)
        {
            return GetData($"SELECT id FROM post_like WHERE post = {postID} AND user = {userID}").Rows.Count > 0;
        }
        public static long GetLikeCount(int postID)
        {
            try
            {
                return (long)GetData($"SELECT COUNT(id) FROM post_like WHERE post = {postID}").Rows[0].ItemArray[0];
            }
            catch
            {
                return 0;
            }
        }
        public static void SetLike(int postID, int userID)
        {
            if (GetLike(postID, userID)) GetData($"DELETE FROM post_like WHERE post = {postID} AND user = {userID};");
            else GetData($"INSERT INTO post_like (post, user) VALUES ({postID}, {userID});");
        }
        #endregion

        #region Session management
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
            DataTable foundUser = GetData($"SELECT id, name, about FROM user WHERE email LIKE '{email}' AND password LIKE '{pass}'");
            if (foundUser == null || foundUser.Rows.Count < 1)
            {
                return "E-mail vagy jelszó hibás!";
            }

            object[] cols = foundUser.Rows[0].ItemArray;

            GetData($"UPDATE user SET lastlogin = '{ConvertToSqlDate(DateTime.Now)}' WHERE id = {cols[0]}");

            return $"PROFILE;{cols[0]};{email};{cols[1]};{cols[2]}";
        }

        public static void ForgotPassword(string email, string newPass)
        {
            GetData($"UPDATE user SET password = '{newPass}' WHERE email LIKE '{email}';");
        }
        #endregion

        #region Projects
        public static Project GetProject(int id)
        {
            DataTable dt = GetData($"SELECT project.*, tool.* FROM tool RIGHT JOIN project ON tool.project = project.id WHERE project.id = {id};");

            return MapProject(dt.Rows[0]);
        }
        public static int UploadProject(Project project)
        {
            GetData($"INSERT INTO project (author, title, content, type, createdate) VALUES ('{project.Author}', '{project.Title}', '{project.Content}', '{project.Label}', '{ConvertToSqlDate(project.CreateTime)}')");
            
            project.ID = (int)GetData($"SELECT id FROM project WHERE author = {project.Author} AND title LIKE '{project.Title}' AND content LIKE '{project.Content}'").Rows[0].ItemArray[0];

            foreach (Tool tool in project.Tools)
            {
                GetData($"INSERT INTO tool (project, name, settings) VALUES ('{project.ID}', '{tool.Name}', '{tool.Settings}')");
            }

            return project.ID;
        }
        public static List<Project> GetProjects(int userID)
        {
            List<Project> projects = new List<Project>();
            
            DataTable dt = GetData($"SELECT project.*, tool.* FROM tool RIGHT JOIN project ON tool.project = project.id WHERE project.author = {userID};");

            foreach (DataRow row in dt.Rows)
            {
                if (!projects.Any(r => r.ID == (int)row[0]))
                {
                    projects.Add(MapProject(row));
                }
                if (!row.IsNull("name"))
                {
                    projects.First(r => r.ID == (int)row[0]).Tools.Add(MapTool(row));
                }
            }

            return projects;
        }
        public static void DeleteProject(Project project)
        {
            GetData($"UPDATE post SET project = NULL WHERE post.project = {project.ID};");
            GetData($"DELETE FROM ikk.project WHERE id = {project.ID};");
        }
        static Tool MapTool(DataRow row)
        {
            Tool tool = ToolStorage.Tools.First(r => r.Name == row["name"].ToString());
            tool.ID = (int)row[6];
            tool.Settings = row["settings"].ToString();
            return tool;
        }
        static Project MapProject(DataRow row)
        {
            Project project = new Project(
                (int)row[0],
                (int)row["author"],
                row["title"].ToString(),
                row["content"].ToString(),
                row["type"].ToString(),
                DateTime.Parse(row["createdate"].ToString()),
                new List<Tool>(),
                null);
            return project;
        }
        #endregion
    }
}
