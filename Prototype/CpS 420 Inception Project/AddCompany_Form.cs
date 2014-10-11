using System;
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
    public partial class AddCompany_Form : Form
    {
        public AddCompany_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Company has been successfully added to the database", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
