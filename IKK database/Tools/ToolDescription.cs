﻿using System;
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
        public override string[] Description { get => new string[] { "Egy leírás a művedhez.", "Írd körül a műved röviden!" }; }
    }
}
