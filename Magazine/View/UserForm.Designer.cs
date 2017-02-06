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
            this.addPaperButton = new System.Windows.Forms.Button();
            this.submissionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.submissionsGroupBox = new System.Windows.Forms.GroupBox();
            this.submissionsDataListView = new BrightIdeasSoftware.DataListView();
            this.editorCommentGroupBox = new System.Windows.Forms.GroupBox();
            this.editorCommentTextBox = new System.Windows.Forms.TextBox();
            this.uploadGroupBox = new System.Windows.Forms.GroupBox();
            this.uploadTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.userToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.titleColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.projectsSearchPromptTextBox = new Khronos_PMS.View.CustomControls.PromptTextBox();
            this.uploadControl1 = new Magazine.Controls.UploadControl();
            this.formTableLayoutPanel.SuspendLayout();
            this.papersGroupBox.SuspendLayout();
            this.papersTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.papersDataListView)).BeginInit();
            this.submissionsTableLayoutPanel.SuspendLayout();
            this.submissionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.submissionsDataListView)).BeginInit();
            this.editorCommentGroupBox.SuspendLayout();
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
            this.papersTableLayoutPanel1.ColumnCount = 1;
            this.papersTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.papersTableLayoutPanel1.Controls.Add(this.papersDataListView, 0, 1);
            this.papersTableLayoutPanel1.Controls.Add(this.addPaperButton, 0, 2);
            this.papersTableLayoutPanel1.Controls.Add(this.projectsSearchPromptTextBox, 0, 0);
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
            this.papersDataListView.AutoGenerateColumns = false;
            this.papersDataListView.CellEditUseWholeCell = false;
            this.papersDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColumn});
            this.papersDataListView.DataSource = null;
            this.papersDataListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.papersDataListView.FullRowSelect = true;
            this.papersDataListView.GridLines = true;
            this.papersDataListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.papersDataListView.HideSelection = false;
            this.papersDataListView.Location = new System.Drawing.Point(3, 28);
            this.papersDataListView.MultiSelect = false;
            this.papersDataListView.Name = "papersDataListView";
            this.papersDataListView.ShowGroups = false;
            this.papersDataListView.Size = new System.Drawing.Size(342, 280);
            this.papersDataListView.SmallImageList = this.iconsImageList;
            this.papersDataListView.TabIndex = 1;
            this.papersDataListView.UseCompatibleStateImageBehavior = false;
            this.papersDataListView.View = System.Windows.Forms.View.Details;
            // 
            // addPaperButton
            // 
            this.addPaperButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addPaperButton.Image = global::Magazine.Properties.Resources.add;
            this.addPaperButton.Location = new System.Drawing.Point(315, 314);
            this.addPaperButton.Name = "addPaperButton";
            this.addPaperButton.Size = new System.Drawing.Size(30, 29);
            this.addPaperButton.TabIndex = 3;
            this.addPaperButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addPaperButton.UseVisualStyleBackColor = true;
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
            this.submissionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.submissionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.submissionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.submissionsTableLayoutPanel.Size = new System.Drawing.Size(355, 365);
            this.submissionsTableLayoutPanel.TabIndex = 1;
            // 
            // submissionsGroupBox
            // 
            this.submissionsGroupBox.Controls.Add(this.submissionsDataListView);
            this.submissionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submissionsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.submissionsGroupBox.Name = "submissionsGroupBox";
            this.submissionsGroupBox.Size = new System.Drawing.Size(349, 115);
            this.submissionsGroupBox.TabIndex = 0;
            this.submissionsGroupBox.TabStop = false;
            this.submissionsGroupBox.Text = "Submissions";
            // 
            // submissionsDataListView
            // 
            this.submissionsDataListView.CellEditUseWholeCell = false;
            this.submissionsDataListView.DataSource = null;
            this.submissionsDataListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submissionsDataListView.Location = new System.Drawing.Point(3, 16);
            this.submissionsDataListView.Name = "submissionsDataListView";
            this.submissionsDataListView.Size = new System.Drawing.Size(343, 96);
            this.submissionsDataListView.TabIndex = 0;
            this.submissionsDataListView.UseCompatibleStateImageBehavior = false;
            this.submissionsDataListView.View = System.Windows.Forms.View.Details;
            // 
            // editorCommentGroupBox
            // 
            this.editorCommentGroupBox.Controls.Add(this.editorCommentTextBox);
            this.editorCommentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorCommentGroupBox.Location = new System.Drawing.Point(3, 124);
            this.editorCommentGroupBox.Name = "editorCommentGroupBox";
            this.editorCommentGroupBox.Size = new System.Drawing.Size(349, 115);
            this.editorCommentGroupBox.TabIndex = 1;
            this.editorCommentGroupBox.TabStop = false;
            this.editorCommentGroupBox.Text = "Editor comment";
            // 
            // editorCommentTextBox
            // 
            this.editorCommentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorCommentTextBox.Location = new System.Drawing.Point(3, 16);
            this.editorCommentTextBox.Multiline = true;
            this.editorCommentTextBox.Name = "editorCommentTextBox";
            this.editorCommentTextBox.ReadOnly = true;
            this.editorCommentTextBox.Size = new System.Drawing.Size(343, 96);
            this.editorCommentTextBox.TabIndex = 0;
            this.editorCommentTextBox.Text = "Editors opinion";
            // 
            // uploadGroupBox
            // 
            this.uploadGroupBox.Controls.Add(this.uploadTableLayoutPanel);
            this.uploadGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadGroupBox.Location = new System.Drawing.Point(3, 245);
            this.uploadGroupBox.Name = "uploadGroupBox";
            this.uploadGroupBox.Size = new System.Drawing.Size(349, 117);
            this.uploadGroupBox.TabIndex = 2;
            this.uploadGroupBox.TabStop = false;
            this.uploadGroupBox.Text = "Upload";
            // 
            // uploadTableLayoutPanel
            // 
            this.uploadTableLayoutPanel.ColumnCount = 1;
            this.uploadTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uploadTableLayoutPanel.Controls.Add(this.uploadControl1, 0, 0);
            this.uploadTableLayoutPanel.Controls.Add(this.progressBar1, 0, 1);
            this.uploadTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.uploadTableLayoutPanel.Name = "uploadTableLayoutPanel";
            this.uploadTableLayoutPanel.RowCount = 2;
            this.uploadTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uploadTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uploadTableLayoutPanel.Size = new System.Drawing.Size(343, 98);
            this.uploadTableLayoutPanel.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 81);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(337, 14);
            this.progressBar1.TabIndex = 1;
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
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paperToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
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
            // paperToolStripMenuItem
            // 
            this.paperToolStripMenuItem.Name = "paperToolStripMenuItem";
            this.paperToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.paperToolStripMenuItem.Text = "Paper";
            // 
            // iconsImageList
            // 
            this.iconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsImageList.ImageStream")));
            this.iconsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconsImageList.Images.SetKeyName(0, "paper.png");
            // 
            // titleColumn
            // 
            this.titleColumn.AspectName = "Title";
            // 
            // projectsSearchPromptTextBox
            // 
            this.projectsSearchPromptTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectsSearchPromptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.projectsSearchPromptTextBox.Location = new System.Drawing.Point(3, 3);
            this.projectsSearchPromptTextBox.Name = "projectsSearchPromptTextBox";
            this.projectsSearchPromptTextBox.Size = new System.Drawing.Size(342, 20);
            this.projectsSearchPromptTextBox.TabIndex = 2;
            this.projectsSearchPromptTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.projectsSearchPromptTextBox.WaterMarkText = "Type here to search";
            // 
            // uploadControl1
            // 
            this.uploadControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uploadControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadControl1.Location = new System.Drawing.Point(3, 3);
            this.uploadControl1.Name = "uploadControl1";
            this.uploadControl1.Size = new System.Drawing.Size(337, 72);
            this.uploadControl1.TabIndex = 0;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 395);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.formTableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.formTableLayoutPanel.ResumeLayout(false);
            this.papersGroupBox.ResumeLayout(false);
            this.papersTableLayoutPanel1.ResumeLayout(false);
            this.papersTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.papersDataListView)).EndInit();
            this.submissionsTableLayoutPanel.ResumeLayout(false);
            this.submissionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.submissionsDataListView)).EndInit();
            this.editorCommentGroupBox.ResumeLayout(false);
            this.editorCommentGroupBox.PerformLayout();
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
        private Controls.UploadControl uploadControl1;
        private System.Windows.Forms.TableLayoutPanel uploadTableLayoutPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Khronos_PMS.View.CustomControls.PromptTextBox projectsSearchPromptTextBox;
        private System.Windows.Forms.Button addPaperButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton userToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn titleColumn;
        private System.Windows.Forms.ImageList iconsImageList;
        private System.Windows.Forms.ToolStripMenuItem paperToolStripMenuItem;
    }
}