using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKK_data;

namespace IKK
{
    public partial class View2Feed : IKK_controls.View
    {
        List<IKK_controls.PostData> posts = new List<IKK_controls.PostData>();

        public View2Feed()
        {
            InitializeComponent();
            if (!Storage.OfflineMode) RefreshPosts();
        }

        private void nmiRefresh_Click(object sender, EventArgs e)
        {
            RefreshPosts();
        }

        void RefreshPosts()
        {
            flpPosts.Controls.Clear();

            string sql = "SELECT `post`.`id`, `post`.`time`, `post`.`text`, `post`.`author`, "+
                "`user`.`name`, `post`.`project`, `project`.`title`, `project`.`type`, "+
                "(SELECT COUNT(`id`) FROM `post_like` WHERE `post_like`.`post` = `post`.`id`) "+
                "FROM `post` LEFT JOIN `project` ON `project`.`id` = `post`.`project` "+
                "INNER JOIN `user` ON `post`.`author` = `user`.`id`ORDER BY `post`.`time` DESC";
            DataTable dtPosts = Database.GetData(sql);

            foreach (DataRow row in dtPosts.Rows)
            {
                posts.Add(
                    new IKK_controls.PostData(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2],
                    row.ItemArray[3], row.ItemArray[4], row.ItemArray[5], row.ItemArray[6],
                    row.ItemArray[7], row.ItemArray[8], Storage.LocalUser.ID)
                );
                flpPosts.Controls.Add(new IKK_controls.Post(posts.Last()));
            }
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            Database.GetData($"INSERT INTO `post` (`time`, `author`, `text`) VALUES ('{Database.ConvertToSqlDate(DateTime.Now)}', '{Storage.LocalUser.ID}', '{tbShare.Text}');");
            RefreshPosts();
        }
    }

    
}
