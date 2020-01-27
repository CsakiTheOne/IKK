using IKK_notif;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_data.Tools
{
    [Serializable]
    class ToolRhyme : Tool
    {
        public override string Name => "Rímek";
        public override string[] Description => new string[] { "Figyeli a sorok rímelését.", "Írj be egy rímképletet! Pl.: ABAB, AXAX, AABBCC" };
        public override string Category => "categoryLyre";

        Error errorSettings;
        Error errorLineCount;

        public override void OnLoad(string content)
        {
            errorSettings = new Error("Rímek", "Eszköz rosszul van beállítva.");
            errorLineCount = new Error("Rímek", "A sorok száma nem illik a megadott beállításhoz.");
        }

        public override void OnChange(string content)
        {
            if (Settings == null)
            {
                ErrorManager.Push(errorSettings);
                return;
            }
            ErrorManager.Solve(errorSettings);

            int verseCount = 0;
            List<string> lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i] == null || lines[i].Length < 2) break;
                verseCount++;
            }
            if (Settings.Length < verseCount)
            {
                errorLineCount.Line = verseCount;
                ErrorManager.Push(errorLineCount);
                return;
            }
            ErrorManager.Solve(errorLineCount.Message);

            lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            lines = FilterVowels(lines);

            Dictionary<char, List<string>> lineGroups = new Dictionary<char, List<string>>();

            for (int i = 0; i < lines.Count; i++)
            {

                if (lineGroups == null || lineGroups.ContainsKey(Settings[i % verseCount]))
                {
                    lineGroups[Settings[i % verseCount]].Add(lines[i]);
                }
                else
                {
                    lineGroups.Add(Settings[i % verseCount], new List<string>() { lines[i] });
                }
            }

            bool foundError = false;
            foreach (KeyValuePair<char, List<string>> group in lineGroups)
            {
                if (group.Value.Count > 1 && group.Key != 'X')
                {
                    for (int i = 1; i < group.Value.Count; i++)
                    {
                        if (!IsRhymes(group.Value[0], group.Value[i]))
                        {
                            foundError = true;
                            ErrorManager.Push(new Error("Rímek", $"\'{group.Key}\' jelű rím csoportban hiba van."));
                        }
                    }
                }
            }
            if (!foundError) ErrorManager.SolveTool("Rímek");
        }

        List<string> FilterVowels(List<string> oldLines)
        {
            List<string> lines = new List<string>();

            foreach (string oldLine in oldLines)
            {
                string line = "";
                for (int i = 0; i < oldLine.Length; i++)
                {
                    if ("aáeéiíoóöőuúüű".Contains(oldLine.ToLower()[i])) line += oldLine.ToLower()[i];
                }
                lines.Add(line);
            }

            return lines;
        }

        bool IsRhymes(string line1, string line2)
        {
            if (line1 == null || line1.Length < 1) return true;
            if (line2 == null || line2.Length < 1) return true;
            return line1.Last() == line2.Last();
        }
    }
}
