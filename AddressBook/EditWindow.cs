﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class EditWindow : Form
    {
        public string email;
        
        public EditWindow()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            email = textBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
