namespace Magazine.View {
    partial class AddPaperForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPaperForm));
            this.addPaperGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleGroupBox = new System.Windows.Forms.GroupBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addPaperGroupBox.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.titleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPaperGroupBox
            // 
            this.addPaperGroupBox.Controls.Add(this.tableLayoutPanel);
            this.addPaperGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPaperGroupBox.Location = new System.Drawing.Point(0, 0);
            this.addPaperGroupBox.Name = "addPaperGroupBox";
            this.addPaperGroupBox.Size = new System.Drawing.Size(558, 276);
            this.addPaperGroupBox.TabIndex = 0;
            this.addPaperGroupBox.TabStop = false;
            this.addPaperGroupBox.Text = "Add paper";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.Controls.Add(this.titleGroupBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.progressBar, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.cancelButton, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.browseButton, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.filenameTextBox, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(552, 257);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // titleGroupBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.titleGroupBox, 3);
            this.titleGroupBox.Controls.Add(this.titleTextBox);
            this.titleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleGroupBox.Location = new System.Drawing.Point(3, 3);
            this.titleGroupBox.Name = "titleGroupBox";
            this.titleGroupBox.Size = new System.Drawing.Size(546, 191);
            this.titleGroupBox.TabIndex = 0;
            this.titleGroupBox.TabStop = false;
            this.titleGroupBox.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTextBox.Location = new System.Drawing.Point(3, 16);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(540, 172);
            this.titleTextBox.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 230);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(386, 24);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 2;
            this.progressBar.Visible = false;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(395, 230);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(74, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(475, 230);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.browseButton.Location = new System.Drawing.Point(475, 200);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(74, 24);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // filenameTextBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.filenameTextBox, 2);
            this.filenameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filenameTextBox.Location = new System.Drawing.Point(3, 200);
            this.filenameTextBox.Multiline = true;
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.ReadOnly = true;
            this.filenameTextBox.Size = new System.Drawing.Size(466, 24);
            this.filenameTextBox.TabIndex = 6;
            this.filenameTextBox.Text = "File path";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"PDF files (*.pdf)|*.pdf|All files (*.*)|*.*\";";
            // 
            // AddPaperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 276);
            this.Controls.Add(this.addPaperGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPaperForm";
            this.Text = "Add new paper";
            this.addPaperGroupBox.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.titleGroupBox.ResumeLayout(false);
            this.titleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addPaperGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox titleGroupBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox filenameTextBox;
    }
}