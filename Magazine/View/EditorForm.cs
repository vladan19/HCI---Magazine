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
            userToolStripDropDownButton.Text = AccountController.User.Username;
            papersDataListView.GetColumn(1).AspectToStringConverter = delegate (object x) {
                user u = (x as user);
                return u.Firstname + " " + u.Lastname;
            };
            papersDataListView.GetColumn(0).ImageGetter = i => 0;
            papersDataListView.GetColumn(1).ImageGetter = i => 1;
            papersDataListView.DataSource = PaperController.GetPapers(AccountController.User);
            papersDataListView.AutoResizeColumns();
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
    }
}
