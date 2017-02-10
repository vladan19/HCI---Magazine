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
    public partial class ReviewerForm : Form {
        public ReviewerForm() {
            InitializeComponent();
            userToolStripDropDownButton.Text = AccountController.User.Username;
            papersDataListView.GetColumn(0).ImageGetter = i => 0;
            papersDataListView.GetColumn(1).ImageGetter = i => 1;
            papersDataListView.GetColumn(2).ImageGetter = i => 2;
            papersDataListView.GetColumn(1).AspectToStringConverter = delegate (object x) {
                user u = (x as user);
                return u.Firstname + " " + u.Lastname;
            };
            papersDataListView.DataSource = PaperController.GetReviewPapers(AccountController.User);
            papersDataListView.AutoResizeColumns();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Restart();
        }

        private void acceptToolStripMenuItem_Click(object sender, EventArgs e) {
            commentToolStrip.Text = "Accept";
        }

        private void rejectToolStripMenuItem_Click(object sender, EventArgs e) {
            commentToolStrip.Text = "Reject";
        }

        private void searchPapersPromptTextBox_TextChanged(object sender, EventArgs e) {
            papersDataListView.ModelFilter = new ModelFilter(x => {
                var myReview = x as review;
                return x != null && (myReview.file.paper.Title.ToLower().Contains(searchPapersPromptTextBox.Text.ToLower()));
            });
        }
    }
}
