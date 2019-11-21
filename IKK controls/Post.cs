using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKK_controls
{
    public partial class Post : UserControl, IThemable
    {
        public PostData PostData { get; private set; }

        public Post()
        {
            InitializeComponent();
            Theme.ThemeChanged += UpdateTheme;
        }

        public Post(PostData data)
        {
            InitializeComponent();
            PostData = data;
            RefreshPost();
            Theme.ThemeChanged += UpdateTheme;
        }

        public void UpdateTheme()
        {
            ForeColor = Theme.ColorText;
            btnLike.UpdateTheme();
            btnOpen.UpdateTheme();
        }

        public void RefreshPost()
        {
            lblTime.Text = PostData.Time.ToString();
            lblText.Text = PostData.Text;
            lblUsername.Text = PostData.UserName;
            // TODO project
            btnLike.Text = PostData.Likes + " ♥";
            btnLike.Raised = IKK_data.Database.GetData($"SELECT id FROM post_like WHERE post = {PostData.ID} AND user = {PostData.SeeAsUser}").Rows.Count > 0;
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            btnLike.Enabled = false;

            if (btnLike.Raised) IKK_data.Database.GetData($"DELETE FROM post_like WHERE post = {PostData.ID} AND user = {PostData.SeeAsUser};");
            else IKK_data.Database.GetData($"INSERT INTO post_like (post, user) VALUES ({PostData.ID}, {PostData.SeeAsUser});");

            btnLike.Text = IKK_data.Database.GetData($"SELECT COUNT(id) FROM post_like WHERE post = {PostData.ID}").Rows[0].ItemArray[0].ToString() + " ♥";
            btnLike.Raised = IKK_data.Database.GetData($"SELECT id FROM post_like WHERE post = {PostData.ID} AND user = {PostData.SeeAsUser}").Rows.Count > 0;

            UpdateTheme();

            btnLike.Enabled = true;
        }

        private void Post_Load(object sender, EventArgs e)
        {
            UpdateTheme();
        }
    }

    public struct PostData
    {
        public int ID { get; private set; }
        public DateTime Time { get; private set; }
        public string Text { get; private set; }
        public int Author { get; private set; }
        public string UserName { get; private set; }
        public int Project { get; private set; }
        public string ProjectTitle { get; private set; }
        public string ProjectType { get; private set; }
        public int Likes { get; private set; }
        public int SeeAsUser { get; private set; }

        public PostData(object id, object time, object text, object author, object userName, object project, object projectTitle, object projectType, object likes, int seeAsUser)
        {
            ID = int.Parse(id.ToString());
            Time = (DateTime)time;
            Text = text.ToString();
            Author = int.Parse(author.ToString());
            UserName = userName.ToString();
            Project = project.ToString() != "" ? int.Parse(project.ToString()) : -1;
            ProjectTitle = projectTitle.ToString();
            ProjectType = projectType.ToString();
            Likes = int.Parse(likes.ToString());
            SeeAsUser = seeAsUser;
        }
    }
}
