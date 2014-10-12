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
            this.SuspendLayout();
            // 
            // UserAccounts_Label
            // 
            this.UserAccounts_Label.AutoSize = true;
            this.UserAccounts_Label.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAccounts_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.UserAccounts_Label.Location = new System.Drawing.Point(12, 9);
            this.UserAccounts_Label.Name = "UserAccounts_Label";
            this.UserAccounts_Label.Size = new System.Drawing.Size(231, 45);
            this.UserAccounts_Label.TabIndex = 1;
            this.UserAccounts_Label.Text = "User Accounts";
            // 
            // AddUserAccount_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 378);
            this.Controls.Add(this.UserAccounts_Label);
            this.Name = "AddUserAccount_Form";
            this.Text = "Create/Modify User Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserAccounts_Label;
    }
}