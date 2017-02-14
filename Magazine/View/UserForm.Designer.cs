namespace Magazine.View {
    partial class UserForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.papersGroupBox = new System.Windows.Forms.GroupBox();
            this.papersTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.papersDataListView = new BrightIdeasSoftware.DataListView();
            this.titleColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.statusColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.iconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.addPaperButton = new System.Windows.Forms.Button();
            this.papersSearchPromptTextBox = new Khronos_PMS.View.CustomControls.PromptTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submissionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.submissionsGroupBox = new System.Windows.Forms.GroupBox();
            this.submissionsDataListView = new BrightIdeasSoftware.DataListView();
            this.timestampColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.editorCommentGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.editorCommentTextBox = new System.Windows.Forms.TextBox();
            this.editorLabel = new System.Windows.Forms.Label();
            this.uploadGroupBox = new System.Windows.Forms.GroupBox();
            this.uploadTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.uploadControl = new Magazine.Controls.UploadControl();
            this.uploadProgressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.userToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.formTableLayoutPanel.SuspendLayout();
            this.papersGroupBox.SuspendLayout();
            this.papersTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.papersDataListView)).BeginInit();
            this.submissionsTableLayoutPanel.SuspendLayout();
            this.submissionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.submissionsDataListView)).BeginInit();
            this.editorCommentGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.uploadGroupBox.SuspendLayout();
            this.uploadTableLayoutPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTableLayoutPanel
            // 
            this.formTableLayoutPanel.ColumnCount = 2;
            this.formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formTableLayoutPanel.Controls.Add(this.papersGroupBox, 0, 0);
            this.formTableLayoutPanel.Controls.Add(this.submissionsTableLayoutPanel, 1, 0);
            this.formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.formTableLayoutPanel.Name = "formTableLayoutPanel";
            this.formTableLayoutPanel.RowCount = 1;
            this.formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formTableLayoutPanel.Size = new System.Drawing.Size(721, 371);
            this.formTableLayoutPanel.TabIndex = 0;
            // 
            // papersGroupBox
            // 
            this.papersGroupBox.Controls.Add(this.papersTableLayoutPanel1);
            this.papersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.papersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.papersGroupBox.Name = "papersGroupBox";
            this.papersGroupBox.Size = new System.Drawing.Size(354, 365);
            this.papersGroupBox.TabIndex = 0;
            this.papersGroupBox.TabStop = false;
            this.papersGroupBox.Text = "Papers";
            // 
            // papersTableLayoutPanel1
            // 
            this.papersTableLayoutPanel1.ColumnCount = 2;
            this.papersTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.papersTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.papersTableLayoutPanel1.Controls.Add(this.papersDataListView, 0, 1);
            this.papersTableLayoutPanel1.Controls.Add(this.addPaperButton, 0, 2);
            this.papersTableLayoutPanel1.Controls.Add(this.papersSearchPromptTextBox, 0, 0);
            this.papersTableLayoutPanel1.Controls.Add(this.cancelButton, 1, 2);
            this.papersTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.papersTableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.papersTableLayoutPanel1.Name = "papersTableLayoutPanel1";
            this.papersTableLayoutPanel1.RowCount = 3;
            this.papersTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.papersTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.papersTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.papersTableLayoutPanel1.Size = new System.Drawing.Size(348, 346);
            this.papersTableLayoutPanel1.TabIndex = 0;
            // 
            // papersDataListView
            // 
            this.papersDataListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.papersDataListView.AllColumns.Add(this.titleColumn);
            this.papersDataListView.AllColumns.Add(this.statusColumn);
            this.papersDataListView.AutoGenerateColumns = false;
            this.papersDataListView.CellEditUseWholeCell = false;
            this.papersDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColumn,
            this.statusColumn});
            this.papersTableLayoutPanel1.SetColumnSpan(this.papersDataListView, 2);
            this.papersDataListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.papersDataListView.DataSource = null;
            this.papersDataListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.papersDataListView.FullRowSelect = true;
            this.papersDataListView.GridLines = true;
            this.papersDataListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.papersDataListView.HideSelection = false;
            this.papersDataListView.Location = new System.Drawing.Point(3, 28);
            this.papersDataListView.MultiSelect = false;
            this.papersDataListView.Name = "papersDataListView";
            this.papersDataListView.ShowGroups = false;
            this.papersDataListView.Size = new System.Drawing.Size(342, 280);
            this.papersDataListView.SmallImageList = this.iconsImageList;
            this.papersDataListView.TabIndex = 1;
            this.papersDataListView.UseCompatibleStateImageBehavior = false;
            this.papersDataListView.UseFiltering = true;
            this.papersDataListView.View = System.Windows.Forms.View.Details;
            this.papersDataListView.SelectionChanged += new System.EventHandler(this.papersDataListView_SelectionChanged);
            // 
            // titleColumn
            // 
            this.titleColumn.AspectName = "Title";
            this.titleColumn.AutoCompleteEditor = false;
            this.titleColumn.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.titleColumn.FillsFreeSpace = true;
            this.titleColumn.Groupable = false;
            this.titleColumn.Hideable = false;
            this.titleColumn.ImageAspectName = "paper";
            this.titleColumn.IsEditable = false;
            this.titleColumn.Text = "Title";
            this.titleColumn.Width = 245;
            // 
            // statusColumn
            // 
            this.statusColumn.AspectName = "STATUS_id";
            this.statusColumn.FillsFreeSpace = true;
            this.statusColumn.IsEditable = false;
            this.statusColumn.Text = "Status";
            // 
            // iconsImageList
            // 
            this.iconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsImageList.ImageStream")));
            this.iconsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconsImageList.Images.SetKeyName(0, "paper.png");
            this.iconsImageList.Images.SetKeyName(1, "date.png");
            this.iconsImageList.Images.SetKeyName(2, "status_inprogress.png");
            this.iconsImageList.Images.SetKeyName(3, "warning.png");
            this.iconsImageList.Images.SetKeyName(4, "accept.png");
            this.iconsImageList.Images.SetKeyName(5, "reject.png");
            // 
            // addPaperButton
            // 
            this.addPaperButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addPaperButton.Image = global::Magazine.Properties.Resources.add;
            this.addPaperButton.Location = new System.Drawing.Point(280, 314);
            this.addPaperButton.Name = "addPaperButton";
            this.addPaperButton.Size = new System.Drawing.Size(30, 29);
            this.addPaperButton.TabIndex = 3;
            this.addPaperButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.addPaperButton, "Add new paper");
            this.addPaperButton.UseVisualStyleBackColor = true;
            this.addPaperButton.Click += new System.EventHandler(this.addPaperButton_Click);
            // 
            // papersSearchPromptTextBox
            // 
            this.papersTableLayoutPanel1.SetColumnSpan(this.papersSearchPromptTextBox, 2);
            this.papersSearchPromptTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.papersSearchPromptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.papersSearchPromptTextBox.Location = new System.Drawing.Point(3, 3);
            this.papersSearchPromptTextBox.Name = "papersSearchPromptTextBox";
            this.papersSearchPromptTextBox.Size = new System.Drawing.Size(342, 20);
            this.papersSearchPromptTextBox.TabIndex = 2;
            this.papersSearchPromptTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.papersSearchPromptTextBox.WaterMarkText = "Type here to search";
            this.papersSearchPromptTextBox.TextChanged += new System.EventHandler(this.projectsSearchPromptTextBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Image = global::Magazine.Properties.Resources.cancel;
            this.cancelButton.Location = new System.Drawing.Point(316, 314);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(29, 29);
            this.cancelButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cancelButton, "Cancel paper");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submissionsTableLayoutPanel
            // 
            this.submissionsTableLayoutPanel.ColumnCount = 1;
            this.submissionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.submissionsTableLayoutPanel.Controls.Add(this.submissionsGroupBox, 0, 0);
            this.submissionsTableLayoutPanel.Controls.Add(this.editorCommentGroupBox, 0, 1);
            this.submissionsTableLayoutPanel.Controls.Add(this.uploadGroupBox, 0, 2);
            this.submissionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submissionsTableLayoutPanel.Location = new System.Drawing.Point(363, 3);
            this.submissionsTableLayoutPanel.Name = "submissionsTableLayoutPanel";
            this.submissionsTableLayoutPanel.RowCount = 3;
            this.submissionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submissionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submissionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.submissionsTableLayoutPanel.Size = new System.Drawing.Size(355, 365);
            this.submissionsTableLayoutPanel.TabIndex = 1;
            // 
            // submissionsGroupBox
            // 
            this.submissionsGroupBox.Controls.Add(this.submissionsDataListView);
            this.submissionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submissionsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.submissionsGroupBox.Name = "submissionsGroupBox";
            this.submissionsGroupBox.Size = new System.Drawing.Size(349, 101);
            this.submissionsGroupBox.TabIndex = 0;
            this.submissionsGroupBox.TabStop = false;
            this.submissionsGroupBox.Text = "Submissions";
            // 
            // submissionsDataListView
            // 
            this.submissionsDataListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.submissionsDataListView.AllColumns.Add(this.timestampColumn);
            this.submissionsDataListView.AutoGenerateColumns = false;
            this.submissionsDataListView.CellEditUseWholeCell = false;
            this.submissionsDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timestampColumn});
            this.submissionsDataListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.submissionsDataListView.DataSource = null;
            this.submissionsDataListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submissionsDataListView.FullRowSelect = true;
            this.submissionsDataListView.GridLines = true;
            this.submissionsDataListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.submissionsDataListView.HideSelection = false;
            this.submissionsDataListView.Location = new System.Drawing.Point(3, 16);
            this.submissionsDataListView.MultiSelect = false;
            this.submissionsDataListView.Name = "submissionsDataListView";
            this.submissionsDataListView.ShowGroups = false;
            this.submissionsDataListView.Size = new System.Drawing.Size(343, 82);
            this.submissionsDataListView.SmallImageList = this.iconsImageList;
            this.submissionsDataListView.TabIndex = 0;
            this.submissionsDataListView.UseCompatibleStateImageBehavior = false;
            this.submissionsDataListView.View = System.Windows.Forms.View.Details;
            this.submissionsDataListView.SelectionChanged += new System.EventHandler(this.submissionsDataListView_SelectionChanged);
            this.submissionsDataListView.DoubleClick += new System.EventHandler(this.submissionsDataListView_DoubleClick);
            // 
            // timestampColumn
            // 
            this.timestampColumn.AspectName = "Timestamp";
            this.timestampColumn.IsEditable = false;
            this.timestampColumn.Text = "Date of submission";
            this.timestampColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // editorCommentGroupBox
            // 
            this.editorCommentGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.editorCommentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorCommentGroupBox.Location = new System.Drawing.Point(3, 110);
            this.editorCommentGroupBox.Name = "editorCommentGroupBox";
            this.editorCommentGroupBox.Size = new System.Drawing.Size(349, 101);
            this.editorCommentGroupBox.TabIndex = 1;
            this.editorCommentGroupBox.TabStop = false;
            this.editorCommentGroupBox.Text = "Editor comment";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.editorCommentTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.editorLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 82);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // editorCommentTextBox
            // 
            this.editorCommentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorCommentTextBox.Location = new System.Drawing.Point(3, 23);
            this.editorCommentTextBox.Multiline = true;
            this.editorCommentTextBox.Name = "editorCommentTextBox";
            this.editorCommentTextBox.ReadOnly = true;
            this.editorCommentTextBox.Size = new System.Drawing.Size(337, 56);
            this.editorCommentTextBox.TabIndex = 0;
            this.editorCommentTextBox.Text = "Editors opinion";
            // 
            // editorLabel
            // 
            this.editorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.editorLabel.AutoSize = true;
            this.editorLabel.Location = new System.Drawing.Point(3, 3);
            this.editorLabel.Name = "editorLabel";
            this.editorLabel.Size = new System.Drawing.Size(63, 13);
            this.editorLabel.TabIndex = 1;
            this.editorLabel.Text = "Editor name";
            // 
            // uploadGroupBox
            // 
            this.uploadGroupBox.Controls.Add(this.uploadTableLayoutPanel);
            this.uploadGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadGroupBox.Location = new System.Drawing.Point(3, 217);
            this.uploadGroupBox.Name = "uploadGroupBox";
            this.uploadGroupBox.Size = new System.Drawing.Size(349, 145);
            this.uploadGroupBox.TabIndex = 2;
            this.uploadGroupBox.TabStop = false;
            this.uploadGroupBox.Text = "Upload";
            // 
            // uploadTableLayoutPanel
            // 
            this.uploadTableLayoutPanel.ColumnCount = 1;
            this.uploadTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uploadTableLayoutPanel.Controls.Add(this.uploadControl, 0, 0);
            this.uploadTableLayoutPanel.Controls.Add(this.uploadProgressBar, 0, 1);
            this.uploadTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.uploadTableLayoutPanel.Name = "uploadTableLayoutPanel";
            this.uploadTableLayoutPanel.RowCount = 2;
            this.uploadTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uploadTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uploadTableLayoutPanel.Size = new System.Drawing.Size(343, 126);
            this.uploadTableLayoutPanel.TabIndex = 0;
            // 
            // uploadControl
            // 
            this.uploadControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uploadControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadControl.Location = new System.Drawing.Point(3, 3);
            this.uploadControl.Name = "uploadControl";
            this.uploadControl.Size = new System.Drawing.Size(337, 100);
            this.uploadControl.TabIndex = 0;
            this.uploadControl.Click += new System.EventHandler(this.uploadControl_Click);
            // 
            // uploadProgressBar
            // 
            this.uploadProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadProgressBar.Location = new System.Drawing.Point(3, 109);
            this.uploadProgressBar.Name = "uploadProgressBar";
            this.uploadProgressBar.Size = new System.Drawing.Size(337, 14);
            this.uploadProgressBar.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paperToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // paperToolStripMenuItem
            // 
            this.paperToolStripMenuItem.Image = global::Magazine.Properties.Resources.paper_small;
            this.paperToolStripMenuItem.Name = "paperToolStripMenuItem";
            this.paperToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.paperToolStripMenuItem.Text = "Paper";
            this.paperToolStripMenuItem.Click += new System.EventHandler(this.paperToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::Magazine.Properties.Resources.refresh1;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(407, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(314, 24);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
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
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "\"PDF files (*.pdf)|*.pdf|All files (*.*)|*.*\";";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 395);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.formTableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.Text = "VS Magazine";
            this.ResizeEnd += new System.EventHandler(this.UserForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.UserForm_SizeChanged);
            this.formTableLayoutPanel.ResumeLayout(false);
            this.papersGroupBox.ResumeLayout(false);
            this.papersTableLayoutPanel1.ResumeLayout(false);
            this.papersTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.papersDataListView)).EndInit();
            this.submissionsTableLayoutPanel.ResumeLayout(false);
            this.submissionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.submissionsDataListView)).EndInit();
            this.editorCommentGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.uploadGroupBox.ResumeLayout(false);
            this.uploadTableLayoutPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formTableLayoutPanel;
        private System.Windows.Forms.GroupBox papersGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel papersTableLayoutPanel1;
        private BrightIdeasSoftware.DataListView papersDataListView;
        private System.Windows.Forms.TableLayoutPanel submissionsTableLayoutPanel;
        private System.Windows.Forms.GroupBox submissionsGroupBox;
        private BrightIdeasSoftware.DataListView submissionsDataListView;
        private System.Windows.Forms.GroupBox editorCommentGroupBox;
        private System.Windows.Forms.TextBox editorCommentTextBox;
        private System.Windows.Forms.GroupBox uploadGroupBox;
        private Controls.UploadControl uploadControl;
        private System.Windows.Forms.TableLayoutPanel uploadTableLayoutPanel;
        private System.Windows.Forms.ProgressBar uploadProgressBar;
        private Khronos_PMS.View.CustomControls.PromptTextBox papersSearchPromptTextBox;
        private System.Windows.Forms.Button addPaperButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton userToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn titleColumn;
        private System.Windows.Forms.ImageList iconsImageList;
        private System.Windows.Forms.ToolStripMenuItem paperToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn timestampColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private BrightIdeasSoftware.OLVColumn statusColumn;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label editorLabel;
    }
}