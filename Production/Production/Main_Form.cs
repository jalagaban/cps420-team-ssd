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
   
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            ShowAuthenticationDialog();
        }

        private void ShowNewBadCheckWindow()
        {
            Check_Form form = new Check_Form(Check_Form.ActionMode.Create);
            form.ShowDialog();
        }

        private void ShowAuthenticationDialog()
        {
            Authentication_Form form = new Authentication_Form();
            
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            } 
            else if (!AuthenticationManager.DefaultAuthenticationManager.CurrentUser.IsAdmin)
            {
                DisableAdmin();
            }
        }

        private void DisableAdmin()
        {
            ManagePayments_Button.Enabled = false;
            managePaymentsToolStripMenuItem.Enabled = false;
            PrintLetters_Button.Enabled = false;
            printToolStripMenuItem.Enabled = false;
            manageUsersMenuItem.Enabled = false;
            editMenuItem.Enabled = false;
        }

        private void newBadCheckButton_Click(object sender, EventArgs e)
        {
            ShowNewBadCheckWindow();
        }

        private void newBadCheckMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewBadCheckWindow();
        }

        private void editChecksMenuItem_Click(object sender, EventArgs e)
        {
            Check_Form form = new Check_Form(Check_Form.ActionMode.Edit);
            form.ShowDialog();
        }

        private void editAccountsMenuItem_Click(object sender, EventArgs e)
        {
            Account_Form form = new Account_Form(Account_Form.ActionMode.Edit);
            form.ShowDialog();
        }

        private void resetDatabaseMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseAgent.DefaultAgent.ResetTestData();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutMenuItem_Click(object sender, EventArgs e)
        {
            AuthenticationManager.DefaultAuthenticationManager.LogOut();
            this.Hide();
            this.Controls.Clear();
            this.InitializeComponent();
            ShowAuthenticationDialog();
        }

        private void PrintLetters_Button_Click(object sender, EventArgs e)
        {
            PrintLetters pl = PrintLetters.PrintAgent;
            pl.PrintDocuments();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintLetters pl = PrintLetters.PrintAgent;
            pl.PrintDocuments();
        private void changePwdMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword_Form form = new ChangePassword_Form();
            form.ShowDialog();
        }

        private void manageUsersMenuItem_Click(object sender, EventArgs e)
        {
            UserAccount_Form form = new UserAccount_Form();
            form.ShowDialog();
        }
    }

    class variables
    {
        public static bool loginstatus = false;
        public static bool admin = false;
        public static bool user = false;
    }
}
