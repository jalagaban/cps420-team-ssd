namespace CpS_420_Inception_Project
{
    partial class ChangePassword_Form
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.newPwdTextBox = new System.Windows.Forms.TextBox();
            this.CashierNumber_Label = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.oldPwdTextBox = new System.Windows.Forms.TextBox();
            this.confirmPwdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.cancelButton.Location = new System.Drawing.Point(183, 147);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 40);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.changeButton.Enabled = false;
            this.changeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.changeButton.Location = new System.Drawing.Point(65, 147);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(112, 40);
            this.changeButton.TabIndex = 4;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // newPwdTextBox
            // 
            this.newPwdTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPwdTextBox.Location = new System.Drawing.Point(138, 51);
            this.newPwdTextBox.Name = "newPwdTextBox";
            this.newPwdTextBox.Size = new System.Drawing.Size(157, 22);
            this.newPwdTextBox.TabIndex = 2;
            this.newPwdTextBox.UseSystemPasswordChar = true;
            this.newPwdTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // CashierNumber_Label
            // 
            this.CashierNumber_Label.AutoSize = true;
            this.CashierNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.CashierNumber_Label.Location = new System.Drawing.Point(26, 53);
            this.CashierNumber_Label.Name = "CashierNumber_Label";
            this.CashierNumber_Label.Size = new System.Drawing.Size(106, 20);
            this.CashierNumber_Label.TabIndex = 41;
            this.CashierNumber_Label.Text = "New Password:";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.Username_Label.Location = new System.Drawing.Point(32, 14);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(100, 20);
            this.Username_Label.TabIndex = 40;
            this.Username_Label.Text = "Old Password:";
            // 
            // oldPwdTextBox
            // 
            this.oldPwdTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPwdTextBox.Location = new System.Drawing.Point(138, 12);
            this.oldPwdTextBox.Name = "oldPwdTextBox";
            this.oldPwdTextBox.Size = new System.Drawing.Size(157, 22);
            this.oldPwdTextBox.TabIndex = 1;
            this.oldPwdTextBox.UseSystemPasswordChar = true;
            this.oldPwdTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // confirmPwdTextBox
            // 
            this.confirmPwdTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPwdTextBox.Location = new System.Drawing.Point(138, 89);
            this.confirmPwdTextBox.Name = "confirmPwdTextBox";
            this.confirmPwdTextBox.Size = new System.Drawing.Size(157, 22);
            this.confirmPwdTextBox.TabIndex = 3;
            this.confirmPwdTextBox.UseSystemPasswordChar = true;
            this.confirmPwdTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Retype Password:";
            // 
            // ChangePassword_Form
            // 
            this.AcceptButton = this.changeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(307, 199);
            this.Controls.Add(this.confirmPwdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldPwdTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.newPwdTextBox);
            this.Controls.Add(this.CashierNumber_Label);
            this.Controls.Add(this.Username_Label);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChangePassword_Form";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox newPwdTextBox;
        private System.Windows.Forms.Label CashierNumber_Label;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.TextBox oldPwdTextBox;
        private System.Windows.Forms.TextBox confirmPwdTextBox;
        private System.Windows.Forms.Label label1;
    }
}