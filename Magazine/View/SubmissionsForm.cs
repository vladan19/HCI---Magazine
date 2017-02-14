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
    public partial class SubmissionsForm : Form {
        private paper paper;
        private object lastSelected;
        public SubmissionsForm(paper p) {
            InitializeComponent();
            paper = p;
            submissionsDataListView.GetColumn(0).ImageGetter = i => 0;
            describedTaskRenderer.TitleFont = new Font(submissionsGroupBox.Font, FontStyle.Bold);
            describedTaskRenderer.DescriptionAspectName = "Comment";
            describedTaskRenderer.ImageList = reviewImageList;
            describedTaskRenderer.TitleDescriptionSpace = 6;
            reviewsDataListView.GetColumn(0).ImageGetter = r => 0;
            reviewsDataListView.GetColumn(0).AspectToStringConverter = delegate (object x) {
                user u = (x as user);
                return u.Firstname + " " + u.Lastname;
            };
            submissionsDataListView.DataSource = PaperController.GetSubmissions(paper);
        }

        private void submissionsDataListView_SelectionChanged(object sender, EventArgs e) {
            file selectedSubmission = (file)submissionsDataListView.SelectedObject;
            if (selectedSubmission == null) {
                submissionsDataListView.SelectedObject = lastSelected;
                return;
            }
            lastSelected = submissionsDataListView.SelectedObject;
            commentTextBox.Text = selectedSubmission.EditorComment;
            reviewsDataListView.DataSource = PaperController.GetReviews(selectedSubmission);
        }
    }
}
