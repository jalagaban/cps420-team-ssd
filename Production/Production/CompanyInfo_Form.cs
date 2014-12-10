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
    public partial class CompanyInfo_Form : Form
    {
        public CompanyInfo_Form()
        {
            InitializeComponent();
        }

        private void CompanyInfo_Form_Load(object sender, EventArgs e)
        {
            UpdateFields();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Config config = Config.GlobalConfig;
            config.SetValue("company_name", nameTextBox.Text);
            config.SetValue("company_street", streetTextBox.Text);
            config.SetValue("company_city", cityTextBox.Text);
            config.SetValue("company_state", stateComboBox.Text);
            config.SetValue("company_zip", zipTextBox.Text);
            config.SetValue("company_phone", phoneTextBox.Text);
            config.SetValue("company_fee", feeField.Text);

            this.Close();
        }

        private void feeField_Enter(object sender, EventArgs e)
        {
            feeField.Select(0, feeField.Text.Length);
        }

        private void UpdateFields()
        {
            Config config = Config.GlobalConfig;
            nameTextBox.Text = config.GetValue("company_name");
            streetTextBox.Text = config.GetValue("company_street");
            cityTextBox.Text = config.GetValue("company_city");
            stateComboBox.Text = config.GetValue("company_state");
            zipTextBox.Text = config.GetValue("company_zip");
            phoneTextBox.Text = config.GetValue("company_phone");
            feeField.Text = config.GetValue("company_fee");
        }
    }
}
