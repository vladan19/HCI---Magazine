using Magazine.Controller;
using Magazine.View;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void passwordTextBox_PreviewKeyDown(Object sender, PreviewKeyDownEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                login();
        }

        private void loginButton_Click(Object sender, EventArgs e) {
            login();
        }

        private async void login() {
            if (errorTextLabel.Visible)
                errorTextLabel.Visible = false;

            String username = usernameTextBox.Text;
            String password = passwordTextBox.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)) {
                if (String.IsNullOrEmpty(username))
                    usernameTextBox.CreateGraphics().DrawRectangle(Pens.Red, 0, 0, usernameTextBox.Width - 1, usernameTextBox.Height - 1);
                if (String.IsNullOrEmpty(password))
                    passwordTextBox.CreateGraphics().DrawRectangle(Pens.Red, 0, 0, passwordTextBox.Width - 1, passwordTextBox.Height - 1);
            } else {
                bool isValid = false;
                progressBar.Visible = true;
                await Task.Run(() => { isValid = AccountController.Login(username, password); });
                if (isValid) {
                    DialogResult = DialogResult.OK;
                }
                else {
                    errorTextLabel.Text = "Wrong username/password combination";
                    errorTextLabel.Visible = true;
                }
                progressBar.Visible = false;
            }
        }

        private void cancelButton_Click(Object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void registerButton_Click(object sender, EventArgs e) {
            RegisterForm rf = new RegisterForm();
            rf.ShowDialog();
        }
    }
}