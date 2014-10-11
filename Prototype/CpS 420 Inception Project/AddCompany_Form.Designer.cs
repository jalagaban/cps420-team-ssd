namespace CpS_420_Inception_Project
{
    partial class AddCompany_Form
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
            this.AddCompany_Label = new System.Windows.Forms.Label();
            this.CompanyName_Label = new System.Windows.Forms.Label();
            this.CompanyName_Textbox = new System.Windows.Forms.TextBox();
            this.StreetAddress_Label = new System.Windows.Forms.Label();
            this.StreetAddress_Textbox = new System.Windows.Forms.TextBox();
            this.City_Textbox = new System.Windows.Forms.TextBox();
            this.City_Label = new System.Windows.Forms.Label();
            this.State_Label = new System.Windows.Forms.Label();
            this.State_Combobox = new System.Windows.Forms.ComboBox();
            this.ZipCode_Label = new System.Windows.Forms.Label();
            this.ZipCode_Textbox = new System.Windows.Forms.TextBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCompany_Label
            // 
            this.AddCompany_Label.AutoSize = true;
            this.AddCompany_Label.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCompany_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.AddCompany_Label.Location = new System.Drawing.Point(12, 9);
            this.AddCompany_Label.Name = "AddCompany_Label";
            this.AddCompany_Label.Size = new System.Drawing.Size(231, 45);
            this.AddCompany_Label.TabIndex = 0;
            this.AddCompany_Label.Text = "Add Company";
            // 
            // CompanyName_Label
            // 
            this.CompanyName_Label.AutoSize = true;
            this.CompanyName_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.CompanyName_Label.Location = new System.Drawing.Point(12, 80);
            this.CompanyName_Label.Name = "CompanyName_Label";
            this.CompanyName_Label.Size = new System.Drawing.Size(117, 20);
            this.CompanyName_Label.TabIndex = 1;
            this.CompanyName_Label.Text = "Company Name:";
            // 
            // CompanyName_Textbox
            // 
            this.CompanyName_Textbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName_Textbox.Location = new System.Drawing.Point(136, 80);
            this.CompanyName_Textbox.Name = "CompanyName_Textbox";
            this.CompanyName_Textbox.Size = new System.Drawing.Size(378, 22);
            this.CompanyName_Textbox.TabIndex = 1;
            // 
            // StreetAddress_Label
            // 
            this.StreetAddress_Label.AutoSize = true;
            this.StreetAddress_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetAddress_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.StreetAddress_Label.Location = new System.Drawing.Point(28, 126);
            this.StreetAddress_Label.Name = "StreetAddress_Label";
            this.StreetAddress_Label.Size = new System.Drawing.Size(101, 20);
            this.StreetAddress_Label.TabIndex = 3;
            this.StreetAddress_Label.Text = "Street Address:";
            this.StreetAddress_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // StreetAddress_Textbox
            // 
            this.StreetAddress_Textbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetAddress_Textbox.Location = new System.Drawing.Point(136, 126);
            this.StreetAddress_Textbox.Name = "StreetAddress_Textbox";
            this.StreetAddress_Textbox.Size = new System.Drawing.Size(378, 22);
            this.StreetAddress_Textbox.TabIndex = 2;
            // 
            // City_Textbox
            // 
            this.City_Textbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Textbox.Location = new System.Drawing.Point(136, 172);
            this.City_Textbox.Name = "City_Textbox";
            this.City_Textbox.Size = new System.Drawing.Size(378, 22);
            this.City_Textbox.TabIndex = 3;
            // 
            // City_Label
            // 
            this.City_Label.AutoSize = true;
            this.City_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.City_Label.Location = new System.Drawing.Point(91, 172);
            this.City_Label.Name = "City_Label";
            this.City_Label.Size = new System.Drawing.Size(38, 20);
            this.City_Label.TabIndex = 5;
            this.City_Label.Text = "City:";
            // 
            // State_Label
            // 
            this.State_Label.AutoSize = true;
            this.State_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.State_Label.Location = new System.Drawing.Point(85, 218);
            this.State_Label.Name = "State_Label";
            this.State_Label.Size = new System.Drawing.Size(44, 20);
            this.State_Label.TabIndex = 7;
            this.State_Label.Text = "State:";
            // 
            // State_Combobox
            // 
            this.State_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.State_Combobox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State_Combobox.FormattingEnabled = true;
            this.State_Combobox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WV",
            "WI",
            "WY"});
            this.State_Combobox.Location = new System.Drawing.Point(136, 216);
            this.State_Combobox.Name = "State_Combobox";
            this.State_Combobox.Size = new System.Drawing.Size(121, 21);
            this.State_Combobox.TabIndex = 4;
            // 
            // ZipCode_Label
            // 
            this.ZipCode_Label.AutoSize = true;
            this.ZipCode_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipCode_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.ZipCode_Label.Location = new System.Drawing.Point(59, 264);
            this.ZipCode_Label.Name = "ZipCode_Label";
            this.ZipCode_Label.Size = new System.Drawing.Size(70, 20);
            this.ZipCode_Label.TabIndex = 9;
            this.ZipCode_Label.Text = "Zip Code:";
            // 
            // ZipCode_Textbox
            // 
            this.ZipCode_Textbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipCode_Textbox.Location = new System.Drawing.Point(135, 264);
            this.ZipCode_Textbox.Name = "ZipCode_Textbox";
            this.ZipCode_Textbox.Size = new System.Drawing.Size(122, 22);
            this.ZipCode_Textbox.TabIndex = 5;
            // 
            // Submit_Button
            // 
            this.Submit_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Button.ForeColor = System.Drawing.Color.SteelBlue;
            this.Submit_Button.Location = new System.Drawing.Point(248, 322);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(121, 40);
            this.Submit_Button.TabIndex = 6;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.ForeColor = System.Drawing.Color.SteelBlue;
            this.Cancel_Button.Location = new System.Drawing.Point(394, 322);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(120, 40);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // AddCompany_Form
            // 
            this.AcceptButton = this.Submit_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(547, 385);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.ZipCode_Textbox);
            this.Controls.Add(this.ZipCode_Label);
            this.Controls.Add(this.State_Combobox);
            this.Controls.Add(this.State_Label);
            this.Controls.Add(this.City_Textbox);
            this.Controls.Add(this.City_Label);
            this.Controls.Add(this.StreetAddress_Textbox);
            this.Controls.Add(this.StreetAddress_Label);
            this.Controls.Add(this.CompanyName_Textbox);
            this.Controls.Add(this.CompanyName_Label);
            this.Controls.Add(this.AddCompany_Label);
            this.Name = "AddCompany_Form";
            this.Text = "Add Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddCompany_Label;
        private System.Windows.Forms.Label CompanyName_Label;
        private System.Windows.Forms.TextBox CompanyName_Textbox;
        private System.Windows.Forms.Label StreetAddress_Label;
        private System.Windows.Forms.TextBox StreetAddress_Textbox;
        private System.Windows.Forms.TextBox City_Textbox;
        private System.Windows.Forms.Label City_Label;
        private System.Windows.Forms.Label State_Label;
        private System.Windows.Forms.ComboBox State_Combobox;
        private System.Windows.Forms.Label ZipCode_Label;
        private System.Windows.Forms.TextBox ZipCode_Textbox;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Button Cancel_Button;
    }
}