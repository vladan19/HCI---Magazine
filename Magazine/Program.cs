using Magazine.Controller;
using Magazine.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult loginRezultat;
            using (var loginForma = new LoginForm()) {
                loginRezultat = loginForma.ShowDialog();
            }

            if (loginRezultat == DialogResult.OK) {
                if (AccountController.User.GROUP_id == 1) {
                    Application.Run(new UserForm());
                }
                else if (AccountController.User.GROUP_id == 2) {
                    Application.Run(new EditorForm());
                }
                else if(AccountController.User.GROUP_id == 3) {
                    Application.Run(new ReviewerForm());
                }
            }
        }
    }
}
