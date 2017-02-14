namespace Magazine.View {
    partial class SubmissionsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmissionsForm));
            this.submissionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.submissionsGroupBox = new System.Windows.Forms.GroupBox();
            this.submissionsDataListView = new BrightIdeasSoftware.DataListView();
            this.timestampColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.iconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.commentGroupBox = new System.Windows.Forms.GroupBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.reviewsGroupBox = new System.Windows.Forms.GroupBox();
            this.reviewsDataListView = new BrightIdeasSoftware.DataListView();
            this.reviewerColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.describedTaskRenderer = new BrightIdeasSoftware.DescribedTaskRenderer();
            this.reviewImageList = new System.Windows.Forms.ImageList(this.components);
            this.submissionsTableLayoutPanel.SuspendLayout();
            this.submissionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.submissionsDataListView)).BeginInit();
            this.commentGroupBox.SuspendLayout();
            this.reviewsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDataListView)).BeginInit();
            this.SuspendLayout();
            // 
            // submissionsTableLayoutPanel
            // 
            this.submissionsTableLayoutPanel.ColumnCount = 2;
            this.submissionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.submissionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.submissionsTableLayoutPanel.Controls.Add(this.submissionsGroupBox, 0, 0);
            this.submissionsTableLayoutPanel.Controls.Add(this.commentGroupBox, 1, 0);
            this.submissionsTableLayoutPanel.Controls.Add(this.reviewsGroupBox, 1, 1);
            this.submissionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submissionsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.submissionsTableLayoutPanel.Name = "submissionsTableLayoutPanel";
            this.submissionsTableLayoutPanel.RowCount = 2;
            this.submissionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submissionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submissionsTableLayoutPanel.Size = new System.Drawing.Size(641, 316);
            this.submissionsTableLayoutPanel.TabIndex = 0;
            // 
            // submissionsGroupBox
            // 
            this.submissionsGroupBox.Controls.Add(this.submissionsDataListView);
            this.submissionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submissionsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.submissionsGroupBox.Name = "submissionsGroupBox";
            this.submissionsTableLayoutPanel.SetRowSpan(this.submissionsGroupBox, 2);
            this.submissionsGroupBox.Size = new System.Drawing.Size(294, 310);
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
            this.submissionsDataListView.Size = new System.Drawing.Size(288, 291);
            this.submissionsDataListView.SmallImageList = this.iconsImageList;
            this.submissionsDataListView.TabIndex = 1;
            this.submissionsDataListView.UseCompatibleStateImageBehavior = false;
            this.submissionsDataListView.View = System.Windows.Forms.View.Details;
            this.submissionsDataListView.SelectionChanged += new System.EventHandler(this.submissionsDataListView_SelectionChanged);
            // 
            // timestampColumn
            // 
            this.timestampColumn.AspectName = "Timestamp";
            this.timestampColumn.AutoCompleteEditor = false;
            this.timestampColumn.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.timestampColumn.FillsFreeSpace = true;
            this.timestampColumn.Groupable = false;
            this.timestampColumn.IsEditable = false;
            this.timestampColumn.Text = "Date of submission";
            this.timestampColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // iconsImageList
            // 
            this.iconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsImageList.ImageStream")));
            this.iconsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconsImageList.Images.SetKeyName(0, "date.png");
            // 
            // commentGroupBox
            // 
            this.commentGroupBox.Controls.Add(this.commentTextBox);
            this.commentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentGroupBox.Location = new System.Drawing.Point(303, 3);
            this.commentGroupBox.Name = "commentGroupBox";
            this.commentGroupBox.Size = new System.Drawing.Size(335, 152);
            this.commentGroupBox.TabIndex = 1;
            this.commentGroupBox.TabStop = false;
            this.commentGroupBox.Text = "Comment";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentTextBox.Location = new System.Drawing.Point(3, 16);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ReadOnly = true;
            this.commentTextBox.Size = new System.Drawing.Size(329, 133);
            this.commentTextBox.TabIndex = 0;
            // 
            // reviewsGroupBox
            // 
            this.reviewsGroupBox.Controls.Add(this.reviewsDataListView);
            this.reviewsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewsGroupBox.Location = new System.Drawing.Point(303, 161);
            this.reviewsGroupBox.Name = "reviewsGroupBox";
            this.reviewsGroupBox.Size = new System.Drawing.Size(335, 152);
            this.reviewsGroupBox.TabIndex = 2;
            this.reviewsGroupBox.TabStop = false;
            this.reviewsGroupBox.Text = "Reviews";
            // 
            // reviewsDataListView
            // 
            this.reviewsDataListView.AllColumns.Add(this.reviewerColumn);
            this.reviewsDataListView.AutoArrange = false;
            this.reviewsDataListView.AutoGenerateColumns = false;
            this.reviewsDataListView.BackColor = System.Drawing.SystemColors.Control;
            this.reviewsDataListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reviewsDataListView.CellEditUseWholeCell = false;
            this.reviewsDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reviewerColumn});
            this.reviewsDataListView.DataSource = null;
            this.reviewsDataListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewsDataListView.FullRowSelect = true;
            this.reviewsDataListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.reviewsDataListView.Location = new System.Drawing.Point(3, 16);
            this.reviewsDataListView.Name = "reviewsDataListView";
            this.reviewsDataListView.RowHeight = 60;
            this.reviewsDataListView.ShowGroups = false;
            this.reviewsDataListView.Size = new System.Drawing.Size(329, 133);
            this.reviewsDataListView.TabIndex = 1;
            this.reviewsDataListView.UseCompatibleStateImageBehavior = false;
            this.reviewsDataListView.View = System.Windows.Forms.View.Details;
            // 
            // reviewerColumn
            // 
            this.reviewerColumn.AspectName = "user";
            this.reviewerColumn.CellPadding = new System.Drawing.Rectangle(0, 0, 0, 3);
            this.reviewerColumn.FillsFreeSpace = true;
            this.reviewerColumn.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewerColumn.IsEditable = false;
            this.reviewerColumn.Renderer = this.describedTaskRenderer;
            this.reviewerColumn.Text = "Rewiever";
            // 
            // reviewImageList
            // 
            this.reviewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("reviewImageList.ImageStream")));
            this.reviewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.reviewImageList.Images.SetKeyName(0, "note.png");
            // 
            // SubmissionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 316);
            this.Controls.Add(this.submissionsTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubmissionsForm";
            this.Text = "Submissions";
            this.submissionsTableLayoutPanel.ResumeLayout(false);
            this.submissionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.submissionsDataListView)).EndInit();
            this.commentGroupBox.ResumeLayout(false);
            this.commentGroupBox.PerformLayout();
            this.reviewsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDataListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel submissionsTableLayoutPanel;
        private System.Windows.Forms.GroupBox submissionsGroupBox;
        private System.Windows.Forms.GroupBox commentGroupBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.GroupBox reviewsGroupBox;
        private BrightIdeasSoftware.DataListView reviewsDataListView;
        private BrightIdeasSoftware.OLVColumn reviewerColumn;
        private BrightIdeasSoftware.DescribedTaskRenderer describedTaskRenderer;
        private BrightIdeasSoftware.DataListView submissionsDataListView;
        private BrightIdeasSoftware.OLVColumn timestampColumn;
        private System.Windows.Forms.ImageList iconsImageList;
        private System.Windows.Forms.ImageList reviewImageList;
    }
}