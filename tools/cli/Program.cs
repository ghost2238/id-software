using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cli
{
    class Program
    {
        static List<Article> articles;
        static List<Audio> audio;
        static List<Video> videos;
        static List<Source> source;
        static List<Event> events;


        static void CreateMainMarkdown()
        {
            var template = File.ReadAllText(Data.TemplateDir + "/github.md");

            var table = new MarkdownTable("Article / Interview", "Date", "Publisher", "Sources / Mirrors");
            foreach (var a in articles)
                table.Row(Markdown.Link(a.title, a.primarySource), a.date, a.publisher ?? "", Markdown.LinksString(a.sources));
            template = template.Replace("{ARTICLES_TABLE}", table.ToString());

            table = new MarkdownTable("Event", "Date", "Sources");
            foreach (var e in events)
                table.Row(e.linkOrTitle, e.date, e.sourceLinks);
            template = template.Replace("{EVENTS_TABLE}", table.ToString());

            table = new MarkdownTable("Video", "Date");
            foreach (var v in videos)
                table.Row(Markdown.Link(v.title, v.primarySource), v.dateMarkdownLinks);

            template = template.Replace("{VIDEO_TABLE}", table.ToString());

            table = new MarkdownTable("Audio", "Date");
            foreach (var a in audio)
                table.Row(Markdown.Link(a.title, a.primarySource), a.dateMarkdownLinks);
            template = template.Replace("{AUDIO_TABLE}", table.ToString());

            table = new MarkdownTable("Game", "Year of game release");
            foreach (var s in source)
                table.Row(Markdown.Link(s.game, s.url), s.year);
            template = template.Replace("{SOURCE_TABLE}", table.ToString());

            File.WriteAllText(Data.BaseDir + "/README.md", template);
        }

        static void CreateJohnCarmackMarkdown()
        {
            var template = File.ReadAllText(Data.TemplateDir + "/johncarmack.md");
            var carmack = videos.Where(x => x.HasJohnCarmack);
            void _table(string tag, IEnumerable<Video> videos)
                => template = Markdown.VideoTableTemplate(template, tag, videos);

            var quake = carmack.Where(x => x.title.Contains("MacWorld San Francisco 1999") || x.title.Contains("QuakeWorld Launch Event"));

            _table("{ALL_TABLE}", carmack);
            _table("{KEYNOTES_TABLE}", carmack.Where(x => x.title.Contains("Keynote")));
            _table("{QUAKECON_TABLE}", carmack.Where(x => x.title.ToLower().Contains("quakecon")));
            _table("{DOOM_TABLE}", carmack.Where(x => x.title.ToLower().Contains("doom")));
            _table("{QUAKE_TABLE}", quake);
            File.WriteAllText(Data.BaseDir + "/JohnCarmack.md", template);
        }

        static void CreateMiscMarkdown()
        {
            var template = File.ReadAllText(Data.TemplateDir + "/misc.md");
            void _table(string tag, IEnumerable<Video> videos)
                => template = Markdown.VideoTableTemplate(template, tag, videos);

            _table("{TOM}", videos.Where(x => x.tags.Contains("Tom Hall")));
            _table("{TIM}", videos.Where(x => x.tags.Contains("Tim Willits")));
            _table("{CLOUD}", videos.Where(x => x.tags.Contains("Kevin Cloud")));
            _table("{TODD}", videos.Where(x => x.tags.Contains("Todd Hollenshead")));

            File.WriteAllText(Data.BaseDir + "/Misc.md", template);
        }

        static void CreateJohnRomeroMarkdown()
        {
            var template = File.ReadAllText(Data.TemplateDir + "/johnromero.md");
            var romero = videos.Where(x => x.HasJohnRomero);

            void _table(string tag, IEnumerable<Video> videos)
                => template = Markdown.VideoTableTemplate(template, tag, videos);

            _table("{ALL_TABLE}", romero);
            _table("{DOOM_TABLE}", romero.Where(x => x.title.ToLower().Contains("doom")));

            File.WriteAllText(Data.BaseDir + "/JohnRomero.md", template);
        }

        static void Main(string[] args)
        {
            Config.Load();
            articles = Data.LoadJson<Article>("articles.json");
            audio = Data.LoadJson<Audio>("audio.json");
            videos = Data.LoadJson<Video>("videos.json");
            source = Data.LoadJson<Source>("source.json");
            events = Data.LoadJson<Event>("events.json");

            if (args[0] == "markdown")
            {
                CreateMainMarkdown();
                CreateJohnCarmackMarkdown();
                CreateJohnRomeroMarkdown();
                CreateMiscMarkdown();
            }


        }
    }
}
