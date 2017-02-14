using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine.Controls {
    public partial class UploadControl : UserControl {
        public UploadControl() {
            InitializeComponent();
        }
        public new event EventHandler Click {
            add {
                base.Click += value;
                foreach (Control control in Controls) {
                    control.Click += value;
                    foreach (Control item in control.Controls) {
                        item.Click += value;
                    }
                }
            }
            remove {
                base.Click -= value;
                foreach (Control control in Controls) {
                    control.Click -= value;
                    foreach (Control item in control.Controls) {
                        item.Click -= value;
                    }
                }
            }
        }
    }
}
