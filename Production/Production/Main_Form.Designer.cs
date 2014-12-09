namespace CpS_420_Inception_Project
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBadCheckMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editChecksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePwdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetDatabaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBadCheckButton = new System.Windows.Forms.Button();
            this.ManagePayments_Button = new System.Windows.Forms.Button();
            this.PrintLetters_Button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(291, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBadCheckMenuItem,
            this.editMenuItem,
            this.managePaymentsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.logOutMenuItem,
            this.changePwdMenuItem,
            this.manageUsersMenuItem,
            this.toolStripSeparator2,
            this.resetDatabaseMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newBadCheckMenuItem
            // 
            this.newBadCheckMenuItem.Name = "newBadCheckMenuItem";
            this.newBadCheckMenuItem.Size = new System.Drawing.Size(187, 22);
            this.newBadCheckMenuItem.Text = "&New Bad Check...";
            this.newBadCheckMenuItem.Click += new System.EventHandler(this.newBadCheckMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editChecksMenuItem,
            this.editAccountsMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(187, 22);
            this.editMenuItem.Text = "Edit";
            // 
            // editChecksMenuItem
            // 
            this.editChecksMenuItem.Name = "editChecksMenuItem";
            this.editChecksMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editChecksMenuItem.Text = "&Checks...";
            this.editChecksMenuItem.Click += new System.EventHandler(this.editChecksMenuItem_Click);
            // 
            // editAccountsMenuItem
            // 
            this.editAccountsMenuItem.Name = "editAccountsMenuItem";
            this.editAccountsMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editAccountsMenuItem.Text = "&Accounts...";
            this.editAccountsMenuItem.Click += new System.EventHandler(this.editAccountsMenuItem_Click);
            // 
            // managePaymentsToolStripMenuItem
            // 
            this.managePaymentsToolStripMenuItem.Enabled = false;
            this.managePaymentsToolStripMenuItem.Name = "managePaymentsToolStripMenuItem";
            this.managePaymentsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.managePaymentsToolStripMenuItem.Text = "&Manage Payments...";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.printToolStripMenuItem.Text = "&Print Letters...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // logOutMenuItem
            // 
            this.logOutMenuItem.Name = "logOutMenuItem";
            this.logOutMenuItem.Size = new System.Drawing.Size(187, 22);
            this.logOutMenuItem.Text = "&Log Out";
            this.logOutMenuItem.Click += new System.EventHandler(this.logOutMenuItem_Click);
            // 
            // changePwdMenuItem
            // 
            this.changePwdMenuItem.Name = "changePwdMenuItem";
            this.changePwdMenuItem.Size = new System.Drawing.Size(187, 22);
            this.changePwdMenuItem.Text = "Change Password...";
            this.changePwdMenuItem.Click += new System.EventHandler(this.changePwdMenuItem_Click);
            // 
            // manageUsersMenuItem
            // 
            this.manageUsersMenuItem.Name = "manageUsersMenuItem";
            this.manageUsersMenuItem.Size = new System.Drawing.Size(187, 22);
            this.manageUsersMenuItem.Text = "Manage Users...";
            this.manageUsersMenuItem.Click += new System.EventHandler(this.manageUsersMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // resetDatabaseMenuItem
            // 
            this.resetDatabaseMenuItem.Name = "resetDatabaseMenuItem";
            this.resetDatabaseMenuItem.Size = new System.Drawing.Size(187, 22);
            this.resetDatabaseMenuItem.Text = "Reset Database";
            this.resetDatabaseMenuItem.Click += new System.EventHandler(this.resetDatabaseMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // newBadCheckButton
            // 
            this.newBadCheckButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBadCheckButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.newBadCheckButton.Location = new System.Drawing.Point(52, 47);
            this.newBadCheckButton.Name = "newBadCheckButton";
            this.newBadCheckButton.Size = new System.Drawing.Size(189, 44);
            this.newBadCheckButton.TabIndex = 1;
            this.newBadCheckButton.Text = "New Bad Check";
            this.newBadCheckButton.UseVisualStyleBackColor = true;
            this.newBadCheckButton.Click += new System.EventHandler(this.newBadCheckButton_Click);
            // 
            // ManagePayments_Button
            // 
            this.ManagePayments_Button.Enabled = false;
            this.ManagePayments_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagePayments_Button.ForeColor = System.Drawing.Color.SteelBlue;
            this.ManagePayments_Button.Location = new System.Drawing.Point(52, 116);
            this.ManagePayments_Button.Name = "ManagePayments_Button";
            this.ManagePayments_Button.Size = new System.Drawing.Size(189, 44);
            this.ManagePayments_Button.TabIndex = 2;
            this.ManagePayments_Button.Text = "Manage Payments";
            this.ManagePayments_Button.UseVisualStyleBackColor = true;
            // 
            // PrintLetters_Button
            // 
            this.PrintLetters_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintLetters_Button.ForeColor = System.Drawing.Color.SteelBlue;
            this.PrintLetters_Button.Location = new System.Drawing.Point(52, 185);
            this.PrintLetters_Button.Name = "PrintLetters_Button";
            this.PrintLetters_Button.Size = new System.Drawing.Size(189, 44);
            this.PrintLetters_Button.TabIndex = 3;
            this.PrintLetters_Button.Text = "Print Letters";
            this.PrintLetters_Button.UseVisualStyleBackColor = true;
            this.PrintLetters_Button.Click += new System.EventHandler(this.PrintLetters_Button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 248);
            this.Controls.Add(this.PrintLetters_Button);
            this.Controls.Add(this.ManagePayments_Button);
            this.Controls.Add(this.newBadCheckButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(307, 287);
            this.MinimumSize = new System.Drawing.Size(307, 287);
            this.Name = "Main_Form";
            this.Text = "Check Processing System";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBadCheckMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editChecksMenuItem;
        private System.Windows.Forms.Button newBadCheckButton;
        private System.Windows.Forms.Button ManagePayments_Button;
        private System.Windows.Forms.ToolStripMenuItem logOutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePaymentsToolStripMenuItem;
        private System.Windows.Forms.Button PrintLetters_Button;
        private System.Windows.Forms.ToolStripMenuItem resetDatabaseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem changePwdMenuItem;
    }
}

