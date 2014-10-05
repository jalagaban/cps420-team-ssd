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
    public partial class AddressBook : Form
    {
        public AddressBook()
        {
            InitializeComponent();
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            bool test = AddressEntryDAO.Instance.testConnection();
            if (test)
            {
                MessageBox.Show("Connected to the Database!", "Success Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("FAILURE!!", "Failure Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
