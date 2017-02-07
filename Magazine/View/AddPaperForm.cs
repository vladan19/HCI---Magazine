using Magazine.Controller;
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
    public partial class AddPaperForm : Form {
        public AddPaperForm() {
            InitializeComponent();
            //todo Edit title column in database to text
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e) {
            string title = titleTextBox.Text;
            if (FormUtility.textBoxNotValid(titleTextBox)) {
                return;
            }
            if (openFileDialog.FileName == "") {
                MessageBox.Show("You must select file for upload!", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AddPaper(title);
        }

        private async void AddPaper(string title) {
            progressBar.Visible = true;
            await Task.Run(() => { PaperController.AddPaper(title, openFileDialog.FileName); });
            MessageBox.Show("Paper added successfully!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar.Visible = false;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void uploadControl_Click(object sender, EventArgs e) {
            var result = openFileDialog.ShowDialog();
        }
    }
}
