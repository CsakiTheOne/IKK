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

namespace IKK
{
    public partial class View2Feed : IKK_controls.View
    {
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
                flpPosts.Controls.Add(new IKK_controls.Post(pd));
            }
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            Database.CreatePost(Storage.LocalUser.ID, tbShare.Text);
            RefreshPosts();
        }
    }

    
}
