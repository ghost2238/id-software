using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_editor
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        int videoIdx;
        int articleIdx;
        bool videosRadioVideos = true;

        List<Article> articles;
        List<Audio> audio;
        List<Video> videos;


        private void frmEditor_Load(object sender, EventArgs e)
        {
            articles = Data.LoadJson<Article>("articles.json");
            audio = Data.LoadJson<Audio>("audio.json");
            videos = Data.LoadJson<Video>("videos.json");
            
            RefreshTables();
        }

        private void RefreshTables()
        {
            articles = articles.OrderBy(x => x.editorDate).ToList();
            audio = audio.OrderBy(x => x.editorDate).ToList();
            videos = videos.OrderBy(x => x.editorDate).ToList();
            lstVideos.Items.Clear();
            lstArticles.Items.Clear();
            foreach (var v in videos)
                lstVideos.Items.Add(VideoToViewItem(v));
            foreach (var a in articles)
                lstArticles.Items.Add(ArticleToViewItem(a));
        }

        private ListViewItem ArticleToViewItem(Article a)
            => new ListViewItem(new string[] { a.title, a.date, a.publisher, a.primarySource });

        private ListViewItem VideoToViewItem(Video v)
            => new ListViewItem(new string[] { v.title, v.date, v.primarySource });

        private void lstArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstArticles.FocusedItem == null)
                return;

            var i = lstArticles.FocusedItem.Index;
            if (i == -1)
                return;
            selectArticle(i);
        }

        private void lstVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVideos.FocusedItem == null)
                return;

            var i =  lstVideos.FocusedItem.Index;
            if (i == -1)
                return;
            selectVideo(i);
        }

        private void selectArticle(int idx)
        {
            articleIdx = idx;
            var a = articles[idx];
            txtArtTitle.Text = a.title;
            txtArtDate.Text = a.date;
            txtArtPublisher.Text = a.publisher;
            fillArticleSources();
        }

        private void selectVideo(int idx)
        {
            videoIdx = idx;
            var c = videos[idx];
            txtVideoTitle.Text = c.title;
            txtVideoDate.Text = c.date;
            fillVideoSources();
        }

        private void fillArticleSources()
        {
            var a = articles[articleIdx];
            lstArticleSources.Items.Clear();
            foreach (var s in a.sources)
                lstArticleSources.Items.Add(s);
        }

        private void fillVideoSources()
        {
            var c = videos[videoIdx];
            lstSources.Items.Clear();
            if (c.videoSources == null)
                c.videoSources = new List<string>();
            if (c.dateSources == null)
                c.dateSources = new List<string>();

            if (videosRadioVideos)
            {
                foreach (var s in c.videoSources)
                    lstSources.Items.Add(s);
            }
            else
            {
                foreach (var s in c.dateSources)
                    lstSources.Items.Add(s);
            }
        }


        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            var n = new Article
            {
                title = "New article",
                date = "2000-01-01"
            };
            articles.Add(n);
            var lv = ArticleToViewItem(n);
            lstArticles.Items.Add(lv);
            lstArticles.SelectedIndices.Clear();
            lstArticles.Items[lstArticles.Items.Count - 1].Selected = true;
            selectArticle(lstArticles.Items.Count - 1);
        }

        private void btnRemoveArticle_Click(object sender, EventArgs e)
        {
            var a = articles[articleIdx];
            articles.Remove(a);
            lstArticles.Items.RemoveAt(articleIdx);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var n = new Video
            {
                title = "New video",
                date = "2000-01-01"
            };
            videos.Add(n);
            var lv = VideoToViewItem(n);
            lstVideos.Items.Add(lv);
            lstVideos.SelectedIndices.Clear();
            lstVideos.Items[lstVideos.Items.Count-1].Selected = true;
            selectVideo(lstVideos.Items.Count - 1);
        }

        private void rdbVideoVideos_CheckedChanged(object sender, EventArgs e)
        {
            videosRadioVideos = true;
            fillVideoSources();
        }

        private void rdbVideoDate_CheckedChanged(object sender, EventArgs e)
        {
            videosRadioVideos = false;
            fillVideoSources();
        }

        private void txtVideoTitle_TextChanged(object sender, EventArgs e)
        {
            var c = videos[videoIdx];
            c.title = txtVideoTitle.Text;
            lstVideos.Items[videoIdx].SubItems[0].Text = txtVideoTitle.Text;
        }

        private void txtVideoDate_TextChanged(object sender, EventArgs e)
        {
            var c = videos[videoIdx];
            c.date = txtVideoDate.Text;
            lstVideos.Items[videoIdx].SubItems[1].Text = txtVideoDate.Text;
        }
        private void txtArtPublisher_TextChanged(object sender, EventArgs e)
        {
            var a = articles[articleIdx];
            a.publisher = txtArtPublisher.Text;
            lstArticles.Items[articleIdx].SubItems[2].Text = txtArtPublisher.Text;
        }

        private void txtArtTitle_TextChanged(object sender, EventArgs e)
        {
            var a = articles[articleIdx];
            a.title = txtArtTitle.Text;
            lstArticles.Items[articleIdx].SubItems[0].Text = txtArtTitle.Text;
        }

        private void txtArtDate_TextChanged(object sender, EventArgs e)
        {
            var a = articles[articleIdx];
            a.date = txtArtDate.Text;
            lstArticles.Items[articleIdx].SubItems[1].Text = txtArtDate.Text;
        }

        private void btnRemoveVideo_Click(object sender, EventArgs e)
        {
            var c = videos[videoIdx];
            videos.Remove(c);
            lstVideos.Items.RemoveAt(videoIdx);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.SaveJson("articles.json", articles.OrderBy(x => x.editorDate).ToList());
            Data.SaveJson("audio.json", audio.OrderBy(x => x.editorDate).ToList());
            Data.SaveJson("videos.json", videos.OrderBy(x => x.editorDate).ToList());
            RefreshTables();
        }

        private void btnArtSourceAdd_Click(object sender, EventArgs e)
        {
            var a = articles[articleIdx];
            lstArticleSources.Items.Add(txtArtSource.Text);
            a.sources.Add(txtArtSource.Text);
        }

        private void btnArtSourceRemove_Click(object sender, EventArgs e)
        {
            lstArticleSources.Items.Remove(lstArticleSources.SelectedItem);
            var a = articles[articleIdx];
            a.sources.Remove((string)lstArticleSources.SelectedItem);
        }

        private void btnVidSourceAdd_Click(object sender, EventArgs e)
        {
            var c = videos[videoIdx];
            lstSources.Items.Add(txtSource.Text);
            if (videosRadioVideos)
                c.videoSources.Add(txtSource.Text);
            else
                c.dateSources.Add(txtSource.Text);
        }

        private void btnVidSourceRemove_Click(object sender, EventArgs e)
        {
            var c = videos[videoIdx];
            if (videosRadioVideos)
                c.videoSources.Remove((string)lstSources.SelectedItem);
            else
                c.dateSources.Remove((string)lstSources.SelectedItem);
            lstSources.Items.Remove(lstSources.SelectedItem);
        }

        private void createMarkdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var template = File.ReadAllText(Data.TemplateDir + "/github.md");

            var table = new MarkdownTable("Article / Interview", "Date", "Publisher", "Sources / Mirrors");
            foreach (var a in articles)
                table.Row(Markdown.Link(a.title, a.primarySource), a.date, a.publisher ?? "", Markdown.LinksString(a.sources));
            template = template.Replace("{ARTICLES_TABLE}", table.ToString());

            table = new MarkdownTable("Video", "Date");
            foreach (var v in videos)
                table.Row(Markdown.Link(v.title, v.primarySource), v.dateMarkdownLinks);

            template = template.Replace("{VIDEO_TABLE}", table.ToString());

            table = new MarkdownTable("Audio", "Date");
            foreach (var a in audio)
                table.Row(Markdown.Link(a.title, a.primarySource), a.dateMarkdownLinks);
            template = template.Replace("{AUDIO_TABLE}", table.ToString());

            File.WriteAllText(Data.BaseDir + "/README.md", template);
        }

        private void lstArticleSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtArtSource.Text = (string)lstArticleSources.SelectedItem;
        }
    }
}
