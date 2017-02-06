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
    public partial class RegisterForm : Form {
        public RegisterForm() {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e) {
            registerUser();
        }

        private async void registerUser() {
            string firstName = firstnameTextBox.Text;
            string lastName = lastnameTextBox.Text;
            string email = emailTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmTextBox.Text;

            if (FormUtility.textBoxNotValid(firstnameTextBox) || FormUtility.textBoxNotValid(lastnameTextBox) || FormUtility.textBoxNotValid(emailTextBox) || FormUtility.textBoxNotValid(usernameTextBox) || FormUtility.textBoxNotValid(passwordTextBox) || FormUtility.textBoxNotValid(confirmTextBox)) {
                return;
            }
            else if (password != confirmPassword) {
                MessageBox.Show("Password and cofirm password fields must be the same!", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtility.resetForm(this);
            }
            else {
                bool result = false;
                progressBar.Visible = true;
                await Task.Run(() => { result = AccountController.RegisterUser(firstName, lastName, email, username, password, "Author"); });
                progressBar.Visible = false;
                if (result) {
                    MessageBox.Show("You are successfuly registered!", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else {
                    MessageBox.Show("You can't be registered, try using different username!", "Registration error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
