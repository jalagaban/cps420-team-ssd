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
    public partial class ManagePayment_Form : Form
    {
        public ManagePayment_Form()
        {
            InitializeComponent();
            RemainderOwed_Textbox.BringToFront();
            PaymentAmount_Textbox.BringToFront();
        }

        private void ManagePayment_Form_Load(object sender, EventArgs e)
        {

        }

        private void PaymentAmount_Label_Click(object sender, EventArgs e)
        {

        }

        private void CheckAmount_Textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
