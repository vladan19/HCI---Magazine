using BrightIdeasSoftware;
using Magazine.Controller;
using Magazine.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine.View {
    public partial class ReviewerForm : Form {
        private object lastSelected;
        public ReviewerForm() {
            InitializeComponent();
            tableLayoutPanel.RowStyles[3].Height = 0;
            int statusOffset = 2;
            userToolStripDropDownButton.Text = AccountController.User.Username;
            reviewsDataListView.GetColumn(0).ImageGetter = i => 0;
            reviewsDataListView.GetColumn(1).ImageGetter = i => 1;
            reviewsDataListView.GetColumn(2).ImageGetter = i => 2;
            reviewsDataListView.GetColumn(3).ImageGetter = r => StatusUtility.newIDReview((r as review).STATUS_id) + statusOffset;
            reviewsDataListView.GetColumn(3).AspectToStringConverter = s => StatusUtility.NameReview((int)s);
            reviewsDataListView.GetColumn(1).AspectToStringConverter = delegate (object x) {
                user u = (x as user);
                return u.Firstname + " " + u.Lastname;
            };
            reviewsDataListView.DataSource = PaperController.GetReviewPapers(AccountController.User);
            reviewsDataListView.AutoResizeColumns();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Restart();
        }

        private void acceptToolStripMenuItem_Click(object sender, EventArgs e) {
            commentToolStripDropDownButton.Text = "Accept";
        }

        private void rejectToolStripMenuItem_Click(object sender, EventArgs e) {
            commentToolStripDropDownButton.Text = "Reject";
        }

        private void searchPapersPromptTextBox_TextChanged(object sender, EventArgs e) {
            allRadioButton.Checked = true;
            reviewsDataListView.ModelFilter = new ModelFilter(x => {
                var myReview = x as review;
                return x != null && (myReview.file.paper.Title.ToLower().Contains(searchPapersPromptTextBox.Text.ToLower()));
            });
        }

        private void saveButton_Click(object sender, EventArgs e) {
            ReviewCompleted();
        }

        private async void ReviewCompleted() {
            if(commentToolStripDropDownButton.Text=="Select review status") {
                MessageBox.Show("You must select some option for review!", "Review error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tableLayoutPanel.RowStyles[3].Height = 20;
            string status = commentToolStripDropDownButton.Text;
            string comment = reviewTextBox.Text;
            review selectedReview = (review)reviewsDataListView.SelectedObject;
            await Task.Run(() => { PaperController.ReviewCompleted(selectedReview, comment, status); });
            reviewsDataListView.BuildList();
            tableLayoutPanel.RowStyles[3].Height = 0;
            MessageBox.Show("Review saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newRadioButton_CheckedChanged(object sender, EventArgs e) {
            reviewsDataListView.ModelFilter = new ModelFilter(x => {
                var myReview = x as review;
                return x != null && (myReview.STATUS_id==2);
            });
        }

        private void completedRadioButton_CheckedChanged(object sender, EventArgs e) {
            reviewsDataListView.ModelFilter = new ModelFilter(x => {
                var myReview = x as review;
                return x != null && (myReview.STATUS_id != 2);
            });
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e) {
            reviewsDataListView.ModelFilter = null;
        }

        private void openButton_Click(object sender, EventArgs e) {
            tableLayoutPanel.RowStyles[3].Height = 20;
            int idFile = ((review)reviewsDataListView.SelectedObject).FILE_id;
            byte[] file = PaperController.GetFile(idFile);
            string filename = "paper" + ".pdf";
            var tempFolder = System.IO.Path.GetTempPath();
            filename = System.IO.Path.Combine(tempFolder, filename);
            System.IO.File.WriteAllBytes(filename, file);
            Process.Start(filename);
            tableLayoutPanel.RowStyles[3].Height = 0;
        }

        private void papersDataListView_SelectionChanged(object sender, EventArgs e) {
            review selectedReview = (review)reviewsDataListView.SelectedObject;
            if (selectedReview == null) {
                reviewsDataListView.SelectedObject = lastSelected;
                return;
            }
            lastSelected = reviewsDataListView.SelectedObject;
            reviewTextBox.Text = selectedReview.Comment;
            commentToolStripDropDownButton.Text = "Select review status";
            if (selectedReview.STATUS_id != 2) {
                completedReviewVisibility();
                if (selectedReview.STATUS_id == 3) {
                    acceptToolStripMenuItem.PerformClick();
                }
                else {
                    rejectToolStripMenuItem.PerformClick();
                }
            }
            else {
                notcompltedReviewVisibility();
            }
        }

        private void notcompltedReviewVisibility() {
            reviewTextBox.ReadOnly = false;
            commentToolStripDropDownButton.Enabled = true;
            saveButton.Enabled = true;
        }

        private void completedReviewVisibility() {
            reviewTextBox.ReadOnly = true;
            commentToolStripDropDownButton.Enabled = false;
            saveButton.Enabled = false;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
            PaperController.RefreshModel();
            reviewsDataListView.DataSource = PaperController.GetReviewPapers(AccountController.User);
            reviewsDataListView.BuildList();
        }
    }
}
