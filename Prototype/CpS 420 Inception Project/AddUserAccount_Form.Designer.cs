namespace CpS_420_Inception_Project
{
    partial class AddUserAccount_Form
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
            this.UserAccounts_Label = new System.Windows.Forms.Label();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.CashierNumber_Label = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Username_Combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UserAccounts_Label
            // 
            this.UserAccounts_Label.AutoSize = true;
            this.UserAccounts_Label.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAccounts_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.UserAccounts_Label.Location = new System.Drawing.Point(12, 9);
            this.UserAccounts_Label.Name = "UserAccounts_Label";
            this.UserAccounts_Label.Size = new System.Drawing.Size(240, 45);
            this.UserAccounts_Label.TabIndex = 1;
            this.UserAccounts_Label.Text = "User Accounts:";
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Textbox.Location = new System.Drawing.Point(98, 110);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(104, 22);
            this.Password_Textbox.TabIndex = 2;
            this.Password_Textbox.UseSystemPasswordChar = true;
            // 
            // CashierNumber_Label
            // 
            this.CashierNumber_Label.AutoSize = true;
            this.CashierNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.CashierNumber_Label.Location = new System.Drawing.Point(19, 112);
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
            this.Username_Label.Location = new System.Drawing.Point(16, 75);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(76, 20);
            this.Username_Label.TabIndex = 32;
            this.Username_Label.Text = "Username:";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.ForeColor = System.Drawing.Color.SteelBlue;
            this.Cancel_Button.Location = new System.Drawing.Point(158, 194);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(120, 40);
            this.Cancel_Button.TabIndex = 5;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Submit_Button
            // 
            this.Submit_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Submit_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Button.ForeColor = System.Drawing.Color.SteelBlue;
            this.Submit_Button.Location = new System.Drawing.Point(12, 194);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(121, 40);
            this.Submit_Button.TabIndex = 4;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.checkBox1.Location = new System.Drawing.Point(20, 151);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(245, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Force password change at next login.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Username_Combobox
            // 
            this.Username_Combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Username_Combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Username_Combobox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Combobox.FormattingEnabled = true;
            this.Username_Combobox.Location = new System.Drawing.Point(99, 73);
            this.Username_Combobox.Name = "Username_Combobox";
            this.Username_Combobox.Size = new System.Drawing.Size(103, 21);
            this.Username_Combobox.TabIndex = 1;
            // 
            // AddUserAccount_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 246);
            this.Controls.Add(this.Username_Combobox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.CashierNumber_Label);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.UserAccounts_Label);
            this.MaximumSize = new System.Drawing.Size(307, 285);
            this.MinimumSize = new System.Drawing.Size(307, 285);
            this.Name = "AddUserAccount_Form";
            this.Text = "Create/Modify User Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserAccounts_Label;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.Label CashierNumber_Label;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox Username_Combobox;
    }
}