namespace CpS_420_Inception_Project
{
    partial class MainForm_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBadCheckMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managePaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.switchUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBadCheckButton = new System.Windows.Forms.Button();
            this.ManagePayments_Button = new System.Windows.Forms.Button();
            this.PrintLetters_Button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            this.editToolStripMenuItem,
            this.managePaymentsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.switchUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newBadCheckMenuItem
            // 
            this.newBadCheckMenuItem.Name = "newBadCheckMenuItem";
            this.newBadCheckMenuItem.Size = new System.Drawing.Size(178, 22);
            this.newBadCheckMenuItem.Text = "&New Bad Check";
            this.newBadCheckMenuItem.Click += new System.EventHandler(this.newBadCheckMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem1,
            this.checkToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // accountToolStripMenuItem1
            // 
            this.accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            this.accountToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.accountToolStripMenuItem1.Text = "Account";
            this.accountToolStripMenuItem1.Click += new System.EventHandler(this.accountToolStripMenuItem1_Click);
            // 
            // checkToolStripMenuItem1
            // 
            this.checkToolStripMenuItem1.Name = "checkToolStripMenuItem1";
            this.checkToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.checkToolStripMenuItem1.Text = "Check";
            this.checkToolStripMenuItem1.Click += new System.EventHandler(this.checkToolStripMenuItem1_Click);
            // 
            // managePaymentsToolStripMenuItem
            // 
            this.managePaymentsToolStripMenuItem.Enabled = false;
            this.managePaymentsToolStripMenuItem.Name = "managePaymentsToolStripMenuItem";
            this.managePaymentsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.managePaymentsToolStripMenuItem.Text = "Manage Payments";
            this.managePaymentsToolStripMenuItem.Click += new System.EventHandler(this.managePaymentsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Enabled = false;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.printToolStripMenuItem.Text = "&Print Letters";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // switchUserToolStripMenuItem
            // 
            this.switchUserToolStripMenuItem.Enabled = false;
            this.switchUserToolStripMenuItem.Name = "switchUserToolStripMenuItem";
            this.switchUserToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.switchUserToolStripMenuItem.Text = "&Log Out";
            this.switchUserToolStripMenuItem.Click += new System.EventHandler(this.switchUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Enabled = false;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Enabled = false;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
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
            this.ManagePayments_Button.Click += new System.EventHandler(this.ManagePayments_Button_Click);
            // 
            // PrintLetters_Button
            // 
            this.PrintLetters_Button.Enabled = false;
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
            // MainForm_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 249);
            this.Controls.Add(this.PrintLetters_Button);
            this.Controls.Add(this.ManagePayments_Button);
            this.Controls.Add(this.newBadCheckButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(307, 287);
            this.MinimumSize = new System.Drawing.Size(307, 287);
            this.Name = "MainForm_Form";
            this.Text = "Bad Check Tracker";
            this.Load += new System.EventHandler(this.MainForm_Form_Load);
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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button newBadCheckButton;
        private System.Windows.Forms.Button ManagePayments_Button;
        private System.Windows.Forms.ToolStripMenuItem switchUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePaymentsToolStripMenuItem;
        private System.Windows.Forms.Button PrintLetters_Button;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}

