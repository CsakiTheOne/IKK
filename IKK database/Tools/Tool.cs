using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_data
{
    [Serializable]
    public abstract class Tool
    {
        public int ID { get; set; }
        public int Project { get; set; }
        public abstract string Name { get; }
        public string Settings { get; set; }
        /// <summary>
        /// Offline
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// Offline
        /// </summary>
        public abstract string Category { get; }

        public abstract void OnLoad(string content);
        public abstract void OnChange(string content);
    }

    public static class ToolStorage
    {
        public static List<Tool> Tools
        {
            get => new List<Tool>() { new ToolDescription() };
        }
    }
}
