using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_data
{
    public struct PostData
    {
        public int ID { get; private set; }
        public DateTime Time { get; private set; }
        public int Author { get; private set; }
        public string Text { get; private set; }
        public int Project { get; private set; }
        public string UserName { get; private set; }
        public string ProjectTitle { get; private set; }
        public string ProjectType { get; private set; }
        public int Likes { get; private set; }

        public PostData(object id, object time, object author, object text, object project, object userName, object projectTitle, object projectType, object likes)
        {
            ID = int.Parse(id.ToString());
            Time = (DateTime)time;
            Author = int.Parse(author.ToString());
            Text = text.ToString();
            Project = project.ToString() != "" ? int.Parse(project.ToString()) : -1;
            UserName = userName.ToString();
            ProjectTitle = projectTitle.ToString();
            ProjectType = projectType.ToString();
            Likes = int.Parse(likes.ToString());
        }
    }
}
