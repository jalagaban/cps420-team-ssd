using System;
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
    public partial class ChangePassword_Form : Form
    {        
        public ChangePassword_Form()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            AuthenticationManager auth = AuthenticationManager.DefaultAuthenticationManager;
            User currentUser = auth.CurrentUser;
            currentUser.Password = newPwdTextBox.Text;
            auth.UpdateUser(currentUser);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fieldsChanged(object sender, EventArgs e)
        {
            bool noneEmptyFields = (oldPwdTextBox.Text.Length > 0 &&
                                    newPwdTextBox.Text.Length > 0 &&
                                    confirmPwdTextBox.Text.Length > 0);

            bool validOldPwd = oldPwdTextBox.Text.Equals(AuthenticationManager.DefaultAuthenticationManager.CurrentUser.Password);
            bool newPwdMatch = newPwdTextBox.Text.Equals(confirmPwdTextBox.Text);

            changeButton.Enabled = noneEmptyFields && validOldPwd && newPwdMatch;
        }
    }
}
