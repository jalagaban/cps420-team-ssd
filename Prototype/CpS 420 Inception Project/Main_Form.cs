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
                }
                MessageBox.Show("User authenticated.", "Success!", MessageBoxButtons.OK);
            }
            else
            {
                variables.loginstatus = false;
                MessageBox.Show("Somehow you didn't choose any options....", "BUG!!!");
            }
        }

        private bool Authenticate()
       {
           variables.loginstatus = true;
           return true;
       }

        private void CreateAdminInterface()
        {
            ToolStripMenuItem userAccounts = new ToolStripMenuItem("User Accounts");
            //fileToolStripMenuItem.DropDownItems.Add(userAccounts);
            fileToolStripMenuItem.DropDownItems.Insert(6, userAccounts);
            fileToolStripMenuItem.DropDownItems.Insert(7, (new ToolStripSeparator()));
            userAccounts.Click += new EventHandler(userAccounts_Click);
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

        public void recentitem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You opened the most recent item", "Success!", MessageBoxButtons.OK);
        }

        public void recentitem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You opened the second most recent item", "Success!", MessageBoxButtons.OK);
        }

        public void recentitem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You opened the third most recent item", "Success!", MessageBoxButtons.OK);
        }

        public void recentitem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You opened the fourth most recent item", "Success!", MessageBoxButtons.OK);
        }

        public void recentitem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You opened the fifth most recent item", "Success!", MessageBoxButtons.OK);
        }

        public void userAccounts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create and modify user accounts here");
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
            //Insert code to print reports
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCompany_Form newcomp = new AddCompany_Form();
            newcomp.ShowDialog();
        }

        private void newbadcheck_Button_Click(object sender, EventArgs e)
        {
            AddCheck_Form acf = new AddCheck_Form();
            acf.ShowDialog();
        }
    }

    class variables
    {
        public static bool loginstatus = false;
        public static bool admin = false;
    }
}
