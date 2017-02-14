namespace Magazine.View {
    partial class ReviewerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewerForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStrip = new System.Windows.Forms.ToolStrip();
            this.userToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.reviewsGroupBox = new System.Windows.Forms.GroupBox();
            this.papersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.newRadioButton = new System.Windows.Forms.RadioButton();
            this.completedRadioButton = new System.Windows.Forms.RadioButton();
            this.searchPapersPromptTextBox = new Khronos_PMS.View.CustomControls.PromptTextBox();
            this.reviewsDataListView = new BrightIdeasSoftware.DataListView();
            this.titleColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.authorColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.statusColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.iconImageList = new System.Windows.Forms.ImageList(this.components);
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.reviewGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.commentToolStrip = new System.Windows.Forms.ToolStrip();
            this.commentToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.acceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.userToolStrip.SuspendLayout();
            this.reviewTableLayoutPanel.SuspendLayout();
            this.reviewsGroupBox.SuspendLayout();
            this.papersTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDataListView)).BeginInit();
            this.reviewGroupBox.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.commentToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::Magazine.Properties.Resources.refresh1;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // userToolStrip
            // 
            this.userToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userToolStrip.AutoSize = false;
            this.userToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.userToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.userToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripDropDownButton});
            this.userToolStrip.Location = new System.Drawing.Point(417, 0);
            this.userToolStrip.Name = "userToolStrip";
            this.userToolStrip.Size = new System.Drawing.Size(314, 24);
            this.userToolStrip.TabIndex = 3;
            this.userToolStrip.Text = "toolStrip1";
            // 
            // userToolStripDropDownButton
            // 
            this.userToolStripDropDownButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.userToolStripDropDownButton.Image = global::Magazine.Properties.Resources.user;
            this.userToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userToolStripDropDownButton.Name = "userToolStripDropDownButton";
            this.userToolStripDropDownButton.Size = new System.Drawing.Size(89, 21);
            this.userToolStripDropDownButton.Text = "Username";
            this.userToolStripDropDownButton.ToolTipText = "userToolStripDropDownButton";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::Magazine.Properties.Resources.logout;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // reviewTableLayoutPanel
            // 
            this.reviewTableLayoutPanel.ColumnCount = 2;
            this.reviewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.reviewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.reviewTableLayoutPanel.Controls.Add(this.reviewsGroupBox, 0, 0);
            this.reviewTableLayoutPanel.Controls.Add(this.reviewGroupBox, 1, 0);
            this.reviewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.reviewTableLayoutPanel.Name = "reviewTableLayoutPanel";
            this.reviewTableLayoutPanel.RowCount = 1;
            this.reviewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.reviewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.reviewTableLayoutPanel.Size = new System.Drawing.Size(731, 309);
            this.reviewTableLayoutPanel.TabIndex = 4;
            // 
            // reviewsGroupBox
            // 
            this.reviewsGroupBox.Controls.Add(this.papersTableLayoutPanel);
            this.reviewsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.reviewsGroupBox.Name = "reviewsGroupBox";
            this.reviewsGroupBox.Size = new System.Drawing.Size(359, 303);
            this.reviewsGroupBox.TabIndex = 0;
            this.reviewsGroupBox.TabStop = false;
            this.reviewsGroupBox.Text = "Reviews";
            // 
            // papersTableLayoutPanel
            // 
            this.papersTableLayoutPanel.ColumnCount = 3;
            this.papersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.papersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.papersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.papersTableLayoutPanel.Controls.Add(this.newRadioButton, 1, 0);
            this.papersTableLayoutPanel.Controls.Add(this.completedRadioButton, 0, 0);
            this.papersTableLayoutPanel.Controls.Add(this.searchPapersPromptTextBox, 0, 1);
            this.papersTableLayoutPanel.Controls.Add(this.reviewsDataListView, 0, 2);
            this.papersTableLayoutPanel.Controls.Add(this.allRadioButton, 2, 0);
            this.papersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.papersTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.papersTableLayoutPanel.Name = "papersTableLayoutPanel";
            this.papersTableLayoutPanel.RowCount = 3;
            this.papersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.papersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.papersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.papersTableLayoutPanel.Size = new System.Drawing.Size(353, 284);
            this.papersTableLayoutPanel.TabIndex = 0;
            // 
            // newRadioButton
            // 
            this.newRadioButton.AutoSize = true;
            this.newRadioButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.newRadioButton.Location = new System.Drawing.Point(258, 3);
            this.newRadioButton.Name = "newRadioButton";
            this.newRadioButton.Size = new System.Drawing.Size(47, 19);
            this.newRadioButton.TabIndex = 0;
            this.newRadioButton.Text = "New";
            this.newRadioButton.UseVisualStyleBackColor = true;
            this.newRadioButton.CheckedChanged += new System.EventHandler(this.newRadioButton_CheckedChanged);
            // 
            // completedRadioButton
            // 
            this.completedRadioButton.AutoSize = true;
            this.completedRadioButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.completedRadioButton.Location = new System.Drawing.Point(175, 3);
            this.completedRadioButton.Name = "completedRadioButton";
            this.completedRadioButton.Size = new System.Drawing.Size(75, 19);
            this.completedRadioButton.TabIndex = 1;
            this.completedRadioButton.Text = "Completed";
            this.completedRadioButton.UseVisualStyleBackColor = true;
            this.completedRadioButton.CheckedChanged += new System.EventHandler(this.completedRadioButton_CheckedChanged);
            // 
            // searchPapersPromptTextBox
            // 
            this.papersTableLayoutPanel.SetColumnSpan(this.searchPapersPromptTextBox, 3);
            this.searchPapersPromptTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPapersPromptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchPapersPromptTextBox.Location = new System.Drawing.Point(3, 28);
            this.searchPapersPromptTextBox.Name = "searchPapersPromptTextBox";
            this.searchPapersPromptTextBox.Size = new System.Drawing.Size(347, 20);
            this.searchPapersPromptTextBox.TabIndex = 2;
            this.searchPapersPromptTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.searchPapersPromptTextBox.WaterMarkText = "Type here to search";
            this.searchPapersPromptTextBox.TextChanged += new System.EventHandler(this.searchPapersPromptTextBox_TextChanged);
            // 
            // reviewsDataListView
            // 
            this.reviewsDataListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.reviewsDataListView.AllColumns.Add(this.titleColumn);
            this.reviewsDataListView.AllColumns.Add(this.authorColumn);
            this.reviewsDataListView.AllColumns.Add(this.dateColumn);
            this.reviewsDataListView.AllColumns.Add(this.statusColumn);
            this.reviewsDataListView.AutoGenerateColumns = false;
            this.reviewsDataListView.CellEditUseWholeCell = false;
            this.reviewsDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColumn,
            this.authorColumn,
            this.dateColumn,
            this.statusColumn});
            this.papersTableLayoutPanel.SetColumnSpan(this.reviewsDataListView, 3);
            this.reviewsDataListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.reviewsDataListView.DataSource = null;
            this.reviewsDataListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewsDataListView.FullRowSelect = true;
            this.reviewsDataListView.GridLines = true;
            this.reviewsDataListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.reviewsDataListView.HideSelection = false;
            this.reviewsDataListView.Location = new System.Drawing.Point(3, 53);
            this.reviewsDataListView.MultiSelect = false;
            this.reviewsDataListView.Name = "reviewsDataListView";
            this.reviewsDataListView.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.reviewsDataListView.SelectedForeColor = System.Drawing.Color.Black;
            this.reviewsDataListView.ShowGroups = false;
            this.reviewsDataListView.Size = new System.Drawing.Size(347, 228);
            this.reviewsDataListView.SmallImageList = this.iconImageList;
            this.reviewsDataListView.TabIndex = 3;
            this.reviewsDataListView.UnfocusedSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            this.reviewsDataListView.UseCompatibleStateImageBehavior = false;
            this.reviewsDataListView.UseFiltering = true;
            this.reviewsDataListView.View = System.Windows.Forms.View.Details;
            this.reviewsDataListView.SelectionChanged += new System.EventHandler(this.papersDataListView_SelectionChanged);
            // 
            // titleColumn
            // 
            this.titleColumn.AspectName = "file.paper.Title";
            this.titleColumn.AutoCompleteEditor = false;
            this.titleColumn.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.titleColumn.FillsFreeSpace = true;
            this.titleColumn.Groupable = false;
            this.titleColumn.IsEditable = false;
            this.titleColumn.Text = "Title";
            // 
            // authorColumn
            // 
            this.authorColumn.AspectName = "file.paper.author_user";
            this.authorColumn.AutoCompleteEditor = false;
            this.authorColumn.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.authorColumn.FillsFreeSpace = true;
            this.authorColumn.Groupable = false;
            this.authorColumn.IsEditable = false;
            this.authorColumn.Text = "Author";
            // 
            // dateColumn
            // 
            this.dateColumn.AspectName = "file.Timestamp";
            this.dateColumn.AutoCompleteEditor = false;
            this.dateColumn.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.dateColumn.FillsFreeSpace = true;
            this.dateColumn.Groupable = false;
            this.dateColumn.IsEditable = false;
            this.dateColumn.Text = "Date of submission";
            // 
            // statusColumn
            // 
            this.statusColumn.AspectName = "STATUS_id";
            this.statusColumn.AutoCompleteEditor = false;
            this.statusColumn.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.statusColumn.FillsFreeSpace = true;
            this.statusColumn.Groupable = false;
            this.statusColumn.IsEditable = false;
            this.statusColumn.Text = "Status";
            // 
            // iconImageList
            // 
            this.iconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconImageList.ImageStream")));
            this.iconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconImageList.Images.SetKeyName(0, "paper.png");
            this.iconImageList.Images.SetKeyName(1, "author.png");
            this.iconImageList.Images.SetKeyName(2, "date.png");
            this.iconImageList.Images.SetKeyName(3, "accept.png");
            this.iconImageList.Images.SetKeyName(4, "reject.png");
            this.iconImageList.Images.SetKeyName(5, "warning.png");
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.allRadioButton.Location = new System.Drawing.Point(314, 3);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(36, 19);
            this.allRadioButton.TabIndex = 4;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            this.allRadioButton.CheckedChanged += new System.EventHandler(this.allRadioButton_CheckedChanged);
            // 
            // reviewGroupBox
            // 
            this.reviewGroupBox.Controls.Add(this.tableLayoutPanel);
            this.reviewGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewGroupBox.Location = new System.Drawing.Point(368, 3);
            this.reviewGroupBox.Name = "reviewGroupBox";
            this.reviewGroupBox.Size = new System.Drawing.Size(360, 303);
            this.reviewGroupBox.TabIndex = 1;
            this.reviewGroupBox.TabStop = false;
            this.reviewGroupBox.Text = "Review";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Controls.Add(this.saveButton, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.commentToolStrip, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.reviewTextBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.openButton, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.progressBar, 0, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(354, 284);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Location = new System.Drawing.Point(307, 237);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(44, 24);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // commentToolStrip
            // 
            this.commentToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.commentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commentToolStripDropDownButton});
            this.commentToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.commentToolStrip.Location = new System.Drawing.Point(0, 234);
            this.commentToolStrip.Name = "commentToolStrip";
            this.commentToolStrip.Size = new System.Drawing.Size(304, 30);
            this.commentToolStrip.TabIndex = 3;
            this.commentToolStrip.Text = "toolStrip1";
            // 
            // commentToolStripDropDownButton
            // 
            this.commentToolStripDropDownButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.commentToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.commentToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceptToolStripMenuItem,
            this.rejectToolStripMenuItem});
            this.commentToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("commentToolStripDropDownButton.Image")));
            this.commentToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.commentToolStripDropDownButton.Name = "commentToolStripDropDownButton";
            this.commentToolStripDropDownButton.Size = new System.Drawing.Size(122, 27);
            this.commentToolStripDropDownButton.Text = "Select review status";
            this.commentToolStripDropDownButton.ToolTipText = "Select review status";
            // 
            // acceptToolStripMenuItem
            // 
            this.acceptToolStripMenuItem.Name = "acceptToolStripMenuItem";
            this.acceptToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.acceptToolStripMenuItem.Text = "Accept";
            this.acceptToolStripMenuItem.Click += new System.EventHandler(this.acceptToolStripMenuItem_Click);
            // 
            // rejectToolStripMenuItem
            // 
            this.rejectToolStripMenuItem.Name = "rejectToolStripMenuItem";
            this.rejectToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.rejectToolStripMenuItem.Text = "Reject";
            this.rejectToolStripMenuItem.Click += new System.EventHandler(this.rejectToolStripMenuItem_Click);
            // 
            // reviewTextBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.reviewTextBox, 2);
            this.reviewTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewTextBox.Location = new System.Drawing.Point(3, 33);
            this.reviewTextBox.Multiline = true;
            this.reviewTextBox.Name = "reviewTextBox";
            this.reviewTextBox.Size = new System.Drawing.Size(348, 198);
            this.reviewTextBox.TabIndex = 0;
            // 
            // openButton
            // 
            this.openButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.openButton.Location = new System.Drawing.Point(307, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(44, 24);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // progressBar
            // 
            this.tableLayoutPanel.SetColumnSpan(this.progressBar, 2);
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 267);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(348, 14);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 5;
            // 
            // ReviewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 333);
            this.Controls.Add(this.reviewTableLayoutPanel);
            this.Controls.Add(this.userToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReviewerForm";
            this.Text = "VS Magazine";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.userToolStrip.ResumeLayout(false);
            this.userToolStrip.PerformLayout();
            this.reviewTableLayoutPanel.ResumeLayout(false);
            this.reviewsGroupBox.ResumeLayout(false);
            this.papersTableLayoutPanel.ResumeLayout(false);
            this.papersTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDataListView)).EndInit();
            this.reviewGroupBox.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.commentToolStrip.ResumeLayout(false);
            this.commentToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStrip userToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton userToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel reviewTableLayoutPanel;
        private System.Windows.Forms.GroupBox reviewsGroupBox;
        private System.Windows.Forms.TableLayoutPanel papersTableLayoutPanel;
        private System.Windows.Forms.RadioButton newRadioButton;
        private System.Windows.Forms.RadioButton completedRadioButton;
        private Khronos_PMS.View.CustomControls.PromptTextBox searchPapersPromptTextBox;
        private BrightIdeasSoftware.DataListView reviewsDataListView;
        private System.Windows.Forms.GroupBox reviewGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox reviewTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ToolStrip commentToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton commentToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem acceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn titleColumn;
        private BrightIdeasSoftware.OLVColumn authorColumn;
        private BrightIdeasSoftware.OLVColumn dateColumn;
        private BrightIdeasSoftware.OLVColumn statusColumn;
        private System.Windows.Forms.ImageList iconImageList;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}