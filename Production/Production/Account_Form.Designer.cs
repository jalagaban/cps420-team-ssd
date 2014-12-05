namespace CpS_420_Inception_Project
{
    partial class Account_Form
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
            this.RoutingNumber_Label = new System.Windows.Forms.Label();
            this.AccountNumber_Label = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstName_Label = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.StreetAddress_Label = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.City_Label = new System.Windows.Forms.Label();
            this.State_Label = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.Zip_Label = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.routingNumComboBox = new System.Windows.Forms.ComboBox();
            this.accountNumComboBox = new System.Windows.Forms.ComboBox();
            this.acceptButton1 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoutingNumber_Label
            // 
            this.RoutingNumber_Label.AutoSize = true;
            this.RoutingNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoutingNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.RoutingNumber_Label.Location = new System.Drawing.Point(14, 69);
            this.RoutingNumber_Label.Name = "RoutingNumber_Label";
            this.RoutingNumber_Label.Size = new System.Drawing.Size(120, 20);
            this.RoutingNumber_Label.TabIndex = 27;
            this.RoutingNumber_Label.Text = "Account Number:";
            // 
            // AccountNumber_Label
            // 
            this.AccountNumber_Label.AutoSize = true;
            this.AccountNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.AccountNumber_Label.Location = new System.Drawing.Point(12, 19);
            this.AccountNumber_Label.Name = "AccountNumber_Label";
            this.AccountNumber_Label.Size = new System.Drawing.Size(118, 20);
            this.AccountNumber_Label.TabIndex = 26;
            this.AccountNumber_Label.Text = "Routing Number:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(18, 123);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(189, 22);
            this.firstNameTextBox.TabIndex = 3;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // FirstName_Label
            // 
            this.FirstName_Label.AutoSize = true;
            this.FirstName_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.FirstName_Label.Location = new System.Drawing.Point(14, 148);
            this.FirstName_Label.Name = "FirstName_Label";
            this.FirstName_Label.Size = new System.Drawing.Size(88, 20);
            this.FirstName_Label.TabIndex = 30;
            this.FirstName_Label.Text = "*First Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(223, 123);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(183, 22);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.LastName_Label.Location = new System.Drawing.Point(219, 148);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(87, 20);
            this.LastName_Label.TabIndex = 34;
            this.LastName_Label.Text = "*Last Name:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTextBox.Location = new System.Drawing.Point(16, 197);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(243, 22);
            this.streetTextBox.TabIndex = 5;
            this.streetTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // StreetAddress_Label
            // 
            this.StreetAddress_Label.AutoSize = true;
            this.StreetAddress_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetAddress_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.StreetAddress_Label.Location = new System.Drawing.Point(14, 222);
            this.StreetAddress_Label.Name = "StreetAddress_Label";
            this.StreetAddress_Label.Size = new System.Drawing.Size(107, 20);
            this.StreetAddress_Label.TabIndex = 36;
            this.StreetAddress_Label.Text = "*Street Address:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(280, 197);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(151, 22);
            this.cityTextBox.TabIndex = 6;
            this.cityTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // City_Label
            // 
            this.City_Label.AutoSize = true;
            this.City_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.City_Label.Location = new System.Drawing.Point(276, 222);
            this.City_Label.Name = "City_Label";
            this.City_Label.Size = new System.Drawing.Size(44, 20);
            this.City_Label.TabIndex = 38;
            this.City_Label.Text = "*City:";
            // 
            // State_Label
            // 
            this.State_Label.AutoSize = true;
            this.State_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.State_Label.Location = new System.Drawing.Point(14, 298);
            this.State_Label.Name = "State_Label";
            this.State_Label.Size = new System.Drawing.Size(47, 20);
            this.State_Label.TabIndex = 40;
            this.State_Label.Text = "*State";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTextBox.Location = new System.Drawing.Point(87, 274);
            this.zipTextBox.MaxLength = 5;
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(47, 22);
            this.zipTextBox.TabIndex = 8;
            this.zipTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // Zip_Label
            // 
            this.Zip_Label.AutoSize = true;
            this.Zip_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zip_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.Zip_Label.Location = new System.Drawing.Point(83, 299);
            this.Zip_Label.Name = "Zip_Label";
            this.Zip_Label.Size = new System.Drawing.Size(36, 20);
            this.Zip_Label.TabIndex = 42;
            this.Zip_Label.Text = "*Zip";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(160, 274);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(122, 22);
            this.phoneTextBox.TabIndex = 9;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(156, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Phone Number";
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
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
            "WY",
            "AS",
            "DC",
            "FM",
            "GU",
            "MH",
            "MP",
            "PW",
            "PR",
            "VI"});
            this.stateComboBox.Location = new System.Drawing.Point(16, 274);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(47, 21);
            this.stateComboBox.TabIndex = 7;
            this.stateComboBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // routingNumComboBox
            // 
            this.routingNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.routingNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.routingNumComboBox.FormattingEnabled = true;
            this.routingNumComboBox.Location = new System.Drawing.Point(137, 17);
            this.routingNumComboBox.Name = "routingNumComboBox";
            this.routingNumComboBox.Size = new System.Drawing.Size(218, 21);
            this.routingNumComboBox.TabIndex = 1;
            this.routingNumComboBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            this.routingNumComboBox.Leave += new System.EventHandler(this.routingNumComboBox_Leave);
            // 
            // accountNumComboBox
            // 
            this.accountNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.accountNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.accountNumComboBox.FormattingEnabled = true;
            this.accountNumComboBox.Location = new System.Drawing.Point(137, 71);
            this.accountNumComboBox.Name = "accountNumComboBox";
            this.accountNumComboBox.Size = new System.Drawing.Size(218, 21);
            this.accountNumComboBox.TabIndex = 2;
            this.accountNumComboBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // acceptButton1
            // 
            this.acceptButton1.Enabled = false;
            this.acceptButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton1.ForeColor = System.Drawing.Color.SteelBlue;
            this.acceptButton1.Location = new System.Drawing.Point(157, 331);
            this.acceptButton1.Name = "acceptButton1";
            this.acceptButton1.Size = new System.Drawing.Size(98, 40);
            this.acceptButton1.TabIndex = 10;
            this.acceptButton1.Text = "Create";
            this.acceptButton1.UseVisualStyleBackColor = true;
            this.acceptButton1.Visible = false;
            this.acceptButton1.Click += new System.EventHandler(this.acceptButton1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.cancelButton.Location = new System.Drawing.Point(365, 331);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 40);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton2
            // 
            this.acceptButton2.Enabled = false;
            this.acceptButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton2.ForeColor = System.Drawing.Color.SteelBlue;
            this.acceptButton2.Location = new System.Drawing.Point(261, 331);
            this.acceptButton2.Name = "acceptButton2";
            this.acceptButton2.Size = new System.Drawing.Size(98, 40);
            this.acceptButton2.TabIndex = 11;
            this.acceptButton2.Text = "Create";
            this.acceptButton2.UseVisualStyleBackColor = true;
            this.acceptButton2.Click += new System.EventHandler(this.acceptButton2_Click);
            // 
            // Account_Form
            // 
            this.AcceptButton = this.acceptButton2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(475, 383);
            this.Controls.Add(this.acceptButton1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton2);
            this.Controls.Add(this.accountNumComboBox);
            this.Controls.Add(this.routingNumComboBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.Zip_Label);
            this.Controls.Add(this.State_Label);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.City_Label);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.StreetAddress_Label);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.LastName_Label);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.FirstName_Label);
            this.Controls.Add(this.RoutingNumber_Label);
            this.Controls.Add(this.AccountNumber_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Account_Form";
            this.Text = "New Account";
            this.Load += new System.EventHandler(this.Account_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoutingNumber_Label;
        private System.Windows.Forms.Label AccountNumber_Label;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label FirstName_Label;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label LastName_Label;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label StreetAddress_Label;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label City_Label;
        private System.Windows.Forms.Label State_Label;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label Zip_Label;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox routingNumComboBox;
        private System.Windows.Forms.ComboBox accountNumComboBox;
        private System.Windows.Forms.Button acceptButton1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton2;
    }
}