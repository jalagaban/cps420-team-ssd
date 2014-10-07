using System;
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
    public partial class AddWindow : Form
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            email = emailTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        public string name { get; private set; }
        public string email { get; private set; }
    }
}
