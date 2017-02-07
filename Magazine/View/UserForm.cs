using BrightIdeasSoftware;
using Magazine.Controller;
using Magazine.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine.View {
    public partial class UserForm : Form {
        public UserForm() {
            InitializeComponent();
            int statusOffest = 1;
            uploadTableLayoutPanel.RowStyles[1].Height = 0;
            submissionsTableLayoutPanel.RowStyles[2].Height = 0;
            userToolStripDropDownButton.Text = AccountController.User.Username;
            papersDataListView.GetColumn(0).ImageGetter = i => 0;
            papersDataListView.GetColumn(1).ImageGetter = p => StatusUtility.newID((p as paper).STATUS_id) + statusOffest;
            papersDataListView.GetColumn(1).AspectToStringConverter = s => StatusUtility.Name((int)s);
            submissionsDataListView.GetColumn(0).ImageGetter = i => 1;
            papersDataListView.DataSource = PaperController.GetPapers(AccountController.User);
            papersDataListView.AutoResizeColumns();
            submissionsDataListView.AutoResizeColumns();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Restart();
        }

        private void papersDataListView_SelectionChanged(object sender, EventArgs e) {
            paper selectedPaper = (paper)papersDataListView.SelectedObject;
            if (selectedPaper == null) { return; }
            submissionsDataListView.DataSource = PaperController.GetSubmissions(selectedPaper);
            if(StatusUtility.Name(selectedPaper.STATUS_id)=="Needs attention") {
                submissionsTableLayoutPanel.RowStyles[2].Height = 150;
            }
        }

        private void submissionsDataListView_SelectionChanged(object sender, EventArgs e) {
            file selectedSubmission = (file)submissionsDataListView.SelectedObject;
            if (selectedSubmission == null) { return; }
            editorCommentTextBox.Text = selectedSubmission.EditorComment;
        }

        private void uploadControl_Click(object sender, EventArgs e) {
            var result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK) {
                UploadFile();
            }
        }

        private async void UploadFile() {
            uploadTableLayoutPanel.RowStyles[1].Height = 20;
            uploadProgressBar.Style = ProgressBarStyle.Marquee;
            paper selectedPaper = (paper)papersDataListView.SelectedObject;
            await Task.Run(() => { PaperController.UploadSubmission(selectedPaper, openFileDialog.FileName); });
            MessageBox.Show("Upload successful!", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uploadProgressBar.Style = ProgressBarStyle.Continuous;
            uploadTableLayoutPanel.RowStyles[1].Height = 0;
            submissionsDataListView.DataSource = PaperController.GetSubmissions(selectedPaper);
        }

        private void UserForm_ResizeEnd(object sender, EventArgs e) {
            //papersDataListView.AutoResizeColumns();
        }

        private void UserForm_SizeChanged(object sender, EventArgs e) {
            papersDataListView.AutoResizeColumns();
            submissionsDataListView.AutoResizeColumns();
        }

        private void projectsSearchPromptTextBox_TextChanged(object sender, EventArgs e) {
            papersDataListView.ModelFilter = new ModelFilter(x => {
                var myPaper = x as paper;
                return x != null && (myPaper.Title.ToLower().Contains(papersSearchPromptTextBox.Text.ToLower()));
            });
        }

        private void addPaperButton_Click(object sender, EventArgs e) {
            AddPaperForm apf = new AddPaperForm();
            var result = apf.ShowDialog();
            if (result == DialogResult.OK) {
                papersDataListView.DataSource = PaperController.GetPapers(AccountController.User);
            }
        }

        private void paperToolStripMenuItem_Click(object sender, EventArgs e) {
            addPaperButton.PerformClick();
        }
    }
}
