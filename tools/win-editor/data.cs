using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_editor
{
    class Video
    {
        [JsonIgnoreAttribute]
        public DateTime editorDate => Data.fuzzyDateToDateTime(date);
        [JsonIgnoreAttribute]
        public string primarySource => videoSources.Count > 0 ? videoSources.First() : "";
        [JsonIgnoreAttribute]
        public string dateMarkdownLinks
        {
            get
            {
                string d = date;
                if (dateSources.Count > 0)
                {
                    var links = new List<string>();
                    for (var i = 0; i < dateSources.Count; i++)
                        links.Add(Markdown.Link($"[{i + 1}]", dateSources[i]));
                    d += " " + string.Join(" ", links);
                }
                return d;
            }
        }

        public string title;
        public string date;
        public List<string> dateSources = new List<string>();
        public List<string> videoSources = new List<string>();
    }

    class Article
    {
        string title;
        string date;
        List<string> sources;
    }

    public class Data
    {
        public static DateTime fuzzyDateToDateTime(string fuzzyDate)
        {
            int y = 0;
            int m = 1;
            int d = 1;

            if (string.IsNullOrEmpty(fuzzyDate))
                return DateTime.MinValue;

            if (fuzzyDate.Contains("-"))
            {
                var spl = fuzzyDate.Split('-');
                y = Int32.Parse(spl[0]);
                if (int.TryParse(spl[1], out int parsedM))
                    m = parsedM;
                if (spl.Length > 2 && int.TryParse(spl[2], out int parsedD))
                    d = parsedD;
                return new DateTime(y, m, d);
            }
            else
            {
                y = Int32.Parse(fuzzyDate);
                return new DateTime(y, 1, 1);
            }
        }

        public readonly static string BaseDir = Directory.GetCurrentDirectory() + "../../../../../";
        public readonly static string MetaDir = BaseDir + "metadata/";
        public readonly static string OutputDir = BaseDir + "output/";

        public static List<T> LoadJson<T>(string jsonFile)
        {
            var f = System.IO.File.ReadAllText(MetaDir + jsonFile);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(f);
        }

        public static void SaveJson<T>(string jsonFile, List<T> obj)
        {
            var text = Newtonsoft.Json.JsonConvert.SerializeObject(obj, Formatting.Indented);
            System.IO.File.WriteAllText(MetaDir + jsonFile, text);
        }

    }
}
