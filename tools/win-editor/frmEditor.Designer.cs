namespace win_editor
{
    partial class frmEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstArticles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRemoveVideo = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lstSources = new System.Windows.Forms.ListBox();
            this.rdbVideoDate = new System.Windows.Forms.RadioButton();
            this.rdbVideoVideos = new System.Windows.Forms.RadioButton();
            this.txtVideoDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVideoTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstVideos = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVidSourceRemove = new System.Windows.Forms.Button();
            this.btnVidSourceAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMarkdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveArticle = new System.Windows.Forms.Button();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.txtArtDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnArtSourceRemove = new System.Windows.Forms.Button();
            this.btnArtSourceAdd = new System.Windows.Forms.Button();
            this.txtArtSource = new System.Windows.Forms.TextBox();
            this.lstArticleSources = new System.Windows.Forms.ListBox();
            this.txtArtPublisher = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(726, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtArtPublisher);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnRemoveArticle);
            this.tabPage1.Controls.Add(this.btnAddArticle);
            this.tabPage1.Controls.Add(this.txtArtDate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtArtTitle);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lstArticles);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(718, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Articles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstArticles
            // 
            this.lstArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstArticles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader3});
            this.lstArticles.FullRowSelect = true;
            this.lstArticles.GridLines = true;
            this.lstArticles.Location = new System.Drawing.Point(6, 6);
            this.lstArticles.Name = "lstArticles";
            this.lstArticles.Size = new System.Drawing.Size(706, 204);
            this.lstArticles.TabIndex = 0;
            this.lstArticles.UseCompatibleStateImageBehavior = false;
            this.lstArticles.View = System.Windows.Forms.View.Details;
            this.lstArticles.SelectedIndexChanged += new System.EventHandler(this.lstArticles_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Article";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Primary source";
            this.columnHeader3.Width = 300;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRemoveVideo);
            this.tabPage3.Controls.Add(this.btnAddVideo);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.txtVideoDate);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtVideoTitle);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lstVideos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(718, 357);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Videos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRemoveVideo
            // 
            this.btnRemoveVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveVideo.Location = new System.Drawing.Point(87, 216);
            this.btnRemoveVideo.Name = "btnRemoveVideo";
            this.btnRemoveVideo.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveVideo.TabIndex = 9;
            this.btnRemoveVideo.Text = "Remove";
            this.btnRemoveVideo.UseVisualStyleBackColor = true;
            this.btnRemoveVideo.Click += new System.EventHandler(this.btnRemoveVideo_Click);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddVideo.Location = new System.Drawing.Point(6, 216);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(75, 23);
            this.btnAddVideo.TabIndex = 8;
            this.btnAddVideo.Text = "Add";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            this.btnAddVideo.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnVidSourceRemove);
            this.groupBox1.Controls.Add(this.btnVidSourceAdd);
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Controls.Add(this.lstSources);
            this.groupBox1.Controls.Add(this.rdbVideoDate);
            this.groupBox1.Controls.Add(this.rdbVideoVideos);
            this.groupBox1.Location = new System.Drawing.Point(345, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 135);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sources";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(94, 103);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(267, 20);
            this.txtSource.TabIndex = 11;
            // 
            // lstSources
            // 
            this.lstSources.FormattingEnabled = true;
            this.lstSources.Location = new System.Drawing.Point(94, 11);
            this.lstSources.Name = "lstSources";
            this.lstSources.Size = new System.Drawing.Size(267, 56);
            this.lstSources.TabIndex = 9;
            // 
            // rdbVideoDate
            // 
            this.rdbVideoDate.AutoSize = true;
            this.rdbVideoDate.Location = new System.Drawing.Point(16, 49);
            this.rdbVideoDate.Name = "rdbVideoDate";
            this.rdbVideoDate.Size = new System.Drawing.Size(48, 17);
            this.rdbVideoDate.TabIndex = 8;
            this.rdbVideoDate.Text = "Date";
            this.rdbVideoDate.UseVisualStyleBackColor = true;
            this.rdbVideoDate.CheckedChanged += new System.EventHandler(this.rdbVideoDate_CheckedChanged);
            // 
            // rdbVideoVideos
            // 
            this.rdbVideoVideos.AutoSize = true;
            this.rdbVideoVideos.Checked = true;
            this.rdbVideoVideos.Location = new System.Drawing.Point(16, 26);
            this.rdbVideoVideos.Name = "rdbVideoVideos";
            this.rdbVideoVideos.Size = new System.Drawing.Size(52, 17);
            this.rdbVideoVideos.TabIndex = 7;
            this.rdbVideoVideos.TabStop = true;
            this.rdbVideoVideos.Text = "Video";
            this.rdbVideoVideos.UseVisualStyleBackColor = true;
            this.rdbVideoVideos.CheckedChanged += new System.EventHandler(this.rdbVideoVideos_CheckedChanged);
            // 
            // txtVideoDate
            // 
            this.txtVideoDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVideoDate.Location = new System.Drawing.Point(41, 293);
            this.txtVideoDate.Name = "txtVideoDate";
            this.txtVideoDate.Size = new System.Drawing.Size(98, 20);
            this.txtVideoDate.TabIndex = 5;
            this.txtVideoDate.TextChanged += new System.EventHandler(this.txtVideoDate_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // txtVideoTitle
            // 
            this.txtVideoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVideoTitle.Location = new System.Drawing.Point(41, 262);
            this.txtVideoTitle.Name = "txtVideoTitle";
            this.txtVideoTitle.Size = new System.Drawing.Size(243, 20);
            this.txtVideoTitle.TabIndex = 3;
            this.txtVideoTitle.TextChanged += new System.EventHandler(this.txtVideoTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // lstVideos
            // 
            this.lstVideos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVideos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstVideos.FullRowSelect = true;
            this.lstVideos.GridLines = true;
            this.lstVideos.Location = new System.Drawing.Point(6, 6);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.Size = new System.Drawing.Size(706, 204);
            this.lstVideos.TabIndex = 1;
            this.lstVideos.UseCompatibleStateImageBehavior = false;
            this.lstVideos.View = System.Windows.Forms.View.Details;
            this.lstVideos.SelectedIndexChanged += new System.EventHandler(this.lstVideos_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Video";
            this.columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Primary source";
            this.columnHeader6.Width = 400;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnVidSourceRemove
            // 
            this.btnVidSourceRemove.Location = new System.Drawing.Point(175, 74);
            this.btnVidSourceRemove.Name = "btnVidSourceRemove";
            this.btnVidSourceRemove.Size = new System.Drawing.Size(75, 23);
            this.btnVidSourceRemove.TabIndex = 14;
            this.btnVidSourceRemove.Text = "Remove";
            this.btnVidSourceRemove.UseVisualStyleBackColor = true;
            this.btnVidSourceRemove.Click += new System.EventHandler(this.btnVidSourceRemove_Click);
            // 
            // btnVidSourceAdd
            // 
            this.btnVidSourceAdd.Location = new System.Drawing.Point(94, 74);
            this.btnVidSourceAdd.Name = "btnVidSourceAdd";
            this.btnVidSourceAdd.Size = new System.Drawing.Size(75, 23);
            this.btnVidSourceAdd.TabIndex = 13;
            this.btnVidSourceAdd.Text = "Add";
            this.btnVidSourceAdd.UseVisualStyleBackColor = true;
            this.btnVidSourceAdd.Click += new System.EventHandler(this.btnVidSourceAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Source";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMarkdownToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // createMarkdownToolStripMenuItem
            // 
            this.createMarkdownToolStripMenuItem.Name = "createMarkdownToolStripMenuItem";
            this.createMarkdownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createMarkdownToolStripMenuItem.Text = "Create markdown";
            this.createMarkdownToolStripMenuItem.Click += new System.EventHandler(this.createMarkdownToolStripMenuItem_Click);
            // 
            // btnRemoveArticle
            // 
            this.btnRemoveArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveArticle.Location = new System.Drawing.Point(87, 216);
            this.btnRemoveArticle.Name = "btnRemoveArticle";
            this.btnRemoveArticle.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveArticle.TabIndex = 15;
            this.btnRemoveArticle.Text = "Remove";
            this.btnRemoveArticle.UseVisualStyleBackColor = true;
            this.btnRemoveArticle.Click += new System.EventHandler(this.btnRemoveArticle_Click);
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddArticle.Location = new System.Drawing.Point(6, 216);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(75, 23);
            this.btnAddArticle.TabIndex = 14;
            this.btnAddArticle.Text = "Add";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // txtArtDate
            // 
            this.txtArtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtArtDate.Location = new System.Drawing.Point(62, 291);
            this.txtArtDate.Name = "txtArtDate";
            this.txtArtDate.Size = new System.Drawing.Size(98, 20);
            this.txtArtDate.TabIndex = 13;
            this.txtArtDate.TextChanged += new System.EventHandler(this.txtArtDate_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date";
            // 
            // txtArtTitle
            // 
            this.txtArtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtArtTitle.Location = new System.Drawing.Point(39, 260);
            this.txtArtTitle.Name = "txtArtTitle";
            this.txtArtTitle.Size = new System.Drawing.Size(300, 20);
            this.txtArtTitle.TabIndex = 11;
            this.txtArtTitle.TextChanged += new System.EventHandler(this.txtArtTitle_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnArtSourceRemove);
            this.groupBox2.Controls.Add(this.btnArtSourceAdd);
            this.groupBox2.Controls.Add(this.txtArtSource);
            this.groupBox2.Controls.Add(this.lstArticleSources);
            this.groupBox2.Location = new System.Drawing.Point(345, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 135);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sources";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Source";
            // 
            // btnArtSourceRemove
            // 
            this.btnArtSourceRemove.Location = new System.Drawing.Point(87, 73);
            this.btnArtSourceRemove.Name = "btnArtSourceRemove";
            this.btnArtSourceRemove.Size = new System.Drawing.Size(75, 23);
            this.btnArtSourceRemove.TabIndex = 14;
            this.btnArtSourceRemove.Text = "Remove";
            this.btnArtSourceRemove.UseVisualStyleBackColor = true;
            this.btnArtSourceRemove.Click += new System.EventHandler(this.btnArtSourceRemove_Click);
            // 
            // btnArtSourceAdd
            // 
            this.btnArtSourceAdd.Location = new System.Drawing.Point(6, 73);
            this.btnArtSourceAdd.Name = "btnArtSourceAdd";
            this.btnArtSourceAdd.Size = new System.Drawing.Size(75, 23);
            this.btnArtSourceAdd.TabIndex = 13;
            this.btnArtSourceAdd.Text = "Add";
            this.btnArtSourceAdd.UseVisualStyleBackColor = true;
            this.btnArtSourceAdd.Click += new System.EventHandler(this.btnArtSourceAdd_Click);
            // 
            // txtArtSource
            // 
            this.txtArtSource.Location = new System.Drawing.Point(53, 102);
            this.txtArtSource.Name = "txtArtSource";
            this.txtArtSource.Size = new System.Drawing.Size(308, 20);
            this.txtArtSource.TabIndex = 11;
            // 
            // lstArticleSources
            // 
            this.lstArticleSources.FormattingEnabled = true;
            this.lstArticleSources.Location = new System.Drawing.Point(6, 24);
            this.lstArticleSources.Name = "lstArticleSources";
            this.lstArticleSources.Size = new System.Drawing.Size(355, 43);
            this.lstArticleSources.TabIndex = 9;
            this.lstArticleSources.SelectedIndexChanged += new System.EventHandler(this.lstArticleSources_SelectedIndexChanged);
            // 
            // txtArtPublisher
            // 
            this.txtArtPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtArtPublisher.Location = new System.Drawing.Point(62, 318);
            this.txtArtPublisher.Name = "txtArtPublisher";
            this.txtArtPublisher.Size = new System.Drawing.Size(161, 20);
            this.txtArtPublisher.TabIndex = 18;
            this.txtArtPublisher.TextChanged += new System.EventHandler(this.txtArtPublisher_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Publisher";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Publisher";
            this.columnHeader7.Width = 120;
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 428);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEditor";
            this.Text = "id Software data editor";
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lstArticles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtVideoTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstVideos;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.ListBox lstSources;
        private System.Windows.Forms.RadioButton rdbVideoDate;
        private System.Windows.Forms.RadioButton rdbVideoVideos;
        private System.Windows.Forms.TextBox txtVideoDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveVideo;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVidSourceRemove;
        private System.Windows.Forms.Button btnVidSourceAdd;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMarkdownToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnArtSourceRemove;
        private System.Windows.Forms.Button btnArtSourceAdd;
        private System.Windows.Forms.TextBox txtArtSource;
        private System.Windows.Forms.ListBox lstArticleSources;
        private System.Windows.Forms.Button btnRemoveArticle;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.TextBox txtArtDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArtPublisher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

