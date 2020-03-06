using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKK_storage;
using IKK_data;

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

            btnOpen.Visible = PostData.Project > -1;

            btnLike.Text = Database.GetLikeCount(PostData.ID) + " ♥";
            btnLike.Raised = Database.GetLike(PostData.ID, Storage.LocalUser.ID);
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            btnLike.Enabled = false;

            Database.SetLike(PostData.ID, Storage.LocalUser.ID);

            btnLike.Text = Database.GetLikeCount(PostData.ID) + " ♥";
            btnLike.Raised = Database.GetLike(PostData.ID, Storage.LocalUser.ID);

            btnLike.Enabled = true;
        }

        private void Post_Load(object sender, EventArgs e)
        {
            UpdateTheme();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Project projectToRead = Database.GetProject(PostData.Project);
            new FormReader(projectToRead).Show();
        }
    }
}
