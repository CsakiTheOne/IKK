using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK
{
    [Serializable]
    public class Project
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Label { get; set; }
        public DateTime CreateTime { get; }

        public Project() { }
        public Project(string title, string content, string label, DateTime createTime)
        {
            Title = title;
            Content = content;
            Label = label;
            CreateTime = createTime;
        }
    }
}
