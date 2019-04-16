using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_editor
{
    class HTML
    {
        public static string Link(string text, string url)
            => $"<a href=\"{url}\">{text}</a>";

        // [1] [2] ...
        public static string LinksString(List<string> links)
        {
            var l = new List<string>();
            for (var i = 0; i < links.Count; i++)
                l.Add(HTML.Link($"[{i + 1}]", links[i]));
            return string.Join(" ", l);
        }
    }

    class HTMLTableColumn
    {
        public string text;
        public string style;

        public HTMLTableColumn(string text, string style="") { this.text = text; this.style = style; }
    }

    class HTMLTable
    {
        private HTMLTableColumn[] columns;
        private List<string[]> rows;

        public HTMLTable(params HTMLTableColumn[] columns)
        {
            this.columns = columns;
            this.rows = new List<string[]>();
        }

        public void Row(params string[] row)
        {
            this.rows.Add(row);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("<table>\n");

            sb.Append("  <thead>\n");
            sb.Append("    <tr>\n");
            foreach(var c in this.columns)
                sb.Append($"      <th style=\"{c.style}\">{c.text}</th>\n");
            sb.Append("    </tr>\n");
            sb.Append("  </thead>\n");
            sb.Append("  <tbody>\n");
            foreach (var r in this.rows)
            {
                sb.Append("<tr>\n");
                foreach(var cell in r)
                    sb.Append($"<td>{cell}</td>\n");
                sb.Append("</tr>\n");
            }
            sb.Append("  </tbody>\n");
            sb.Append("</table>\n");

            return sb.ToString();
        }

    }
}
