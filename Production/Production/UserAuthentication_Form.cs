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
    public partial class UserAuthentication_Form : Form
    {
        public UserAuthentication_Form()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (UserName_Textbox.Text == "admin" & Password_Textbox.Text == "admin")
            {
                variables.admin = true;
            }
            else if (UserName_Textbox.Text == "user" & Password_Textbox.Text == "user")
            {
                variables.user = true;
            }
            this.DialogResult = DialogResult.OK;        
            this.Close();
        }

        private void UserAuthentication_Form_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }
    }
}
