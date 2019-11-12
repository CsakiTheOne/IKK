using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_data
{
    [Serializable]
    public class Tool
    {
        public int ID { get; set; }
        public int Project { get; set; }
        public virtual string Name { get; protected set; }
        public string Settings { get; set; }
        /// <summary>
        /// Offline
        /// </summary>
        public virtual string Description { get; }
        /// <summary>
        /// Offline
        /// </summary>
        public virtual string Category { get => "categoryGeneral"; }

        public Tool() { }
        public Tool(string name, string settings)
        {
            Name = name;
            Settings = settings;
        }

        public virtual void OnLoad(string content) { }
        public virtual void OnChange(string content) { }
    }

    public static class ToolStorage
    {
        public static List<Tool> Tools
        {
            get => new List<Tool>() { new ToolDescription() };
        }
    }
}
