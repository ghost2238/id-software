using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            //var videos = 
        }

        int videoIdx;
        int articleIdx;
        bool videosRadioVideos = true;


        List<Video> videos;

        private void frmEditor_Load(object sender, EventArgs e)
        {
            videos = Data.LoadJson<Video>("videos.json");
            videos = videos.OrderBy(x => x.editorDate).ToList();
            foreach (var v in videos)
                lstVideos.Items.Add(VideoToViewItem(v));
        }

        private ListViewItem VideoToViewItem(Video v)
            => new ListViewItem(new string[] { v.title, v.date, v.primarySource });

        private void lstVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVideos.FocusedItem == null)
                return;

            var i =  lstVideos.FocusedItem.Index;
            if (i == -1)
                return;
            selectVideo(i);
        }

        private void selectVideo(int idx)
        {
            videoIdx = idx;
            var c = videos[idx];
            txtVideoTitle.Text = c.title;
            txtVideoDate.Text = c.date;
            fillVideoSources();
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

        private void btnRemoveVideo_Click(object sender, EventArgs e)
        {
            var c = videos[videoIdx];
            videos.Remove(c);
            lstVideos.Items.RemoveAt(videoIdx);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.SaveJson("videos.json", videos.OrderBy(x => x.editorDate).ToList());
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
            var table = new MarkdownTable("Video", "Date");
            foreach (var v in videos)
            {
                table.Row(Markdown.Link(v.title, v.primarySource), v.dateMarkdownLinks);
            }
            System.IO.File.WriteAllText(Data.OutputDir + "/videos.md", table.ToString());
        }
    }
}
