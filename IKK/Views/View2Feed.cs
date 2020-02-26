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
using IKK_storage;
using IKK_controls;

namespace IKK
{
    public partial class View2Feed : IKK_controls.View
    {
        Project projectToShare = null;

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

            List<PostData> pds = Database.GetPosts();

            foreach (PostData pd in pds)
            {
                flpPosts.Controls.Add(new Post(pd));
            }
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            Database.CreatePost(Storage.LocalUser.ID, tbShare.Text, projectToShare);
            RefreshPosts();
        }

        private void btnShareProject_Click(object sender, EventArgs e)
        {
            if (projectToShare == null)
            {
                List<Project> onlineProjects = Database.GetProjects(Storage.LocalUser.ID);
                projectToShare = MsgBox.ShowProjectSelectorDialog(onlineProjects);
                if (projectToShare != null)
                {
                    btnShareProject.Text = "Mű elvetése";
                    lblProjectToShare.Text = projectToShare.Title;
                }
            }
            else
            {
                projectToShare = null;
                btnShareProject.Text = "Mű csatolása";
                lblProjectToShare.Text = "-";
            }
        }
    }

    
}
