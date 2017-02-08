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
    }
}
