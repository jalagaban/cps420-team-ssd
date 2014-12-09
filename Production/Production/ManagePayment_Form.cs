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
    public partial class ManagePayment_Form : Form
    {
        private Check Check { get; set; }
        
        public ManagePayment_Form()
        {
            InitializeComponent();
        }

        private void ManagePayment_Form_Load(object sender, EventArgs e)
        {
            PopulateRoutingNumDropdown();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ComposeCheck();
            DatabaseAgent.DefaultAgent.UpdateCheck(Check);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fieldsChanged(object sender, EventArgs e)
        {
            bool noneEmptyFields = (routingNumComboBox.Text.Length > 0 &&
            accountNumComboBox.Text.Length > 0 &&
            checkNumComboBox.Text.Length > 0);

            bool validCheck = DatabaseAgent.DefaultAgent.CheckExists(Tuple.Create(routingNumComboBox.Text,
                                                                                    accountNumComboBox.Text,
                                                                                    checkNumComboBox.Text));

            if (saveButton.Enabled = noneEmptyFields && validCheck)
            {
                UpdateFields();
            }
        }

        private void UpdateFields()
        {
            Check = DatabaseAgent.DefaultAgent.GetCheck(Tuple.Create(routingNumComboBox.Text,
                                                                    accountNumComboBox.Text,
                                                                    checkNumComboBox.Text));
            paidCheckBox.Checked = Check.IsPaid;
        }

        private void ComposeCheck()
        {
            Check = DatabaseAgent.DefaultAgent.GetCheck(Tuple.Create(routingNumComboBox.Text,
                                                                    accountNumComboBox.Text,
                                                                    checkNumComboBox.Text));
            Check.IsPaid = paidCheckBox.Checked;
        }

        private void PopulateRoutingNumDropdown()
        {
            routingNumComboBox.Items.Clear();

            DatabaseAgent db = DatabaseAgent.DefaultAgent;
            List<Tuple<string, string, string>> keys = db.CheckKeys;
            string[] routingNums = keys.Select(x => x.Item1).ToArray();

            routingNumComboBox.Items.AddRange(routingNums);
        }

        private void PopulateAccountNumDropdown()
        {
            accountNumComboBox.Items.Clear();

            DatabaseAgent db = DatabaseAgent.DefaultAgent;
            string routingNum = (string)routingNumComboBox.Text;
            List<Tuple<string, string, string>> keys = db.CheckKeys;
            string[] accountNums = keys.Where(x => x.Item1.Equals(routingNum)).Select(x => x.Item2).ToArray();

            accountNumComboBox.Items.AddRange(accountNums);
        }

        private void PopulateCheckNumDropdown()
        {
            checkNumComboBox.Items.Clear();

            DatabaseAgent db = DatabaseAgent.DefaultAgent;
            List<Tuple<string, string, string>> checkKeys = db.CheckKeys;

            string routingNum = (string)routingNumComboBox.Text;
            string accountNum = (string)accountNumComboBox.Text;
            string[] checkNums = checkKeys.Where(x => x.Item1.Equals(routingNum) && x.Item2.Equals(accountNum)).Select(x => x.Item3).ToArray();

            checkNumComboBox.Items.AddRange(checkNums);
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
    }
}
