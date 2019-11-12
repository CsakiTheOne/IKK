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
        public static string PROJECT_FILTER { get => "Összes fájl mutatása|*.*|Bináris fájl (csak ezzel olvasható)|*.ikk|Szöveg|*.txt|Markdown|*.md|Weboldal|*.html"; }
        public static string[] PROJECT_FORMATS { get => new string[] { "txt", /*"md", "html",*/ "ikk" }; }

        #region Open
        public static Project ProjectOpen(string fileName)
        {
            string format = fileName.Split('.').Last();
            if (!PROJECT_FORMATS.Contains(format)) throw new Exception($"A {format} nem támogatott formátum.");

            Project project = new Project();

            if (format == "ikk")
            {
                BinaryFormatter bf = new BinaryFormatter();
                project = (Project)bf.Deserialize(new FileStream(fileName, FileMode.Open));
            }
            else if (format == "txt")
            {
                List<string> lines = File.ReadAllLines(fileName).ToList();

                project.Title = lines[0].Split('|')[0];
                project.Label = lines[0].Split('|')[1];

                int wi = 2;
                while (!lines[wi].Contains('█'))
                {
                    project.Content += lines[wi] + (wi == lines.IndexOf("█ eszközök") - 1 ? "" : Environment.NewLine);
                    wi++;
                }

                for (int i = lines.IndexOf("█ eszközök") + 1; i < lines.Count - 1; i += 2)
                {
                    project.Tools.Add(new Tool(lines[i], lines[i + 1].Replace("▄", Environment.NewLine)));
                }
            }

            return project;
        }
        #endregion

        #region Save
        public static void ProjectSave(Project project, string fileName)
        {
            string format = fileName.Split('.').Last();
            if (!PROJECT_FORMATS.Contains(format)) throw new Exception($"A {format} nem támogatott formátum.");

            if (format == "ikk")
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(new FileStream(fileName, FileMode.Create), project);
            }
            else if (format == "txt")
            {
                List<string> lines = new List<string>();
                lines.Add($"{project.Title}|{project.Label}");
                lines.Add("");
                lines.Add(project.Content);
                lines.Add("█ eszközök");
                foreach (Tool tool in project.Tools)
                {
                    lines.Add(tool.Name);
                    lines.Add(tool.Settings.Replace(Environment.NewLine, "▄"));
                }

                File.WriteAllLines(fileName, lines);
            }
        }
        #endregion
    }
}
