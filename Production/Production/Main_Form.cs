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
    }

    class variables
    {
        public static bool loginstatus = false;
        public static bool admin = false;
        public static bool user = false;
    }
}
