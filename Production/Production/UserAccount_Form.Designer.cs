namespace CpS_420_Inception_Project
{
    partial class UserAccount_Form
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
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.CashierNumber_Label = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.userNameComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdTextBox.Location = new System.Drawing.Point(100, 39);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.Size = new System.Drawing.Size(240, 22);
            this.pwdTextBox.TabIndex = 2;
            this.pwdTextBox.UseSystemPasswordChar = true;
            this.pwdTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // CashierNumber_Label
            // 
            this.CashierNumber_Label.AutoSize = true;
            this.CashierNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.CashierNumber_Label.Location = new System.Drawing.Point(21, 41);
            this.CashierNumber_Label.Name = "CashierNumber_Label";
            this.CashierNumber_Label.Size = new System.Drawing.Size(73, 20);
            this.CashierNumber_Label.TabIndex = 34;
            this.CashierNumber_Label.Text = "Password:";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.Username_Label.Location = new System.Drawing.Point(18, 13);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(76, 20);
            this.Username_Label.TabIndex = 32;
            this.Username_Label.Text = "Username:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.cancelButton.Location = new System.Drawing.Point(242, 181);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 40);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Enabled = false;
            this.acceptButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.acceptButton.Location = new System.Drawing.Point(34, 181);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(98, 40);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Create";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // userNameComboBox
            // 
            this.userNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.userNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.userNameComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameComboBox.FormattingEnabled = true;
            this.userNameComboBox.Location = new System.Drawing.Point(100, 12);
            this.userNameComboBox.Name = "userNameComboBox";
            this.userNameComboBox.Size = new System.Drawing.Size(240, 21);
            this.userNameComboBox.TabIndex = 1;
            this.userNameComboBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(100, 67);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(239, 22);
            this.firstNameTextBox.TabIndex = 3;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "First Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(100, 95);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(239, 22);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Last Name:";
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCheckBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.adminCheckBox.Location = new System.Drawing.Point(100, 123);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(103, 21);
            this.adminCheckBox.TabIndex = 5;
            this.adminCheckBox.Text = "Adminstrator";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            this.adminCheckBox.CheckedChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.deleteButton.Location = new System.Drawing.Point(138, 181);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(98, 40);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // UserAccount_Form
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(352, 233);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameComboBox);
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.CashierNumber_Label);
            this.Controls.Add(this.Username_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UserAccount_Form";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.UserAccount_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.Label CashierNumber_Label;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.ComboBox userNameComboBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.Button deleteButton;
    }
}