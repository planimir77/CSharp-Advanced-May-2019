using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Problem_5._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] fileArray = Directory.GetFiles(".", "*.*");
            var dictionary = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo(@".");
            FileInfo[] allFiles = directoryInfo.GetFiles();

            foreach (var item in allFiles)
            {
                var extension = item.Extension;
                var fileName = item.Name;
                double size = Math.Round(item.Length / 1024.0, 3);
                if (!dictionary.ContainsKey(extension))
                {
                    dictionary.Add(extension, new Dictionary<string, double>());
                }
                if (!dictionary[extension].ContainsKey(fileName))
                {
                    dictionary[extension].Add(fileName, size);
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";

            foreach (var (extension, value) in dictionary.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                File.AppendAllText(path, extension + Environment.NewLine);
                foreach (var (fileName, size) in value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(path, $"--{fileName} - {size}kb" + Environment.NewLine);
                }
            }

        }
    }
}
