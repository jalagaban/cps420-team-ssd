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
    public partial class UserAccount_Form : Form
    {
        private bool SuppressFieldsChangedEvents { get; set; }

        private User User { get; set; }
        private bool ValidUser { get; set; }
        
        public UserAccount_Form()
        {
            InitializeComponent();
        }

        private void UserAccount_Form_Load(object sender, EventArgs e)
        {
            PopulateUsernameDropdown();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            ComposeUser();

            if (ValidUser)
            {
                AuthenticationManager.DefaultAuthenticationManager.UpdateUser(User);
            }
            else
            {
                AuthenticationManager.DefaultAuthenticationManager.AddUser(User);
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            AuthenticationManager.DefaultAuthenticationManager.DeleteUser(userNameComboBox.Text);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fieldsChanged(object sender, EventArgs e)
        {
            if (SuppressFieldsChangedEvents)
            {
                SuppressFieldsChangedEvents = false;
            }
            else
            {
                bool noneEmptyFields = (userNameComboBox.Text.Length > 0 &&
                                        pwdTextBox.Text.Length > 0 &&
                                        firstNameTextBox.Text.Length > 0 &&
                                        lastNameTextBox.Text.Length > 0);

                ValidUser = AuthenticationManager.DefaultAuthenticationManager.UserExists(userNameComboBox.Text);

                if (ValidUser)
                {
                    acceptButton.Text = "Save";
                    deleteButton.Enabled = noneEmptyFields;

                    bool keyFieldsChanged = sender == userNameComboBox;
                    if (keyFieldsChanged) 
                    {
                        SuppressFieldsChangedEvents = true;
                        UpdateFields();
                    }

                }
                else
                {
                    acceptButton.Text = "Create";
                    deleteButton.Enabled = false;
                }

                acceptButton.Enabled = noneEmptyFields;
            }
        }

        private void ComposeUser()
        {
            User = new User();
            User.Username = userNameComboBox.Text;
            User.Password = pwdTextBox.Text;
            User.FirstName = firstNameTextBox.Text;
            User.LastName = lastNameTextBox.Text;
            User.IsAdmin = adminCheckBox.Checked;
        }

        private void UpdateFields()
        {
            User = AuthenticationManager.DefaultAuthenticationManager.GetUser(userNameComboBox.Text);
            pwdTextBox.Text = User.Password;
            firstNameTextBox.Text = User.FirstName;
            lastNameTextBox.Text = User.LastName;
            adminCheckBox.Checked = User.IsAdmin;
        }

        private void PopulateUsernameDropdown()
        {
            userNameComboBox.Items.Clear();

            AuthenticationManager auth = AuthenticationManager.DefaultAuthenticationManager;
            List<string> usernames = auth.UserNames;

            userNameComboBox.Items.AddRange(usernames.ToArray());
        }
    }
}
