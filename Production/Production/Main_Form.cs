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
   
    public partial class MainForm_Form : Form
    {
        public MainForm_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserAuthentication();
            AddRecent();
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
                    CreateAdminInterface();
                    MessageBox.Show("User authenticated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (variables.user == true)
                {
                    editToolStripMenuItem.Enabled = false;
                    editRecentToolStripMenuItem.Enabled = false;
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

        private void CreateAdminInterface()
        {
            //Add user accounts menu option
            ToolStripMenuItem userAccounts = new ToolStripMenuItem("Manage Users");
            fileToolStripMenuItem.DropDownItems.Insert(6, userAccounts);
            fileToolStripMenuItem.DropDownItems.Insert(7, (new ToolStripSeparator()));
            userAccounts.Click += new EventHandler(userAccounts_Click);

            ////Add user accounts submenus
            //ToolStripMenuItem addUserAccount = new ToolStripMenuItem("Add User Account");
            //ToolStripMenuItem editUserAccount = new ToolStripMenuItem("Edit Existing Account");
            //userAccounts.DropDownItems.Add(addUserAccount);
            //userAccounts.DropDownItems.Add(editUserAccount);

            ////Create handler events for the two user account menu items
            //addUserAccount.Click += new EventHandler(addUserAccount_Click);
            //editUserAccount.Click += new EventHandler(editUserAccount_Click);

        }

        private void AddRecent()
        {
            //Create the tool strip items
            ToolStripMenuItem recentitem1 = new ToolStripMenuItem("Recent Item 1");
            ToolStripMenuItem recentitem2 = new ToolStripMenuItem("Recent Item 2");
            ToolStripMenuItem recentitem3 = new ToolStripMenuItem("Recent Item 3");
            ToolStripMenuItem recentitem4 = new ToolStripMenuItem("Recent Item 4");
            ToolStripMenuItem recentitem5 = new ToolStripMenuItem("Recent Item 5");

            //Add the tool strip items to existing menu
            editRecentToolStripMenuItem.DropDownItems.Add(recentitem1);
            editRecentToolStripMenuItem.DropDownItems.Add(recentitem2);
            editRecentToolStripMenuItem.DropDownItems.Add(recentitem3);
            editRecentToolStripMenuItem.DropDownItems.Add(recentitem4);
            editRecentToolStripMenuItem.DropDownItems.Add(recentitem5);

            //Create handlers for the click event of the created buttons
            recentitem1.Click += new EventHandler(recentitem1_Click);
            recentitem2.Click += new EventHandler(recentitem2_Click);
            recentitem3.Click += new EventHandler(recentitem3_Click);
            recentitem4.Click += new EventHandler(recentitem4_Click);
            recentitem5.Click += new EventHandler(recentitem5_Click);           
        }

        private void recentitem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You opened the most recent item", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void recentitem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You opened the second most recent item", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void recentitem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You opened the third most recent item", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void recentitem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You opened the fourth most recent item", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void recentitem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You opened the fifth most recent item", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void switchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
                        
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing...", "Print Letters", MessageBoxButtons.OK);
        }

        private void newbadcheck_Button_Click(object sender, EventArgs e)
        {
            AddCheck_Form acf = new AddCheck_Form();
            acf.ShowDialog();
        }

        private void checkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditCheck_Form ecf = new EditCheck_Form();
            ecf.ShowDialog();
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
