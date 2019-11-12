using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_data
{
    [Serializable]
    public class ToolDescription : Tool
    {
        public override string Name { get => "Leírás"; }
        public override string Description { get => "Egy leírás a művedhez."; }
        public override string Category { get => "categoryGeneral"; }

        public override void OnChange(string content)
        {
            // Do nothing
        }

        public override void OnLoad(string content)
        {
            // Do nothing
        }
    }
}
