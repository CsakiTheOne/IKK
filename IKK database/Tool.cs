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
        public int ID { get; }
        public int Project { get; set; }
        public string Name { get; set; }
        public string Settings { get; set; }
        /// <summary>
        /// Offline
        /// </summary>
        public string Description { get; set; }

        public abstract void OnLoad(string content);
        public abstract void OnChange(string content);
    }
}
