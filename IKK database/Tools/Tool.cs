using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKK_data.Tools;

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
        public abstract string[] Description { get; } 
        /// <summary>
        /// Offline. Values can be: categoryGeneral, categoryLyre, categoryNarrative, categoryPacks
        /// </summary>
        public virtual string Category => "categoryGeneral";

        public virtual void OnLoad(string content) { }
        public virtual void OnChange(string content) { }
    }

    public static class ToolStorage
    {
        public static List<Tool> Tools
        {
            get => new List<Tool>() { new ToolDescription(), new ToolLineCounter(), new ToolRhyme() };
        }
    }
}
