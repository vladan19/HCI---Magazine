﻿using Magazine.Controller;
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
    public partial class HelperForm : Form {
        public HelperForm() {
            InitializeComponent();
            //todo Delete this form when finished
        }

        private void button1_Click(object sender, EventArgs e) {
            string firstname = firstnameTextBox.Text;
            string lastname = lastnameTextBox.Text;
            string email = emailTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            AccountController.RegisterUser(firstname, lastname, email, username, password, "Editor");
        }
    }
}