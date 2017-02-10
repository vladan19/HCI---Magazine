namespace Magazine.View {
    partial class EditorForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.editorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlToolStrip = new System.Windows.Forms.ToolStrip();
            this.userToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.papersGroupBox = new System.Windows.Forms.GroupBox();
            this.papersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.papersSearchPromptTextBox = new Khronos_PMS.View.CustomControls.PromptTextBox();
            this.papersDataListView = new BrightIdeasSoftware.DataListView();
            this.titleColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.authorColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.statusColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.iconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.inProgressRadioButton = new System.Windows.Forms.RadioButton();
            this.newRadioButton = new System.Windows.Forms.RadioButton();
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.detailsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.openButton = new System.Windows.Forms.Button();
            this.submissionsButton = new System.Windows.Forms.Button();
            this.commentGroupBox = new System.Windows.Forms.GroupBox();
            this.commentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.commentToolStrip = new System.Windows.Forms.ToolStrip();
            this.commentToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.reviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewsGroupBox = new System.Windows.Forms.GroupBox();
            this.reviewsDataListView = new BrightIdeasSoftware.DataListView();
            this.editorTableLayoutPanel.SuspendLayout();
            this.controlToolStrip.SuspendLayout();
            this.papersGroupBox.SuspendLayout();
            this.papersTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.papersDataListView)).BeginInit();
            this.detailsGroupBox.SuspendLayout();
            this.detailsTableLayoutPanel.SuspendLayout();
            this.commentGroupBox.SuspendLayout();
            this.commentTableLayoutPanel.SuspendLayout();
            this.commentToolStrip.SuspendLayout();
            this.reviewsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDataListView)).BeginInit();
            this.SuspendLayout();
            // 
            // editorTableLayoutPanel
            // 
            this.editorTableLayoutPanel.ColumnCount = 2;
            this.editorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.editorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.editorTableLayoutPanel.Controls.Add(this.controlToolStrip, 1, 0);
            this.editorTableLayoutPanel.Controls.Add(this.papersGroupBox, 0, 1);
            this.editorTableLayoutPanel.Controls.Add(this.detailsGroupBox, 1, 1);
            this.editorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.editorTableLayoutPanel.Name = "editorTableLayoutPanel";
            this.editorTableLayoutPanel.RowCount = 2;
            this.editorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.editorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.editorTableLayoutPanel.Size = new System.Drawing.Size(728, 315);
            this.editorTableLayoutPanel.TabIndex = 0;
            // 
            // controlToolStrip
            // 
            this.controlToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlToolStrip.AutoSize = false;
            this.controlToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.controlToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.controlToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripDropDownButton});
            this.controlToolStrip.Location = new System.Drawing.Point(364, 0);
            this.controlToolStrip.Name = "controlToolStrip";
            this.controlToolStrip.Size = new System.Drawing.Size(364, 24);
            this.controlToolStrip.TabIndex = 3;
            this.controlToolStrip.Text = "toolStrip";
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
            // papersGroupBox
            // 
            this.papersGroupBox.Controls.Add(this.papersTableLayoutPanel);
            this.papersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.papersGroupBox.Location = new System.Drawing.Point(3, 33);
            this.papersGroupBox.Name = "papersGroupBox";
            this.papersGroupBox.Size = new System.Drawing.Size(358, 279);
            this.papersGroupBox.TabIndex = 4;
            this.papersGroupBox.TabStop = false;
            this.papersGroupBox.Text = "Papers";
            // 
            // papersTableLayoutPanel
            // 
            this.papersTableLayoutPanel.ColumnCount = 3;
            this.papersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.papersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.papersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.papersTableLayoutPanel.Controls.Add(this.papersSearchPromptTextBox, 0, 1);
            this.papersTableLayoutPanel.Controls.Add(this.papersDataListView, 0, 2);
            this.papersTableLayoutPanel.Controls.Add(this.allRadioButton, 2, 0);
            this.papersTableLayoutPanel.Controls.Add(this.inProgressRadioButton, 1, 0);
            this.papersTableLayoutPanel.Controls.Add(this.newRadioButton, 0, 0);
            this.papersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.papersTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.papersTableLayoutPanel.Name = "papersTableLayoutPanel";
            this.papersTableLayoutPanel.RowCount = 3;
            this.papersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.papersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.papersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.papersTableLayoutPanel.Size = new System.Drawing.Size(352, 260);
            this.papersTableLayoutPanel.TabIndex = 0;
            // 
            // papersSearchPromptTextBox
            // 
            this.papersTableLayoutPanel.SetColumnSpan(this.papersSearchPromptTextBox, 3);
            this.papersSearchPromptTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.papersSearchPromptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.papersSearchPromptTextBox.Location = new System.Drawing.Point(3, 28);
            this.papersSearchPromptTextBox.Name = "papersSearchPromptTextBox";
            this.papersSearchPromptTextBox.Size = new System.Drawing.Size(346, 20);
            this.papersSearchPromptTextBox.TabIndex = 0;
            this.papersSearchPromptTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.papersSearchPromptTextBox.WaterMarkText = "Type here to search";
            this.papersSearchPromptTextBox.TextChanged += new System.EventHandler(this.papersSearchPromptTextBox_TextChanged);
            // 
            // papersDataListView
            // 
            this.papersDataListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.papersDataListView.AllColumns.Add(this.titleColumn);
            this.papersDataListView.AllColumns.Add(this.authorColumn);
            this.papersDataListView.AllColumns.Add(this.statusColumn);
            this.papersDataListView.AutoGenerateColumns = false;
            this.papersDataListView.CellEditUseWholeCell = false;
            this.papersDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColumn,
            this.authorColumn,
            this.statusColumn});
            this.papersTableLayoutPanel.SetColumnSpan(this.papersDataListView, 3);
            this.papersDataListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.papersDataListView.DataSource = null;
            this.papersDataListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.papersDataListView.FullRowSelect = true;
            this.papersDataListView.GridLines = true;
            this.papersDataListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.papersDataListView.HideSelection = false;
            this.papersDataListView.Location = new System.Drawing.Point(3, 53);
            this.papersDataListView.MultiSelect = false;
            this.papersDataListView.Name = "papersDataListView";
            this.papersDataListView.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.papersDataListView.SelectedForeColor = System.Drawing.Color.Black;
            this.papersDataListView.ShowGroups = false;
            this.papersDataListView.Size = new System.Drawing.Size(346, 204);
            this.papersDataListView.SmallImageList = this.iconsImageList;
            this.papersDataListView.TabIndex = 3;
            this.papersDataListView.UnfocusedSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            this.papersDataListView.UseCompatibleStateImageBehavior = false;
            this.papersDataListView.UseFiltering = true;
            this.papersDataListView.View = System.Windows.Forms.View.Details;
            // 
            // titleColumn
            // 
            this.titleColumn.AspectName = "Title";
            this.titleColumn.AutoCompleteEditor = false;
            this.titleColumn.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.titleColumn.FillsFreeSpace = true;
            this.titleColumn.Groupable = false;
            this.titleColumn.ImageAspectName = "paper";
            this.titleColumn.Text = "Title";
            this.titleColumn.Width = 120;
            // 
            // authorColumn
            // 
            this.authorColumn.AspectName = "author_user";
            this.authorColumn.AutoCompleteEditor = false;
            this.authorColumn.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.authorColumn.FillsFreeSpace = true;
            this.authorColumn.Groupable = false;
            this.authorColumn.ImageAspectName = "author";
            this.authorColumn.IsEditable = false;
            this.authorColumn.Text = "Author";
            this.authorColumn.Width = 120;
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
            // iconsImageList
            // 
            this.iconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsImageList.ImageStream")));
            this.iconsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconsImageList.Images.SetKeyName(0, "paper.png");
            this.iconsImageList.Images.SetKeyName(1, "author.png");
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.allRadioButton.Location = new System.Drawing.Point(313, 3);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(36, 19);
            this.allRadioButton.TabIndex = 2;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            this.allRadioButton.CheckedChanged += new System.EventHandler(this.allRadioButton_CheckedChanged);
            // 
            // inProgressRadioButton
            // 
            this.inProgressRadioButton.AutoSize = true;
            this.inProgressRadioButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.inProgressRadioButton.Location = new System.Drawing.Point(222, 3);
            this.inProgressRadioButton.Name = "inProgressRadioButton";
            this.inProgressRadioButton.Size = new System.Drawing.Size(77, 19);
            this.inProgressRadioButton.TabIndex = 1;
            this.inProgressRadioButton.Text = "In progress";
            this.inProgressRadioButton.UseVisualStyleBackColor = true;
            this.inProgressRadioButton.CheckedChanged += new System.EventHandler(this.inProgressRadioButton_CheckedChanged);
            // 
            // newRadioButton
            // 
            this.newRadioButton.AutoSize = true;
            this.newRadioButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.newRadioButton.Location = new System.Drawing.Point(167, 3);
            this.newRadioButton.Name = "newRadioButton";
            this.newRadioButton.Size = new System.Drawing.Size(47, 19);
            this.newRadioButton.TabIndex = 4;
            this.newRadioButton.Text = "New";
            this.newRadioButton.UseVisualStyleBackColor = true;
            this.newRadioButton.CheckedChanged += new System.EventHandler(this.newRadioButton_CheckedChanged);
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.Controls.Add(this.detailsTableLayoutPanel);
            this.detailsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGroupBox.Location = new System.Drawing.Point(367, 33);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Size = new System.Drawing.Size(358, 279);
            this.detailsGroupBox.TabIndex = 5;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Details";
            // 
            // detailsTableLayoutPanel
            // 
            this.detailsTableLayoutPanel.ColumnCount = 2;
            this.detailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.detailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.detailsTableLayoutPanel.Controls.Add(this.openButton, 1, 0);
            this.detailsTableLayoutPanel.Controls.Add(this.submissionsButton, 0, 0);
            this.detailsTableLayoutPanel.Controls.Add(this.commentGroupBox, 0, 1);
            this.detailsTableLayoutPanel.Controls.Add(this.reviewsGroupBox, 0, 2);
            this.detailsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.detailsTableLayoutPanel.Name = "detailsTableLayoutPanel";
            this.detailsTableLayoutPanel.RowCount = 3;
            this.detailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.detailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.detailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.detailsTableLayoutPanel.Size = new System.Drawing.Size(352, 260);
            this.detailsTableLayoutPanel.TabIndex = 0;
            // 
            // openButton
            // 
            this.openButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.openButton.Location = new System.Drawing.Point(275, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(74, 24);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // submissionsButton
            // 
            this.submissionsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.submissionsButton.Location = new System.Drawing.Point(194, 3);
            this.submissionsButton.Name = "submissionsButton";
            this.submissionsButton.Size = new System.Drawing.Size(75, 24);
            this.submissionsButton.TabIndex = 1;
            this.submissionsButton.Text = "Submissions";
            this.submissionsButton.UseVisualStyleBackColor = true;
            // 
            // commentGroupBox
            // 
            this.detailsTableLayoutPanel.SetColumnSpan(this.commentGroupBox, 2);
            this.commentGroupBox.Controls.Add(this.commentTableLayoutPanel);
            this.commentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentGroupBox.Location = new System.Drawing.Point(3, 33);
            this.commentGroupBox.Name = "commentGroupBox";
            this.commentGroupBox.Size = new System.Drawing.Size(346, 109);
            this.commentGroupBox.TabIndex = 2;
            this.commentGroupBox.TabStop = false;
            this.commentGroupBox.Text = "Comment";
            // 
            // commentTableLayoutPanel
            // 
            this.commentTableLayoutPanel.ColumnCount = 2;
            this.commentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.commentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.commentTableLayoutPanel.Controls.Add(this.commentTextBox, 0, 0);
            this.commentTableLayoutPanel.Controls.Add(this.saveButton, 1, 1);
            this.commentTableLayoutPanel.Controls.Add(this.commentToolStrip, 0, 1);
            this.commentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.commentTableLayoutPanel.Name = "commentTableLayoutPanel";
            this.commentTableLayoutPanel.RowCount = 2;
            this.commentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.commentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.commentTableLayoutPanel.Size = new System.Drawing.Size(340, 90);
            this.commentTableLayoutPanel.TabIndex = 0;
            // 
            // commentTextBox
            // 
            this.commentTableLayoutPanel.SetColumnSpan(this.commentTextBox, 2);
            this.commentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentTextBox.Location = new System.Drawing.Point(3, 3);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(334, 54);
            this.commentTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveButton.Location = new System.Drawing.Point(263, 63);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(74, 24);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // commentToolStrip
            // 
            this.commentToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.commentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commentToolStripDropDownButton});
            this.commentToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.commentToolStrip.Location = new System.Drawing.Point(0, 60);
            this.commentToolStrip.Name = "commentToolStrip";
            this.commentToolStrip.Size = new System.Drawing.Size(260, 25);
            this.commentToolStrip.TabIndex = 2;
            this.commentToolStrip.Text = "toolStrip1";
            // 
            // commentToolStripDropDownButton
            // 
            this.commentToolStripDropDownButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.commentToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.commentToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reviewToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.finalToolStripMenuItem,
            this.publishToolStripMenuItem,
            this.RejectToolStripMenuItem});
            this.commentToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("commentToolStripDropDownButton.Image")));
            this.commentToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.commentToolStripDropDownButton.Name = "commentToolStripDropDownButton";
            this.commentToolStripDropDownButton.Size = new System.Drawing.Size(97, 22);
            this.commentToolStripDropDownButton.Text = "Send to review";
            // 
            // reviewToolStripMenuItem
            // 
            this.reviewToolStripMenuItem.Name = "reviewToolStripMenuItem";
            this.reviewToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.reviewToolStripMenuItem.Text = "Send to review";
            this.reviewToolStripMenuItem.Click += new System.EventHandler(this.reviewToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.returnToolStripMenuItem.Text = "Return to author";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // finalToolStripMenuItem
            // 
            this.finalToolStripMenuItem.Name = "finalToolStripMenuItem";
            this.finalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.finalToolStripMenuItem.Text = "Return to final edit";
            this.finalToolStripMenuItem.Click += new System.EventHandler(this.finalToolStripMenuItem_Click);
            // 
            // publishToolStripMenuItem
            // 
            this.publishToolStripMenuItem.Name = "publishToolStripMenuItem";
            this.publishToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.publishToolStripMenuItem.Text = "Publish";
            this.publishToolStripMenuItem.Click += new System.EventHandler(this.publishToolStripMenuItem_Click);
            // 
            // RejectToolStripMenuItem
            // 
            this.RejectToolStripMenuItem.Name = "RejectToolStripMenuItem";
            this.RejectToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.RejectToolStripMenuItem.Text = "Reject";
            this.RejectToolStripMenuItem.Click += new System.EventHandler(this.RejectToolStripMenuItem_Click);
            // 
            // reviewsGroupBox
            // 
            this.detailsTableLayoutPanel.SetColumnSpan(this.reviewsGroupBox, 2);
            this.reviewsGroupBox.Controls.Add(this.reviewsDataListView);
            this.reviewsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewsGroupBox.Location = new System.Drawing.Point(3, 148);
            this.reviewsGroupBox.Name = "reviewsGroupBox";
            this.reviewsGroupBox.Size = new System.Drawing.Size(346, 109);
            this.reviewsGroupBox.TabIndex = 3;
            this.reviewsGroupBox.TabStop = false;
            this.reviewsGroupBox.Text = "Reviews";
            // 
            // reviewsDataListView
            // 
            this.reviewsDataListView.CellEditUseWholeCell = false;
            this.reviewsDataListView.DataSource = null;
            this.reviewsDataListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewsDataListView.Location = new System.Drawing.Point(3, 16);
            this.reviewsDataListView.Name = "reviewsDataListView";
            this.reviewsDataListView.Size = new System.Drawing.Size(340, 90);
            this.reviewsDataListView.TabIndex = 0;
            this.reviewsDataListView.UseCompatibleStateImageBehavior = false;
            this.reviewsDataListView.View = System.Windows.Forms.View.Details;
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 315);
            this.Controls.Add(this.editorTableLayoutPanel);
            this.Name = "EditorForm";
            this.Text = "EditorForm";
            this.SizeChanged += new System.EventHandler(this.EditorForm_SizeChanged);
            this.editorTableLayoutPanel.ResumeLayout(false);
            this.controlToolStrip.ResumeLayout(false);
            this.controlToolStrip.PerformLayout();
            this.papersGroupBox.ResumeLayout(false);
            this.papersTableLayoutPanel.ResumeLayout(false);
            this.papersTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.papersDataListView)).EndInit();
            this.detailsGroupBox.ResumeLayout(false);
            this.detailsTableLayoutPanel.ResumeLayout(false);
            this.commentGroupBox.ResumeLayout(false);
            this.commentTableLayoutPanel.ResumeLayout(false);
            this.commentTableLayoutPanel.PerformLayout();
            this.commentToolStrip.ResumeLayout(false);
            this.commentToolStrip.PerformLayout();
            this.reviewsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDataListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel editorTableLayoutPanel;
        private System.Windows.Forms.ToolStrip controlToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton userToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.GroupBox papersGroupBox;
        private System.Windows.Forms.TableLayoutPanel papersTableLayoutPanel;
        private Khronos_PMS.View.CustomControls.PromptTextBox papersSearchPromptTextBox;
        private BrightIdeasSoftware.DataListView papersDataListView;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.RadioButton inProgressRadioButton;
        private System.Windows.Forms.RadioButton newRadioButton;
        private System.Windows.Forms.GroupBox detailsGroupBox;
        private System.Windows.Forms.TableLayoutPanel detailsTableLayoutPanel;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button submissionsButton;
        private System.Windows.Forms.GroupBox commentGroupBox;
        private System.Windows.Forms.TableLayoutPanel commentTableLayoutPanel;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox reviewsGroupBox;
        private System.Windows.Forms.ToolStrip commentToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton commentToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem reviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RejectToolStripMenuItem;
        private BrightIdeasSoftware.DataListView reviewsDataListView;
        private BrightIdeasSoftware.OLVColumn titleColumn;
        private BrightIdeasSoftware.OLVColumn authorColumn;
        private BrightIdeasSoftware.OLVColumn statusColumn;
        private System.Windows.Forms.ImageList iconsImageList;
    }
}