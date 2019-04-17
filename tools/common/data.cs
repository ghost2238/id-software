using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Audio
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
        [JsonIgnoreAttribute]
        public string dateHTMLLinks
        {
            get
            {
                string d = date;
                if (dateSources.Count > 0)
                    d += " " + HTML.LinksString(dateSources);
                return d;
            }
        }

        public string title;
        public string date;

        public List<string> dateSources = new List<string>();
        public List<string> audioSources = new List<string>();
    }

    public class Video
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
        [JsonIgnoreAttribute]
        public string dateHTMLLinks
        {
            get
            {
                string d = date;
                if (dateSources.Count > 0)
                    d += " " + HTML.LinksString(dateSources);
                return d;
            }
        }

        [JsonIgnoreAttribute]
        public bool FileExists => filename != null && File.Exists(Diskfile);
        [JsonIgnoreAttribute]
        public string Diskfile => Config.VideoPath + "\\" + filename;
        [JsonIgnoreAttribute]
        public byte[] Diskbytes => File.ReadAllBytes(Diskfile);
        [JsonIgnoreAttribute]
        public bool ValidateHash => Data.StreamSHA1(Diskfile) == sha1;
        [JsonIgnoreAttribute]
        public bool HasJohnCarmack => tags.Contains("John Carmack");
        [JsonIgnoreAttribute]
        public bool HasJohnRomero => tags.Contains("John Romero");

        public string description;
        public string filename;
        public string sha1;
        public string title;
        public string date;
        public List<string> tags = new List<string>();
        public List<string> dateSources = new List<string>();
        public List<string> videoSources = new List<string>();
    }

    public class Article
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

    public class Source
    {
        [JsonIgnoreAttribute]
        public DateTime editorDate => Data.fuzzyDateToDateTime(year);

        public string game;
        public string url;
        public string year;
    }

    public static class DataExt
    {
        public static void Save(this List<Video> videos) => Data.SaveJson<Video>("videos.json", videos);
        public static void Save(this List<Audio> audio) => Data.SaveJson<Audio>("audio.json", audio);
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

        public readonly static string BaseDir = Config.BaseDirectory;
        public readonly static string MetaDir = BaseDir + "data/";
        public readonly static string OutputDir = BaseDir + "output/";
        public readonly static string TemplateDir = BaseDir + "templates/";

        public static List<Video> LoadVideos() => LoadJson<Video>("videos.json");

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

        // We use SHA1 for speed, we don't care about security.
        // SHA256 is pretty slow for all the video files
        public static string StreamSHA1(string file)
        {
            SHA1 hashAlg = new SHA1Managed();
            string hashString = string.Empty;
            using (var fs = new BufferedStream(File.OpenRead(file), 1200000))
            {
                SHA1Managed sha = new SHA1Managed();
                byte[] hash = sha.ComputeHash(fs);

                foreach (byte x in hash)
                    hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}
