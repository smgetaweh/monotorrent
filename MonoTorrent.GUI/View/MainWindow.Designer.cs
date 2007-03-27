namespace MonoTorrent.GUI.View
{
    partial class MainWindow
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.addATorrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createATorrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteATorrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStatusbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.torrentsView = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colSize = new System.Windows.Forms.ColumnHeader();
            this.colProgress = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.colSeeds = new System.Windows.Forms.ColumnHeader();
            this.colLeeches = new System.Windows.Forms.ColumnHeader();
            this.colDownSpeed = new System.Windows.Forms.ColumnHeader();
            this.colUpSpeed = new System.Windows.Forms.ColumnHeader();
            this.colDownloaded = new System.Windows.Forms.ColumnHeader();
            this.colUploaded = new System.Windows.Forms.ColumnHeader();
            this.colRatio = new System.Windows.Forms.ColumnHeader();
            this.detailsView = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.generalPanel = new System.Windows.Forms.GroupBox();
            this.trackerPanel = new System.Windows.Forms.GroupBox();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.tabPeers = new System.Windows.Forms.TabPage();
            this.tabPieces = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MaintoolStrip = new System.Windows.Forms.ToolStrip();
            this.AddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CreateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StartToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PauseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OptionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DownStripButton = new System.Windows.Forms.ToolStripButton();
            this.UpStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuBar.SuspendLayout();
            this.detailsView.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.MaintoolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.Control;
            this.menuBar.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuAbout});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(0);
            this.menuBar.Size = new System.Drawing.Size(692, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addATorrentToolStripMenuItem,
            this.createATorrentToolStripMenuItem,
            this.deleteATorrentToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(35, 24);
            this.menuFile.Text = "File";
            // 
            // addATorrentToolStripMenuItem
            // 
            this.addATorrentToolStripMenuItem.Name = "addATorrentToolStripMenuItem";
            this.addATorrentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addATorrentToolStripMenuItem.Text = "Add a torrent";
            this.addATorrentToolStripMenuItem.Click += new System.EventHandler(this.addATorrentToolStripMenuItem_Click);
            // 
            // createATorrentToolStripMenuItem
            // 
            this.createATorrentToolStripMenuItem.Name = "createATorrentToolStripMenuItem";
            this.createATorrentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.createATorrentToolStripMenuItem.Text = "Create a torrent";
            this.createATorrentToolStripMenuItem.Click += new System.EventHandler(this.createATorrentToolStripMenuItem_Click);
            // 
            // deleteATorrentToolStripMenuItem
            // 
            this.deleteATorrentToolStripMenuItem.Name = "deleteATorrentToolStripMenuItem";
            this.deleteATorrentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteATorrentToolStripMenuItem.Text = "Delete a torrent";
            this.deleteATorrentToolStripMenuItem.Click += new System.EventHandler(this.deleteATorrentToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.toolStripSeparator3,
            this.showToolbarToolStripMenuItem,
            this.showDetailToolStripMenuItem,
            this.showStatusbarToolStripMenuItem,
            this.toolStripSeparator4,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.toolStripSeparator5,
            this.upToolStripMenuItem,
            this.downToolStripMenuItem});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(51, 24);
            this.menuEdit.Text = "Option";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.optionToolStripMenuItem.Text = "Options";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // showToolbarToolStripMenuItem
            // 
            this.showToolbarToolStripMenuItem.Checked = true;
            this.showToolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showToolbarToolStripMenuItem.Name = "showToolbarToolStripMenuItem";
            this.showToolbarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showToolbarToolStripMenuItem.Text = "Show Toolbar";
            this.showToolbarToolStripMenuItem.Click += new System.EventHandler(this.showToolbarToolStripMenuItem_Click);
            // 
            // showDetailToolStripMenuItem
            // 
            this.showDetailToolStripMenuItem.Checked = true;
            this.showDetailToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showDetailToolStripMenuItem.Name = "showDetailToolStripMenuItem";
            this.showDetailToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showDetailToolStripMenuItem.Text = "Show Detail";
            this.showDetailToolStripMenuItem.Click += new System.EventHandler(this.showDetailToolStripMenuItem_Click);
            // 
            // showStatusbarToolStripMenuItem
            // 
            this.showStatusbarToolStripMenuItem.Checked = true;
            this.showStatusbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showStatusbarToolStripMenuItem.Name = "showStatusbarToolStripMenuItem";
            this.showStatusbarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showStatusbarToolStripMenuItem.Text = "Show Statusbar";
            this.showStatusbarToolStripMenuItem.Click += new System.EventHandler(this.showStatusbarToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(158, 6);
            // 
            // upToolStripMenuItem
            // 
            this.upToolStripMenuItem.Name = "upToolStripMenuItem";
            this.upToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.upToolStripMenuItem.Text = "Up";
            this.upToolStripMenuItem.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.downToolStripMenuItem.Text = "Down";
            this.downToolStripMenuItem.Click += new System.EventHandler(this.downToolStripMenuItem_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(40, 24);
            this.menuAbout.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 444);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(692, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip";
            // 
            // torrentsView
            // 
            this.torrentsView.AllowColumnReorder = true;
            this.torrentsView.AllowDrop = true;
            this.torrentsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize,
            this.colProgress,
            this.colStatus,
            this.colSeeds,
            this.colLeeches,
            this.colDownSpeed,
            this.colUpSpeed,
            this.colDownloaded,
            this.colUploaded,
            this.colRatio});
            this.torrentsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.torrentsView.Location = new System.Drawing.Point(0, 0);
            this.torrentsView.Margin = new System.Windows.Forms.Padding(5);
            this.torrentsView.Name = "torrentsView";
            this.torrentsView.Size = new System.Drawing.Size(692, 190);
            this.torrentsView.TabIndex = 0;
            this.torrentsView.UseCompatibleStateImageBehavior = false;
            this.torrentsView.View = System.Windows.Forms.View.Details;
            this.torrentsView.DragEnter += new System.Windows.Forms.DragEventHandler(this.TorrentsView_DragEnter);
            this.torrentsView.DragDrop += new System.Windows.Forms.DragEventHandler(this.TorrentsView_DragDrop);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            // 
            // colProgress
            // 
            this.colProgress.Text = "Progress";
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // colSeeds
            // 
            this.colSeeds.Text = "Seeds";
            // 
            // colLeeches
            // 
            this.colLeeches.Text = "Leechs";
            // 
            // colDownSpeed
            // 
            this.colDownSpeed.Text = "Download Speed";
            // 
            // colUpSpeed
            // 
            this.colUpSpeed.Text = "Upload Speed";
            // 
            // colDownloaded
            // 
            this.colDownloaded.Text = "Downloaded";
            // 
            // colUploaded
            // 
            this.colUploaded.Text = "Uploaded";
            // 
            // colRatio
            // 
            this.colRatio.Text = "Ratio";
            // 
            // detailsView
            // 
            this.detailsView.Controls.Add(this.tabGeneral);
            this.detailsView.Controls.Add(this.tabDetails);
            this.detailsView.Controls.Add(this.tabPeers);
            this.detailsView.Controls.Add(this.tabPieces);
            this.detailsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsView.Location = new System.Drawing.Point(0, 0);
            this.detailsView.Margin = new System.Windows.Forms.Padding(0);
            this.detailsView.Name = "detailsView";
            this.detailsView.Padding = new System.Drawing.Point(0, 0);
            this.detailsView.SelectedIndex = 0;
            this.detailsView.Size = new System.Drawing.Size(692, 190);
            this.detailsView.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.AutoScroll = true;
            this.tabGeneral.Controls.Add(this.generalPanel);
            this.tabGeneral.Controls.Add(this.trackerPanel);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(684, 164);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // generalPanel
            // 
            this.generalPanel.Location = new System.Drawing.Point(15, 158);
            this.generalPanel.Margin = new System.Windows.Forms.Padding(10);
            this.generalPanel.MinimumSize = new System.Drawing.Size(450, 0);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(642, 134);
            this.generalPanel.TabIndex = 0;
            this.generalPanel.TabStop = false;
            this.generalPanel.Text = "General";
            // 
            // trackerPanel
            // 
            this.trackerPanel.Location = new System.Drawing.Point(15, 10);
            this.trackerPanel.Margin = new System.Windows.Forms.Padding(10);
            this.trackerPanel.MinimumSize = new System.Drawing.Size(450, 0);
            this.trackerPanel.Name = "trackerPanel";
            this.trackerPanel.Size = new System.Drawing.Size(642, 134);
            this.trackerPanel.TabIndex = 0;
            this.trackerPanel.TabStop = false;
            this.trackerPanel.Text = "Tracker";
            // 
            // tabDetails
            // 
            this.tabDetails.AutoScroll = true;
            this.tabDetails.Location = new System.Drawing.Point(4, 22);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetails.Size = new System.Drawing.Size(684, 164);
            this.tabDetails.TabIndex = 1;
            this.tabDetails.Text = "Details";
            this.tabDetails.UseVisualStyleBackColor = true;
            // 
            // tabPeers
            // 
            this.tabPeers.AutoScroll = true;
            this.tabPeers.Location = new System.Drawing.Point(4, 22);
            this.tabPeers.Name = "tabPeers";
            this.tabPeers.Size = new System.Drawing.Size(684, 164);
            this.tabPeers.TabIndex = 2;
            this.tabPeers.Text = "Peers";
            this.tabPeers.UseVisualStyleBackColor = true;
            // 
            // tabPieces
            // 
            this.tabPieces.AutoScroll = true;
            this.tabPieces.Location = new System.Drawing.Point(4, 22);
            this.tabPieces.Name = "tabPieces";
            this.tabPieces.Size = new System.Drawing.Size(684, 164);
            this.tabPieces.TabIndex = 3;
            this.tabPieces.Text = "Pieces";
            this.tabPieces.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.torrentsView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.detailsView);
            this.splitContainer1.Size = new System.Drawing.Size(692, 384);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 3;
            // 
            // MaintoolStrip
            // 
            this.MaintoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripButton,
            this.DelToolStripButton,
            this.CreateToolStripButton,
            this.toolStripSeparator1,
            this.StartToolStripButton,
            this.PauseToolStripButton,
            this.StopToolStripButton,
            this.toolStripSeparator2,
            this.OptionToolStripButton,
            this.DownStripButton,
            this.UpStripButton});
            this.MaintoolStrip.Location = new System.Drawing.Point(0, 24);
            this.MaintoolStrip.Name = "MaintoolStrip";
            this.MaintoolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MaintoolStrip.Size = new System.Drawing.Size(692, 36);
            this.MaintoolStrip.Stretch = true;
            this.MaintoolStrip.TabIndex = 2;
            this.MaintoolStrip.Text = "toolStrip1";
            // 
            // AddToolStripButton
            // 
            this.AddToolStripButton.Image = global::MonoTorrent.GUI.Properties.Resources.list_add;
            this.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddToolStripButton.Name = "AddToolStripButton";
            this.AddToolStripButton.Size = new System.Drawing.Size(30, 33);
            this.AddToolStripButton.Text = "Add";
            this.AddToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddToolStripButton.Click += new System.EventHandler(this.AddToolStripButton_Click);
            // 
            // DelToolStripButton
            // 
            this.DelToolStripButton.Image = global::MonoTorrent.GUI.Properties.Resources.list_remove;
            this.DelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelToolStripButton.Name = "DelToolStripButton";
            this.DelToolStripButton.Size = new System.Drawing.Size(26, 33);
            this.DelToolStripButton.Text = "Del";
            this.DelToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DelToolStripButton.Click += new System.EventHandler(this.DelToolStripButton_Click);
            // 
            // CreateToolStripButton
            // 
            this.CreateToolStripButton.Image = global::MonoTorrent.GUI.Properties.Resources.document_new;
            this.CreateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateToolStripButton.Name = "CreateToolStripButton";
            this.CreateToolStripButton.Size = new System.Drawing.Size(44, 33);
            this.CreateToolStripButton.Text = "Create";
            this.CreateToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CreateToolStripButton.Click += new System.EventHandler(this.CreateToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // StartToolStripButton
            // 
            this.StartToolStripButton.Image = global::MonoTorrent.GUI.Properties.Resources.media_playback_start;
            this.StartToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartToolStripButton.Name = "StartToolStripButton";
            this.StartToolStripButton.Size = new System.Drawing.Size(35, 33);
            this.StartToolStripButton.Text = "Start";
            this.StartToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StartToolStripButton.Click += new System.EventHandler(this.StartToolStripButton_Click);
            // 
            // PauseToolStripButton
            // 
            this.PauseToolStripButton.Image = global::MonoTorrent.GUI.Properties.Resources.media_playback_pause;
            this.PauseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PauseToolStripButton.Name = "PauseToolStripButton";
            this.PauseToolStripButton.Size = new System.Drawing.Size(40, 33);
            this.PauseToolStripButton.Text = "Pause";
            this.PauseToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PauseToolStripButton.Click += new System.EventHandler(this.PauseToolStripButton_Click);
            // 
            // StopToolStripButton
            // 
            this.StopToolStripButton.Image = global::MonoTorrent.GUI.Properties.Resources.media_playback_stop;
            this.StopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopToolStripButton.Name = "StopToolStripButton";
            this.StopToolStripButton.Size = new System.Drawing.Size(33, 33);
            this.StopToolStripButton.Text = "Stop";
            this.StopToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StopToolStripButton.Click += new System.EventHandler(this.StopToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // OptionToolStripButton
            // 
            this.OptionToolStripButton.Image = global::MonoTorrent.GUI.Properties.Resources.preferences_system;
            this.OptionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptionToolStripButton.Name = "OptionToolStripButton";
            this.OptionToolStripButton.Size = new System.Drawing.Size(43, 33);
            this.OptionToolStripButton.Text = "Option";
            this.OptionToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OptionToolStripButton.Click += new System.EventHandler(this.OptionToolStripButton_Click);
            // 
            // DownStripButton
            // 
            this.DownStripButton.Image = global::MonoTorrent.GUI.Properties.Resources.go_down;
            this.DownStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DownStripButton.Name = "DownStripButton";
            this.DownStripButton.Size = new System.Drawing.Size(38, 33);
            this.DownStripButton.Text = "Down";
            this.DownStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // UpStripButton
            // 
            this.UpStripButton.Image = global::MonoTorrent.GUI.Properties.Resources.go_up;
            this.UpStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpStripButton.Name = "UpStripButton";
            this.UpStripButton.Size = new System.Drawing.Size(24, 33);
            this.UpStripButton.Text = "Up";
            this.UpStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 466);
            this.Controls.Add(this.MaintoolStrip);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "MonoTorrent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.detailsView.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.MaintoolStrip.ResumeLayout(false);
            this.MaintoolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ListView torrentsView;
        private System.Windows.Forms.TabControl detailsView;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabDetails;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colProgress;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colSeeds;
        private System.Windows.Forms.ColumnHeader colLeeches;
        private System.Windows.Forms.ColumnHeader colDownSpeed;
        private System.Windows.Forms.ColumnHeader colUpSpeed;
        private System.Windows.Forms.ColumnHeader colDownloaded;
        private System.Windows.Forms.ColumnHeader colUploaded;
        private System.Windows.Forms.ColumnHeader colRatio;
        private System.Windows.Forms.TabPage tabPeers;
        private System.Windows.Forms.TabPage tabPieces;
        private System.Windows.Forms.GroupBox trackerPanel;
        private System.Windows.Forms.GroupBox generalPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStrip MaintoolStrip;
        private System.Windows.Forms.ToolStripButton AddToolStripButton;
        private System.Windows.Forms.ToolStripButton StartToolStripButton;
        private System.Windows.Forms.ToolStripButton PauseToolStripButton;
        private System.Windows.Forms.ToolStripButton StopToolStripButton;
        private System.Windows.Forms.ToolStripButton DelToolStripButton;
        private System.Windows.Forms.ToolStripButton OptionToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DownStripButton;
        private System.Windows.Forms.ToolStripButton UpStripButton;
        private System.Windows.Forms.ToolStripMenuItem addATorrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createATorrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem showToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStatusbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem upToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteATorrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton CreateToolStripButton;
    }
}
