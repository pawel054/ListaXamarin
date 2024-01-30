using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Lista
{
    public static class JSON
    {
        static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "plik.json");
        public static void WriteToFile(List<TaskClass> list)
        {
            if (!File.Exists(path))
                File.WriteAllText(path, "");

            string json = JsonSerializer.Serialize(list);
            File.WriteAllText(path, json);
        }
        public static List<TaskClass> GetFromFile()
        {
            if (!File.Exists(path))
                File.WriteAllText(path, "");

            string text = File.ReadAllText(path);
            if (text != "")
                return JsonSerializer.Deserialize<List<TaskClass>>(text);

            return new List<TaskClass>();
        }
    }
}
