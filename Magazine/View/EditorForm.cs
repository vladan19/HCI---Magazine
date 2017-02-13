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
    public partial class EditorForm : Form {
        public EditorForm() {
            InitializeComponent();
            int statusOffest = 1;
            userToolStripDropDownButton.Text = AccountController.User.Username;
            papersDataListView.GetColumn(1).AspectToStringConverter = delegate (object x) {
                user u = (x as user);
                return u.Firstname + " " + u.Lastname;
            };
            papersDataListView.GetColumn(0).ImageGetter = i => 0;
            papersDataListView.GetColumn(1).ImageGetter = i => 1;
            papersDataListView.GetColumn(2).ImageGetter = p => StatusUtility.newIDEditor((p as paper).STATUS_id) + statusOffest;
            papersDataListView.DataSource = PaperController.GetPapers(AccountController.User);
            papersDataListView.AutoResizeColumns();
            describedTaskRenderer.TitleFont = new Font(papersGroupBox.Font, FontStyle.Bold);
            describedTaskRenderer.DescriptionAspectName = "Comment";
            describedTaskRenderer.ImageList = reviewImageList;
            describedTaskRenderer.TitleDescriptionSpace = 6;
            reviewsDataListView.GetColumn(0).ImageGetter = r => 0;
            reviewsDataListView.GetColumn(0).AspectToStringConverter = delegate (object x) {
                user u = (x as user);
                return u.Firstname + " " + u.Lastname;
            };
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Restart();
        }

        private void EditorForm_SizeChanged(object sender, EventArgs e) {
            papersDataListView.AutoResizeColumns();
        }

        private void openButton_Click(object sender, EventArgs e) {
            var paperId = ((paper)papersDataListView.SelectedObject).id;
            int idFile = PaperController.GetLatestVersion(paperId);
            byte[] file = PaperController.GetFile(idFile);
            string filename = "paper" + ".pdf";
            var tempFolder = System.IO.Path.GetTempPath();
            filename = System.IO.Path.Combine(tempFolder, filename);
            System.IO.File.WriteAllBytes(filename, file);
            Process.Start(filename);
        }

        private void papersSearchPromptTextBox_TextChanged(object sender, EventArgs e) {
            papersDataListView.ModelFilter = new ModelFilter(x => {
                var myPaper = x as paper;
                return x != null && (myPaper.Title.ToLower().Contains(papersSearchPromptTextBox.Text.ToLower()));
            });
        }

        private void reviewToolStripMenuItem_Click(object sender, EventArgs e) {
            commentToolStripDropDownButton.Text = ((ToolStripMenuItem)sender).Text;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e) {
            commentToolStripDropDownButton.Text = ((ToolStripMenuItem)sender).Text;
        }

        private void finalToolStripMenuItem_Click(object sender, EventArgs e) {
            commentToolStripDropDownButton.Text = ((ToolStripMenuItem)sender).Text;
        }

        private void publishToolStripMenuItem_Click(object sender, EventArgs e) {
            commentToolStripDropDownButton.Text = ((ToolStripMenuItem)sender).Text;
        }

        private void RejectToolStripMenuItem_Click(object sender, EventArgs e) {
            commentToolStripDropDownButton.Text = ((ToolStripMenuItem)sender).Text;
        }

        private void saveButton_Click(object sender, EventArgs e) {
            switch (commentToolStripDropDownButton.Text) {
                case "Send to review":
                    SendToReview();
                    break;
                case "Return to author":
                    ReturnToAuthor();
                    break;
                case "Return to final edit":
                    ReturnToFinalEdit();
                    break;
                case "Publish":
                    PublishPaper();
                    break;
                case "Reject":
                    RejectPaper();
                    break;
                default:
                    MessageBox.Show("You must select some action for paper!", "No action selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private async void RejectPaper() {
            paper selectedPaper = (paper)papersDataListView.SelectedObject;
            await Task.Run(() => { PaperController.Reject(selectedPaper, commentTextBox.Text); });
            MessageBox.Show("Paper rejected!", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void PublishPaper() {
            paper selectedPaper = (paper)papersDataListView.SelectedObject;
            await Task.Run(() => { PaperController.Publish(selectedPaper, commentTextBox.Text); });
            MessageBox.Show("Paper published!", "Published", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void ReturnToFinalEdit() {
            paper selectedPaper = (paper)papersDataListView.SelectedObject;
            await Task.Run(() => { PaperController.ReturnToFinalEdit(selectedPaper, commentTextBox.Text); });
            MessageBox.Show("Paper returned to final edit!", "Returned to final edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void ReturnToAuthor() {
            paper selectedPaper = (paper)papersDataListView.SelectedObject;
            await Task.Run(() => { PaperController.ReturnToAuthor(selectedPaper, commentTextBox.Text); });
            MessageBox.Show("Paper returned to author!", "Returned to author", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void SendToReview() {
            paper selectedPaper = (paper)papersDataListView.SelectedObject;
            await Task.Run(() => { PaperController.SendToReview(selectedPaper, commentTextBox.Text); });
            MessageBox.Show("Paper sent to review!", "Review", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (((RadioButton)sender).Checked) {
                papersDataListView.ModelFilter = new ModelFilter(x => {
                    var myPaper = x as paper;
                    return x != null && (myPaper.STATUS_id==1);
                });
            }
        }

        private void inProgressRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (((RadioButton)sender).Checked) {
                papersDataListView.ModelFilter = new ModelFilter(x => {
                    var myPaper = x as paper;
                    return x != null && (myPaper.STATUS_id != 1 && myPaper.STATUS_id!=9 && myPaper.STATUS_id!=10);
                });
            }
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (((RadioButton)sender).Checked) {
                papersDataListView.ModelFilter = null;
            }
        }

        private void papersDataListView_SelectionChanged(object sender, EventArgs e) {
            paper selectedPaper = (paper)papersDataListView.SelectedObject;
            commentTableLayoutPanel.RowStyles[1].Height = 0;
            commentTextBox.ReadOnly = true;
            if (selectedPaper == null) {
                return;
            }
            int fileId = PaperController.GetLatestVersion(selectedPaper.id);
            file lastFile = PaperController.GetFileDetails(fileId);
            commentTextBox.Text = lastFile.EditorComment;
            if (StatusUtility.newIDEditor(selectedPaper.STATUS_id) == 2) {
                NeedsAtentionVisibility(selectedPaper);
            }
            reviewsDataListView.SetObjects(PaperController.GetReviews(lastFile));
        }

        private void ResetMenuVisibility() {
            publishToolStripMenuItem.Visible = false;
            RejectToolStripMenuItem.Visible = false;
            returnToolStripMenuItem.Visible = false;
            reviewToolStripMenuItem.Visible = false;
            finalToolStripMenuItem.Visible = false;
        }

        private void NeedsAtentionVisibility(paper selectedPaper) {
            ResetMenuVisibility();
            commentTextBox.ReadOnly = false;
            commentTableLayoutPanel.RowStyles[1].Height = 30;
            if (selectedPaper.STATUS_id == 1 || selectedPaper.STATUS_id==6) {
                reviewToolStripMenuItem.Visible = true;
                returnToolStripMenuItem.Visible = true;
            }
            else if(selectedPaper.STATUS_id == 8) {
                publishToolStripMenuItem.Visible = true;
                RejectToolStripMenuItem.Visible = true;
            }
            else if (selectedPaper.STATUS_id == 4) {
                returnToolStripMenuItem.Visible = true;
                RejectToolStripMenuItem.Visible = true;
            }
            else {
                publishToolStripMenuItem.Visible = true;
                finalToolStripMenuItem.Visible = true;
                RejectToolStripMenuItem.Visible = true;
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
            PaperController.RefreshModel();
            papersDataListView.DataSource = PaperController.GetPapers(AccountController.User);
        }
    }
}
