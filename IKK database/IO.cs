using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_data
{
    public static class IO
    {
        public static string PROJECT_FILTER { get => "Szöveg|*.txt|Markdown|*.md|Weboldal|*.html|Bináris fájl (csak ezzel a programmal megnyitható)|*.ikk"; }

        public static Project ProjectOpen(string fileName)
        {
            string format = fileName.Split('.').Last();
            Project project = new Project();

            // TODO

            return project;
        }

        public static void ProjectSave(Project project, string fileName)
        {
            string format = fileName.Split('.').Last();

            // TODO
        }
    }
}
