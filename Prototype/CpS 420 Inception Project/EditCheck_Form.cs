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
    public partial class EditCheck_Form : Form
    {
        public EditCheck_Form()
        {
            InitializeComponent();
            CheckAmount_Textbox.BringToFront();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this check?", "Delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                // Delete the check
                MessageBox.Show("Check successfully deleted.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();
            }
            else if (result == DialogResult.Cancel)
            {
                // Don't delete the check
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
