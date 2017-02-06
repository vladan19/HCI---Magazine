using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine.Controller {
    class FormUtility {
        public static bool textBoxNotValid(Control t) {
            if (String.IsNullOrEmpty(t.Text)) {
                t.CreateGraphics().DrawRectangle(Pens.Red, 0, 0, t.Width - 1, t.Height - 1);
                return true;
            }
            return false;
        }

        public static void resetForm(Form f) {
            foreach (var item in f.Controls) {
                if (item is TextBox) {
                    (item as TextBox).Text = "";
                }
            }
            f.Controls[0].Select();
        }
    }
}
