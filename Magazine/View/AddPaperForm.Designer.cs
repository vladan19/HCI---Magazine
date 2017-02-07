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
            this.addPaperGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleGroupBox = new System.Windows.Forms.GroupBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.uploadControl = new Magazine.Controls.UploadControl();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel.Controls.Add(this.uploadControl, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.progressBar, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.cancelButton, 2, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.titleGroupBox.Size = new System.Drawing.Size(546, 107);
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
            this.titleTextBox.Size = new System.Drawing.Size(540, 88);
            this.titleTextBox.TabIndex = 0;
            // 
            // uploadControl
            // 
            this.uploadControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel.SetColumnSpan(this.uploadControl, 3);
            this.uploadControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadControl.Location = new System.Drawing.Point(3, 116);
            this.uploadControl.Name = "uploadControl";
            this.uploadControl.Size = new System.Drawing.Size(546, 107);
            this.uploadControl.TabIndex = 1;
            this.uploadControl.Click += new System.EventHandler(this.uploadControl_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 229);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(386, 25);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 2;
            this.progressBar.Visible = false;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(395, 229);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(74, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(475, 229);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            this.Name = "AddPaperForm";
            this.Text = "AddPaperForm";
            this.addPaperGroupBox.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.titleGroupBox.ResumeLayout(false);
            this.titleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addPaperGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox titleGroupBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private Controls.UploadControl uploadControl;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}