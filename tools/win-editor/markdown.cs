using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_editor
{
    class MarkdownTable
    {
        private string[] columns;
        private List<string[]> rows;

        public MarkdownTable(params string[] columns)
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
            sb.Append("| " + string.Join(" | ", columns)+ " |" + "\n");

            var fill = new List<string>();
            for (var i = 0; i < columns.Length; i++)
                fill.Add("---");

            sb.Append("| " + string.Join(" | ", fill) + " | \n");

            foreach (var r in this.rows)
                sb.Append("| " + string.Join(" | ", r) + "\n");
            return sb.ToString();
        }
    }

    class Markdown
    {
        public static string Link(string text, string url)
            => $"[{text}]({url})";

        // [1] [2] ...
        public static string LinksString(List<string> links)
        {
            var l = new List<string>();
            for (var i = 0; i < links.Count; i++)
                l.Add(Markdown.Link($"[{i + 1}]", links[i]));
           return string.Join(" ", l);
        }
    }
}
