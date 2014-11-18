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
   
    public partial class MainForm_Form : Form
    {
        public MainForm_Form()
        {
            InitializeComponent();
        }
        private void MainForm_Form_Load(object sender, EventArgs e)
        {
        }

        private void ShowNewBadCheckWindow()
        {
            Check_Form form = new Check_Form(Check_Form.ActionMode.Create);
            form.ShowDialog();
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

        private void resetDatabaseMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseAgent.DefaultAgent.ResetTestData();
        }




       private void UserAuthentication()
        {
            UserAuthentication_Form frm = new UserAuthentication_Form();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.Cancel)
            {
                variables.loginstatus = false;
                this.Close();
            }
            else if (frm.DialogResult == DialogResult.OK)
            {
                if (variables.admin == true)
                {
                    MessageBox.Show("User authenticated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (variables.user == true)
                {
                    editToolStripMenuItem.Enabled = false;
                    managePaymentsToolStripMenuItem.Enabled = false;
                    ManagePayments_Button.Enabled = false;
                    MessageBox.Show("User authenticated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    variables.loginstatus = false;
                    MessageBox.Show("You failed to login. Please either use 'admin' as the username and password to access the adminstrator interface, or use 'user' as the username and password to access the user interface.", "Failure to login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserAuthentication();
                }
                
            }
        }

        private bool Authenticate()
       {
           variables.loginstatus = true;
           return true;
       }

        private void userAccounts_Click(object sender, EventArgs e)
        {
            //Open user accounts dialog
            AddUserAccount_Form auaf = new AddUserAccount_Form();
            auaf.ShowDialog();
        }

        private void addUserAccount_Click(object sender, EventArgs e)
        {
            //Handles adding user accounts to the software
        }

        private void editUserAccount_Click(object sender, EventArgs e)
        {
            //Handles editing existing user accounts
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void switchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
                        
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing...", "Print Letters", MessageBoxButtons.OK);
        }

        private void ManagePayments_Button_Click(object sender, EventArgs e)
        {
            ManagePayment_Form mpf = new ManagePayment_Form();
            mpf.ShowDialog();
        }


        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccount_Form aaf = new AddAccount_Form();
            aaf.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword_Form cpf = new ChangePassword_Form();
            cpf.ShowDialog();
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditAccount_Form eaf = new EditAccount_Form();
            eaf.ShowDialog();
        }

        private void PrintLetters_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing...", "Print Letters", MessageBoxButtons.OK);
        }

        private void managePaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePayment_Form mpf = new ManagePayment_Form();
            mpf.ShowDialog();
        }
    }

    class variables
    {
        public static bool loginstatus = false;
        public static bool admin = false;
        public static bool user = false;
    }
}
