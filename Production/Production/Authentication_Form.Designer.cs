namespace CpS_420_Inception_Project
{
    partial class Authentication_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication_Form));
            this.UserName_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.userNameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.LoginImage_Picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginImage_Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName_Label
            // 
            this.UserName_Label.AutoSize = true;
            this.UserName_Label.Location = new System.Drawing.Point(215, 38);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(58, 13);
            this.UserName_Label.TabIndex = 0;
            this.UserName_Label.Text = "User name";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(215, 102);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(53, 13);
            this.Password_Label.TabIndex = 1;
            this.Password_Label.Text = "Password";
            // 
            // userNameTextbox
            // 
            this.userNameTextbox.Location = new System.Drawing.Point(218, 55);
            this.userNameTextbox.Name = "userNameTextbox";
            this.userNameTextbox.Size = new System.Drawing.Size(196, 20);
            this.userNameTextbox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(218, 118);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(196, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(243, 176);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(78, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(336, 176);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(78, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // LoginImage_Picturebox
            // 
            this.LoginImage_Picturebox.Image = ((System.Drawing.Image)(resources.GetObject("LoginImage_Picturebox.Image")));
            this.LoginImage_Picturebox.Location = new System.Drawing.Point(0, -1);
            this.LoginImage_Picturebox.Name = "LoginImage_Picturebox";
            this.LoginImage_Picturebox.Size = new System.Drawing.Size(207, 212);
            this.LoginImage_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginImage_Picturebox.TabIndex = 6;
            this.LoginImage_Picturebox.TabStop = false;
            // 
            // Authentication_Form
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(427, 211);
            this.ControlBox = false;
            this.Controls.Add(this.LoginImage_Picturebox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextbox);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.UserName_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(443, 250);
            this.MinimumSize = new System.Drawing.Size(443, 250);
            this.Name = "Authentication_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Authentication_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginImage_Picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox userNameTextbox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox LoginImage_Picturebox;
    }
}