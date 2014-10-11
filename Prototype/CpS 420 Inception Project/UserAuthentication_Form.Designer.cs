namespace CpS_420_Inception_Project
{
    partial class UserAuthentication_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAuthentication_Form));
            this.UserName_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.UserName_Textbox = new System.Windows.Forms.TextBox();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
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
            // UserName_Textbox
            // 
            this.UserName_Textbox.Location = new System.Drawing.Point(218, 55);
            this.UserName_Textbox.Name = "UserName_Textbox";
            this.UserName_Textbox.Size = new System.Drawing.Size(196, 20);
            this.UserName_Textbox.TabIndex = 2;
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Location = new System.Drawing.Point(218, 118);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(196, 20);
            this.Password_Textbox.TabIndex = 3;
            this.Password_Textbox.UseSystemPasswordChar = true;
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(243, 176);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(78, 23);
            this.OK_Button.TabIndex = 4;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(336, 176);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(78, 23);
            this.Cancel_Button.TabIndex = 5;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
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
            // UserAuthentication_Form
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(427, 211);
            this.ControlBox = false;
            this.Controls.Add(this.LoginImage_Picturebox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.UserName_Textbox);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.UserName_Label);
            this.Name = "UserAuthentication_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "User Authentication";
            this.Load += new System.EventHandler(this.UserAuthentication_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginImage_Picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox UserName_Textbox;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.PictureBox LoginImage_Picturebox;
    }
}