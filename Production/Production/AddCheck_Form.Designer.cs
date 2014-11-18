namespace CpS_420_Inception_Project
{
    partial class AddCheck_Form
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
            this.createButton = new System.Windows.Forms.Button();
            this.CheckAmount_Label = new System.Windows.Forms.Label();
            this.cashierNumTextBox = new System.Windows.Forms.TextBox();
            this.CheckNumber_Label = new System.Windows.Forms.Label();
            this.CheckDate_Label = new System.Windows.Forms.Label();
            this.AccountNumber_Label = new System.Windows.Forms.Label();
            this.RoutingNumber_Label = new System.Windows.Forms.Label();
            this.accountNumComboBox = new System.Windows.Forms.ComboBox();
            this.routingNumComboBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.StoreNumber_Label = new System.Windows.Forms.Label();
            this.CashierNumber_Label = new System.Windows.Forms.Label();
            this.storeNumComboBox = new System.Windows.Forms.ComboBox();
            this.checkNumComboBox = new System.Windows.Forms.ComboBox();
            this.amountField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.cancelButton.Location = new System.Drawing.Point(220, 236);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 40);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.createButton.Location = new System.Drawing.Point(93, 236);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(121, 40);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // CheckAmount_Label
            // 
            this.CheckAmount_Label.AutoSize = true;
            this.CheckAmount_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAmount_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.CheckAmount_Label.Location = new System.Drawing.Point(24, 124);
            this.CheckAmount_Label.Name = "CheckAmount_Label";
            this.CheckAmount_Label.Size = new System.Drawing.Size(106, 20);
            this.CheckAmount_Label.TabIndex = 21;
            this.CheckAmount_Label.Text = "Check Amount:";
            // 
            // cashierNumTextBox
            // 
            this.cashierNumTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNumTextBox.Location = new System.Drawing.Point(136, 178);
            this.cashierNumTextBox.Name = "cashierNumTextBox";
            this.cashierNumTextBox.Size = new System.Drawing.Size(204, 22);
            this.cashierNumTextBox.TabIndex = 7;
            this.cashierNumTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // CheckNumber_Label
            // 
            this.CheckNumber_Label.AutoSize = true;
            this.CheckNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.CheckNumber_Label.Location = new System.Drawing.Point(23, 68);
            this.CheckNumber_Label.Name = "CheckNumber_Label";
            this.CheckNumber_Label.Size = new System.Drawing.Size(107, 20);
            this.CheckNumber_Label.TabIndex = 17;
            this.CheckNumber_Label.Text = "Check Number:";
            // 
            // CheckDate_Label
            // 
            this.CheckDate_Label.AutoSize = true;
            this.CheckDate_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckDate_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.CheckDate_Label.Location = new System.Drawing.Point(44, 96);
            this.CheckDate_Label.Name = "CheckDate_Label";
            this.CheckDate_Label.Size = new System.Drawing.Size(86, 20);
            this.CheckDate_Label.TabIndex = 14;
            this.CheckDate_Label.Text = "Check Date:";
            // 
            // AccountNumber_Label
            // 
            this.AccountNumber_Label.AutoSize = true;
            this.AccountNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.AccountNumber_Label.Location = new System.Drawing.Point(10, 40);
            this.AccountNumber_Label.Name = "AccountNumber_Label";
            this.AccountNumber_Label.Size = new System.Drawing.Size(120, 20);
            this.AccountNumber_Label.TabIndex = 11;
            this.AccountNumber_Label.Text = "Account Number:";
            // 
            // RoutingNumber_Label
            // 
            this.RoutingNumber_Label.AutoSize = true;
            this.RoutingNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoutingNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.RoutingNumber_Label.Location = new System.Drawing.Point(12, 13);
            this.RoutingNumber_Label.Name = "RoutingNumber_Label";
            this.RoutingNumber_Label.Size = new System.Drawing.Size(118, 20);
            this.RoutingNumber_Label.TabIndex = 22;
            this.RoutingNumber_Label.Text = "Routing Number:";
            // 
            // accountNumComboBox
            // 
            this.accountNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.accountNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.accountNumComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumComboBox.FormattingEnabled = true;
            this.accountNumComboBox.Location = new System.Drawing.Point(136, 39);
            this.accountNumComboBox.Name = "accountNumComboBox";
            this.accountNumComboBox.Size = new System.Drawing.Size(204, 21);
            this.accountNumComboBox.TabIndex = 2;
            this.accountNumComboBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // routingNumComboBox
            // 
            this.routingNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.routingNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.routingNumComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routingNumComboBox.FormattingEnabled = true;
            this.routingNumComboBox.Location = new System.Drawing.Point(136, 12);
            this.routingNumComboBox.Name = "routingNumComboBox";
            this.routingNumComboBox.Size = new System.Drawing.Size(204, 21);
            this.routingNumComboBox.TabIndex = 1;
            this.routingNumComboBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(136, 94);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(204, 22);
            this.datePicker.TabIndex = 4;
            // 
            // StoreNumber_Label
            // 
            this.StoreNumber_Label.AutoSize = true;
            this.StoreNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.StoreNumber_Label.Location = new System.Drawing.Point(30, 152);
            this.StoreNumber_Label.Name = "StoreNumber_Label";
            this.StoreNumber_Label.Size = new System.Drawing.Size(100, 20);
            this.StoreNumber_Label.TabIndex = 28;
            this.StoreNumber_Label.Text = "Store Number:";
            // 
            // CashierNumber_Label
            // 
            this.CashierNumber_Label.AutoSize = true;
            this.CashierNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.CashierNumber_Label.Location = new System.Drawing.Point(14, 180);
            this.CashierNumber_Label.Name = "CashierNumber_Label";
            this.CashierNumber_Label.Size = new System.Drawing.Size(116, 20);
            this.CashierNumber_Label.TabIndex = 30;
            this.CashierNumber_Label.Text = "Cashier Number:";
            // 
            // storeNumComboBox
            // 
            this.storeNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.storeNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.storeNumComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeNumComboBox.FormattingEnabled = true;
            this.storeNumComboBox.Location = new System.Drawing.Point(136, 151);
            this.storeNumComboBox.Name = "storeNumComboBox";
            this.storeNumComboBox.Size = new System.Drawing.Size(204, 21);
            this.storeNumComboBox.TabIndex = 6;
            this.storeNumComboBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // checkNumComboBox
            // 
            this.checkNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.checkNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.checkNumComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNumComboBox.FormattingEnabled = true;
            this.checkNumComboBox.Location = new System.Drawing.Point(136, 67);
            this.checkNumComboBox.Name = "checkNumComboBox";
            this.checkNumComboBox.Size = new System.Drawing.Size(204, 21);
            this.checkNumComboBox.TabIndex = 3;
            this.checkNumComboBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // amountField
            // 
            this.amountField.DecimalPlaces = 2;
            this.amountField.Location = new System.Drawing.Point(136, 124);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(204, 20);
            this.amountField.TabIndex = 5;
            this.amountField.Tag = "";
            // 
            // AddCheck_Form
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(352, 288);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.checkNumComboBox);
            this.Controls.Add(this.storeNumComboBox);
            this.Controls.Add(this.CashierNumber_Label);
            this.Controls.Add(this.StoreNumber_Label);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.routingNumComboBox);
            this.Controls.Add(this.accountNumComboBox);
            this.Controls.Add(this.RoutingNumber_Label);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.CheckAmount_Label);
            this.Controls.Add(this.cashierNumTextBox);
            this.Controls.Add(this.CheckNumber_Label);
            this.Controls.Add(this.CheckDate_Label);
            this.Controls.Add(this.AccountNumber_Label);
            this.Name = "AddCheck_Form";
            this.Text = "New Bad Check";
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label CheckAmount_Label;
        private System.Windows.Forms.TextBox cashierNumTextBox;
        private System.Windows.Forms.Label CheckNumber_Label;
        private System.Windows.Forms.Label CheckDate_Label;
        private System.Windows.Forms.Label AccountNumber_Label;
        private System.Windows.Forms.Label RoutingNumber_Label;
        private System.Windows.Forms.ComboBox accountNumComboBox;
        private System.Windows.Forms.ComboBox routingNumComboBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label StoreNumber_Label;
        private System.Windows.Forms.Label CashierNumber_Label;
        private System.Windows.Forms.ComboBox storeNumComboBox;
        private System.Windows.Forms.ComboBox checkNumComboBox;
        private System.Windows.Forms.NumericUpDown amountField;
    }
}