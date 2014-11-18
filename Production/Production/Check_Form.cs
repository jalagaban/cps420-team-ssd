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

        private Check check { get; set; }

        public Check_Form(ActionMode mode)
        {
            InitializeComponent();
            Mode = mode;
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

        private void AddCheck()
        {
            ComposeCheck();
            DatabaseAgent.DefaultAgent.AddCheck(check);
            Close();
        }

        private void UpdateCheck()
        {
            ComposeCheck();
            DatabaseAgent.DefaultAgent.UpdateCheck(check);
            Close();
        }

        private void DeleteCheck()
        {
            DatabaseAgent.DefaultAgent.DeleteCheck(Tuple.Create(routingNumComboBox.Text,
                                                                accountNumComboBox.Text,
                                                                checkNumComboBox.Text));
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
    }
}
