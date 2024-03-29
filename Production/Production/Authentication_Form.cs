﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Production;

namespace CpS_420_Inception_Project
{
    public partial class Authentication_Form : Form
    {
        public Authentication_Form()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextbox.Text;
            string password = passwordTextBox.Text;

            if (AuthenticationManager.DefaultAuthenticationManager.AttemptLogin(username, password))
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
                Owner.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Authentication_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
