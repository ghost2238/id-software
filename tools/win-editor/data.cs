using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_editor
{
    class Audio
    {
        [JsonIgnoreAttribute]
        public DateTime editorDate => Data.fuzzyDateToDateTime(date);
        [JsonIgnoreAttribute]
        public string primarySource => audioSources.Count > 0 ? audioSources.First() : "";
        [JsonIgnoreAttribute]
        public string dateMarkdownLinks
        {
            get
            {
                string d = date;
                if (dateSources.Count > 0)
                    d += " " + Markdown.LinksString(dateSources);
                return d;
            }
        }

        public string title;
        public string date;

        public List<string> dateSources = new List<string>();
        public List<string> audioSources = new List<string>();
    }

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
                    d += " " + Markdown.LinksString(dateSources);
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
        [JsonIgnoreAttribute]
        public DateTime editorDate => Data.fuzzyDateToDateTime(date);
        [JsonIgnoreAttribute]
        public string primarySource => sources.Count > 0 ? sources.First() : "";

        public string title;
        public string publisher;
        public string date;
        public List<string> sources = new List<string>();
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
                // Only parse year
                y = Int32.Parse(fuzzyDate.Substring(0,4));
                return new DateTime(y, 1, 1);
            }
        }

        public readonly static string BaseDir = Directory.GetCurrentDirectory() + "../../../../../";
        public readonly static string MetaDir = BaseDir + "metadata/";
        public readonly static string OutputDir = BaseDir + "output/";
        public readonly static string TemplateDir = BaseDir + "templates/";

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
