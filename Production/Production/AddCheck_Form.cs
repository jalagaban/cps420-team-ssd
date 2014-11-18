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
    public partial class AddCheck_Form : Form
    {
        public Check check { get; set; }
        
        public AddCheck_Form()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            ComposeCheck();
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
    }
}
