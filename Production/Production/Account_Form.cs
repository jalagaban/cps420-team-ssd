using Production;
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
    public partial class Account_Form : Form
    {
        public enum ActionMode { Create, Edit }

        private ActionMode mode;

        private ActionMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
                if (value == ActionMode.Edit)
                {
                    Text = "Edit Account";
                    acceptButton1.Visible = true;
                    acceptButton1.Text = "Save";
                    acceptButton2.Text = "Delete";
                    AcceptButton = acceptButton1;
                }
            }
        }

        private bool SuppressFieldsChangedEvents { get; set; }

        private Account account { get; set; }

        public Account_Form(ActionMode mode)
        {
            InitializeComponent();
            SuppressFieldsChangedEvents = false;
            Mode = mode;
            if (Mode == ActionMode.Create)
            {
                routingNumComboBox.DropDownStyle = ComboBoxStyle.Simple;
                accountNumComboBox.DropDownStyle = ComboBoxStyle.Simple;
            }
        }

        public Account_Form(ActionMode mode, string routingNum, string accountNum) : this(mode)
        {
            routingNumComboBox.Text = routingNum;
            accountNumComboBox.Text = accountNum;
            if (Mode == ActionMode.Create)
            {
                routingNumComboBox.Enabled = false;
                accountNumComboBox.Enabled = false;
            }
        }

        private void Account_Form_Load(object sender, EventArgs e)
        {
            PopulateRoutingNumDropdown();
        }

        private void acceptButton1_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void acceptButton2_Click(object sender, EventArgs e)
        {
            if (mode == ActionMode.Create)
            {
                AddAccount();
            }
            else
            {
                DeleteAccount();
            }
        }

        private void fieldsChanged(object sender, EventArgs e)
        {
            if (SuppressFieldsChangedEvents)
            {
                SuppressFieldsChangedEvents = false;
            }
            else
            {
                bool noneEmptyFields = (routingNumComboBox.Text.Length > 0 &&
                    accountNumComboBox.Text.Length > 0 &&
                    firstNameTextBox.Text.Length > 0 &&
                    lastNameTextBox.Text.Length > 0 &&
                    streetTextBox.Text.Length > 0 &&
                    cityTextBox.Text.Length > 0 &&
                    stateComboBox.Text.Length > 0 &&
                    zipTextBox.Text.Length > 0);// &&
                    //phoneTextBox.Text.Length > 0);

                bool validAccount = DatabaseAgent.DefaultAgent.AccountExists(Tuple.Create(routingNumComboBox.Text,
                                                                                      accountNumComboBox.Text));

                if (mode == ActionMode.Create)
                {
                    acceptButton2.Enabled = noneEmptyFields && !validAccount;
                }
                else
                {
                    bool keyFieldsChanged = sender == routingNumComboBox ||
                                            sender == accountNumComboBox;
                    acceptButton1.Enabled = noneEmptyFields && validAccount;
                    if ((acceptButton2.Enabled = validAccount) && keyFieldsChanged)
                    {
                        SuppressFieldsChangedEvents = true;
                        UpdateFields();
                    }
                }
            }
        }

        private void AddAccount()
        {
            ComposeAccount();
            DatabaseAgent.DefaultAgent.AddAccount(account);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateAccount()
        {
            ComposeAccount();
            DatabaseAgent.DefaultAgent.UpdateAccount(account);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void DeleteAccount()
        {
            DatabaseAgent.DefaultAgent.DeleteAccount(Tuple.Create(routingNumComboBox.Text,
                                                                accountNumComboBox.Text));

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void ComposeAccount()
        {
            account = new Account();
            account.RoutingNum = routingNumComboBox.Text;
            account.AccountNum = accountNumComboBox.Text;
            account.FirstName = firstNameTextBox.Text;
            account.LastName = lastNameTextBox.Text;
            account.Street = streetTextBox.Text;
            account.City = cityTextBox.Text;
            account.State = stateComboBox.Text;
            account.Zipcode = zipTextBox.Text;
            account.PhoneNum = phoneTextBox.Text;
        }

        private void UpdateFields() 
        {
            account = DatabaseAgent.DefaultAgent.GetAccount(Tuple.Create(routingNumComboBox.Text,
                                                                    accountNumComboBox.Text));
            firstNameTextBox.Text = account.FirstName;
            lastNameTextBox.Text = account.LastName;
            streetTextBox.Text = account.Street;
            cityTextBox.Text = account.City;
            stateComboBox.Text = account.State;
            zipTextBox.Text = account.Zipcode;
            phoneTextBox.Text = account.PhoneNum;
        }

        private void PopulateRoutingNumDropdown()
        {
            if (mode == ActionMode.Edit)
            {
                routingNumComboBox.Items.Clear();

                DatabaseAgent db = DatabaseAgent.DefaultAgent;
                List<Tuple<string, string>> keys = db.AccountKeys;

                string[] routingNums = keys.Select(x => x.Item1).ToArray();
                routingNumComboBox.Items.AddRange(routingNums);
            }
        }

        private void PopulateAccountNumDropdown()
        {
            if (mode == ActionMode.Edit)
            {
                accountNumComboBox.Items.Clear();

                DatabaseAgent db = DatabaseAgent.DefaultAgent;
                string routingNum = (string)routingNumComboBox.Text;
                List<Tuple<string, string>> keys = db.AccountKeys;

                string[] accountNums = keys.Where(x => x.Item1.Equals(routingNum)).Select(x => x.Item2).ToArray();
                accountNumComboBox.Items.AddRange(accountNums);
            }
        }


        private void routingNumComboBox_Leave(object sender, EventArgs e)
        {
            PopulateAccountNumDropdown();
        }
    }
}
