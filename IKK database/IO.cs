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
        public static string PROJECT_FILTER { get => "Szöveg|*.txt|Markdown|*.md|Weboldal|*.html|Bináris fájl (csak ezzel olvasható)|*.ikk|Összes fájl mutatása|*.*"; }
        public static string[] PROJECT_FORMATS { get => new string[] { /*"txt", "md", "html",*/ "ikk" }; }

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

            return project;
        }

        public static void ProjectSave(Project project, string fileName)
        {
            string format = fileName.Split('.').Last();
            if (!PROJECT_FORMATS.Contains(format)) throw new Exception($"A {format} nem támogatott formátum.");

            if (format == "ikk")
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(new FileStream(fileName, FileMode.Create), project);
            }
        }
    }
}
