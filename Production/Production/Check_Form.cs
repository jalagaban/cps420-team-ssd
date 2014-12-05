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
    public partial class Check_Form : Form
    {
        public enum ActionMode { Create, Edit }

        private ActionMode mode;

        private ActionMode Mode {
            get
            {
                return mode;
            }
            set 
            {
                mode = value;
                if (value == ActionMode.Edit)
                {
                    Text = "Edit Check";
                    acceptButton1.Visible = true;
                    acceptButton1.Text = "Save";
                    acceptButton2.Text = "Delete";
                    AcceptButton = acceptButton1;
                }
            } 
        }

        private bool SuppressFieldsChangedEvents { get; set; }

        private Check check { get; set; }

        public Check_Form(ActionMode mode)
        {
            InitializeComponent();
            Mode = mode;
            if (Mode == ActionMode.Create)
            {
                checkNumComboBox.DropDownStyle = ComboBoxStyle.Simple;
            }
        }

        private void Check_Form_Load(object sender, EventArgs e)
        {
            PopulateRoutingNumDropdown();
            PopulateStoreNumDropdown();
        }

        private void acceptButton1_Click(object sender, EventArgs e)
        {
            UpdateCheck();
        }

        private void acceptButton2_Click(object sender, EventArgs e)
        {
            if (mode == ActionMode.Create)
            {
                AddCheck();
            }
            else
            {
                DeleteCheck();
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
                checkNumComboBox.Text.Length > 0 &&
                storeNumComboBox.Text.Length > 0 &&
                cashierNumTextBox.Text.Length > 0);

                bool validCheck = DatabaseAgent.DefaultAgent.CheckExists(Tuple.Create(routingNumComboBox.Text,
                                                                                      accountNumComboBox.Text,
                                                                                      checkNumComboBox.Text));

                if (mode == ActionMode.Create)
                {
                    acceptButton2.Enabled = noneEmptyFields && !validCheck;
                }
                else
                {
                    acceptButton1.Enabled = noneEmptyFields && validCheck;
                    if (acceptButton2.Enabled = validCheck)
                    {
                        UpdateFields();
                    }
                }
            }
        }

        private void UpdateFields()
        {
            check = DatabaseAgent.DefaultAgent.GetCheck(Tuple.Create(routingNumComboBox.Text,
                                                                    accountNumComboBox.Text,
                                                                    checkNumComboBox.Text));
            amountField.Value = (decimal)(check.Amount / 100.0);
            datePicker.Value = check.Date;
            storeNumComboBox.Text = check.StoreID;
            cashierNumTextBox.Text = check.CashierID;
        }

        private void AddCheck()
        {
            ComposeCheck();

            bool validAccount = DatabaseAgent.DefaultAgent.AccountExists(check.AccountKey);
            Account_Form form = new Account_Form(Account_Form.ActionMode.Create);
            if (!validAccount)
            {
                form.ShowDialog();
            }

            if (form.DialogResult == DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                DatabaseAgent.DefaultAgent.AddCheck(check);
                this.DialogResult = DialogResult.OK;
            }
            
            Close();
        }

        private void UpdateCheck()
        {
            ComposeCheck();
            DatabaseAgent.DefaultAgent.UpdateCheck(check);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void DeleteCheck()
        {
            DatabaseAgent.DefaultAgent.DeleteCheck(Tuple.Create(routingNumComboBox.Text,
                                                                accountNumComboBox.Text,
                                                                checkNumComboBox.Text));

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void ComposeCheck()
        {
            check = new Check();
            check.RoutingNum = routingNumComboBox.Text;
            check.AccountNum = accountNumComboBox.Text;
            check.CheckNum = checkNumComboBox.Text;
            check.Amount = (int)(100 * (float)amountField.Value);
            check.Date = datePicker.Value;
            check.IsPaid = false;
            check.StoreID = storeNumComboBox.Text;
            check.CashierID = cashierNumTextBox.Text;
        }

        private void PopulateRoutingNumDropdown()
        {
            routingNumComboBox.Items.Clear();            
            
            DatabaseAgent db = DatabaseAgent.DefaultAgent;
            string[] routingNums;

            if (mode == ActionMode.Create)
            {
                List<Tuple<string, string>> keys = db.AccountKeys;
                routingNums = keys.Select(x => x.Item1).ToArray();
            }
            else
            {
                List<Tuple<string, string, string>> keys = db.CheckKeys;
                routingNums = keys.Select(x => x.Item1).ToArray();
            }
            
            routingNumComboBox.Items.AddRange(routingNums);
        }

        private void PopulateAccountNumDropdown()
        {
            accountNumComboBox.Items.Clear();            

            DatabaseAgent db = DatabaseAgent.DefaultAgent;
            string routingNum = (string)routingNumComboBox.Text;
            string[] accountNums;

            if (mode == ActionMode.Create)
            {
                List<Tuple<string, string>> keys = db.AccountKeys;
                accountNums = keys.Where(x => x.Item1.Equals(routingNum)).Select(x => x.Item2).ToArray();
            }
            else
            {
                List<Tuple<string, string, string>> keys = db.CheckKeys;
                accountNums = keys.Where(x => x.Item1.Equals(routingNum)).Select(x => x.Item2).ToArray();
            }

            accountNumComboBox.Items.AddRange(accountNums);
        }

        private void PopulateCheckNumDropdown()
        {
            if (mode == ActionMode.Edit)
            {
                checkNumComboBox.Items.Clear();

                DatabaseAgent db = DatabaseAgent.DefaultAgent;
                List<Tuple<string, string, string>> checkKeys = db.CheckKeys;

                string routingNum = (string)routingNumComboBox.Text;
                string accountNum = (string)accountNumComboBox.Text;
                string[] checkNums = checkKeys.Where(x => x.Item1.Equals(routingNum) && x.Item2.Equals(accountNum)).Select(x => x.Item3).ToArray();

                checkNumComboBox.Items.AddRange(checkNums);
            }
        }

        private void PopulateStoreNumDropdown()
        {
            storeNumComboBox.Items.Clear();
            
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            string[] storeNums = db.StoreKeys.ToArray();
            storeNumComboBox.Items.AddRange(storeNums);
        }

        private void routingNumComboBox_Leave(object sender, EventArgs e)
        {
            PopulateAccountNumDropdown();
            PopulateCheckNumDropdown();
        }

        private void accountNumComboBox_Leave(object sender, EventArgs e)
        {
            PopulateCheckNumDropdown();
        }

        private void amountField_Enter(object sender, EventArgs e)
        {
            amountField.Select(0, amountField.Text.Length);
        }
    }
}
