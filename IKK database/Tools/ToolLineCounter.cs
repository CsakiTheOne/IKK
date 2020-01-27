using IKK_notif;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_data.Tools
{
    [Serializable]
    class ToolLineCounter : Tool
    {
        public override string Name => "Sor számláló";
        public override string[] Description => new string[] { "Figyel, hogy hány sorosak a versszakjaid.", "Írj be egy számot! Hány soros egy versszak?" };
        public override string Category => "categoryLyre";

        Error errorSettings;
        Error errorLineFull;
        Error errorLineEmpty;

        public override void OnLoad(string content)
        {
            errorSettings = new Error("Sor számláló", "Eszköz rosszul van beállítva.");
            errorLineFull = new Error("Sor számláló", "Nem üres sor.");
            errorLineEmpty = new Error("Sor számláló", "Üres sor.");
        }

        public override void OnChange(string content)
        {
            int count;
            if (!int.TryParse(Settings, out count))
            {
                ErrorManager.Push(errorSettings);
                return;
            }
            ErrorManager.Solve(errorSettings);

            string[] lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int errors = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if ((i + 1) % (count + 1) == 0)
                {
                    if (lines[i].Length > 0)
                    {
                        errors++;
                        errorLineFull.Line = i + 1;
                        ErrorManager.Push(errorLineFull);
                    }
                }
                else
                {
                    if (lines[i].Length < 1)
                    {
                        errors++;
                        errorLineEmpty.Line = i + 1;
                        ErrorManager.Push(errorLineEmpty);
                    }
                }
            }

            if (errors == 0) ErrorManager.SolveTool("Sor számláló");
        }
    }
}
