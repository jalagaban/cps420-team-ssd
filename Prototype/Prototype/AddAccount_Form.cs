﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpS_420_Inception_Project
{
    public partial class AddAccount_Form : Form
    {
        public AddAccount_Form()
        {
            InitializeComponent();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
