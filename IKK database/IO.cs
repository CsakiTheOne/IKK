using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IKK_data
{
    public static class IO
    {
        public static string PROJECT_FILTER { get => "Összes fájl mutatása|*.*|Bináris fájl (csak ezzel olvasható)|*.ikk|Szöveg|*.txt|Markdown|*.md"; }
        public static string[] PROJECT_FORMATS { get => new string[] { "txt", "md", "ikk" }; }

        #region Open
        public static Project ProjectOpen(string fileName)
        {
            string format = fileName.Split('.').Last();
            if (!PROJECT_FORMATS.Contains(format)) throw new Exception($"A {format} nem támogatott formátum.");

            Project project = new Project();

            #region IKK
            if (format == "ikk")
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(fileName, FileMode.Open);
                project = (Project)bf.Deserialize(fs);
                fs.Close();
            }
            #endregion
            #region TXT
            else if (format == "txt")
            {
                List<string> lines = File.ReadAllLines(fileName).ToList();

                project.ID = int.Parse(lines[0].Split('|')[0]);
                project.Author = int.Parse(lines[0].Split('|')[1]);
                project.Title = lines[0].Split('|')[2];
                project.Label = lines[0].Split('|')[3];
                project.CreateTime = DateTime.Parse(lines[0].Split('|')[4]);

                int wi = 2;
                while (!lines[wi].Contains('█'))
                {
                    project.Content += lines[wi] + (wi == lines.IndexOf("█ eszközök") - 1 ? "" : Environment.NewLine);
                    wi++;
                }

                Tool toolNext;
                for (int i = lines.IndexOf("█ eszközök") + 1; i < lines.Count - 1; i += 2)
                {
                    toolNext = ToolStorage.Tools.First(r => r.Name == lines[i].Split(':')[0]);
                    toolNext.Settings = lines[i + 1].Replace("_", Environment.NewLine);
                    toolNext.ID = int.Parse(lines[i].Split(':')[1]);
                    project.Tools.Add(toolNext);
                }
            }
            #endregion
            #region MD
            else if (format == "md")
            {
                List<string> lines = File.ReadAllLines(fileName).ToList();

                project.Title = lines[0].Substring(2).Split(':')[0];
                project.ID = int.Parse(lines[0].Substring(2).Split(':')[1]);
                project.Author = int.Parse(lines[0].Substring(2).Split(':')[2]);
                project.Label = lines[1].Substring(7);

                int wi = 2;
                while (!lines[wi].Contains('#'))
                {
                    project.Content += lines[wi].Remove(lines[wi].Length - 2) + (wi == lines.IndexOf("# Eszközök") - 1 ? "" : Environment.NewLine);
                    wi++;
                }

                Tool toolNext;
                for (int i = lines.IndexOf("# Eszközök") + 1; i < lines.Count - 1; i += 2)
                {
                    toolNext = ToolStorage.Tools.First(r => r.Name == lines[i].Substring(4).Split(':')[0]);
                    toolNext.Settings = lines[i + 1].Replace("_", Environment.NewLine).Substring(3, lines[i + 1].Length - 6);
                    toolNext.ID = int.Parse(lines[i].Substring(4).Split(':')[1]);
                    project.Tools.Add(toolNext);
                }
            }
            #endregion

            return project;
        }
        #endregion

        #region Save
        public static void ProjectSave(Project project, string fileName)
        {
            string format = fileName.Split('.').Last();
            if (!PROJECT_FORMATS.Contains(format)) throw new Exception($"A {format} nem támogatott formátum.");

            #region IKK
            if (format == "ikk")
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(fileName, FileMode.Create);
                bf.Serialize(fs, project);
                fs.Close();
            }
            #endregion
            #region TXT
            else if (format == "txt")
            {
                List<string> lines = new List<string>();
                lines.Add($"{project.ID}|{project.Author}|{project.Title}|{project.Label}|{project.CreateTime}");
                lines.Add("");
                lines.Add(project.Content);
                lines.Add("█ eszközök");
                foreach (Tool tool in project.Tools)
                {
                    lines.Add(tool.Name+":"+tool.ID);
                    lines.Add(tool.Settings.Replace(Environment.NewLine, "_"));
                }

                File.WriteAllLines(fileName, lines);
            }
            #endregion
            #region MD
            else if (format == "md")
            {
                List<string> lines = new List<string>();
                lines.Add($"# {project.Title}:{project.ID}:{project.Author}");
                lines.Add($"###### {project.Label}");
                string[] content = project.Content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string c in content) lines.Add(c + "  ");
                lines.Add("# Eszközök");
                foreach (Tool tool in project.Tools)
                {
                    lines.Add($"### {tool.Name}:{tool.ID}");
                    lines.Add("```" + tool.Settings.Replace(Environment.NewLine, "_") + "```");
                }

                File.WriteAllLines(fileName, lines);
            }
            #endregion
        }
        #endregion

        #region Export
        public static void ProjectExport(Project project, string fileName)
        {
            List<string> lines = new List<string>();

            string nl = Environment.NewLine;
            lines.Add($"<html>{nl}<head>{nl}\t<meta charset=UTF-8>{nl}\t<meta name=\"viewport\" content=\"width=device -width, initial-scale=1.0\">");
            lines.Add($"\t<title>{project.Title}</title>");
            lines.Add($"</head>{nl}<body>{nl}\t<h1 id=\"ikk-title\">{project.Title}</h1>{nl}\t<h5 id=\"ikk-label\">{project.Label}</h5>{nl}\t<pre id=\"ikk-content\">");
            string[] content = project.Content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string c in content) lines.Add(c + "  ");
            lines.Add($"\t</pre>");
            foreach (Tool tool in project.Tools)
            {
                lines.Add($"\t<div class=\"ikk-tool\">{nl}\t\t<h3>{tool.Name}</h3>{nl}\t\t<p>{tool.Settings}</p>{nl}\t</div>");
            }
            lines.Add($"</body>{nl}</html>");

            File.WriteAllLines(fileName, lines);
        }
        #endregion
    }
}
