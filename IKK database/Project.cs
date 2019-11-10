using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_data
{
    [Serializable]
    public class Project
    {
        public int ID { get; set; }
        public int Author { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Label { get; set; }
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// Offline
        /// </summary>
        public List<Tool> Tools { get; set; } = new List<Tool>();

        public Project() { }
        public Project(int id, int author, string title, string content, string label, DateTime createTime, List<Tool> tools)
        {
            ID = id;
            Author = author;
            Title = title;
            Content = content;
            Label = label;
            CreateTime = createTime;
            Tools = tools;
        }
    }
}
