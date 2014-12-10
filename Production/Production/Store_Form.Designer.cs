namespace CpS_420_Inception_Project
{
    partial class Store_Form
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
            this.storeNumComboBox = new System.Windows.Forms.ComboBox();
            this.CheckNumber_Label = new System.Windows.Forms.Label();
            this.acceptButton1 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton2 = new System.Windows.Forms.Button();
            this.CashierNumber_Label = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // storeNumComboBox
            // 
            this.storeNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.storeNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.storeNumComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeNumComboBox.FormattingEnabled = true;
            this.storeNumComboBox.Location = new System.Drawing.Point(119, 12);
            this.storeNumComboBox.Name = "storeNumComboBox";
            this.storeNumComboBox.Size = new System.Drawing.Size(218, 21);
            this.storeNumComboBox.Sorted = true;
            this.storeNumComboBox.TabIndex = 1;
            this.storeNumComboBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // CheckNumber_Label
            // 
            this.CheckNumber_Label.AutoSize = true;
            this.CheckNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.CheckNumber_Label.Location = new System.Drawing.Point(13, 13);
            this.CheckNumber_Label.Name = "CheckNumber_Label";
            this.CheckNumber_Label.Size = new System.Drawing.Size(100, 20);
            this.CheckNumber_Label.TabIndex = 19;
            this.CheckNumber_Label.Text = "Store Number:";
            // 
            // acceptButton1
            // 
            this.acceptButton1.Enabled = false;
            this.acceptButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton1.ForeColor = System.Drawing.Color.SteelBlue;
            this.acceptButton1.Location = new System.Drawing.Point(34, 180);
            this.acceptButton1.Name = "acceptButton1";
            this.acceptButton1.Size = new System.Drawing.Size(98, 40);
            this.acceptButton1.TabIndex = 7;
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
            this.cancelButton.Location = new System.Drawing.Point(242, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 40);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton2
            // 
            this.acceptButton2.Enabled = false;
            this.acceptButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton2.ForeColor = System.Drawing.Color.SteelBlue;
            this.acceptButton2.Location = new System.Drawing.Point(138, 180);
            this.acceptButton2.Name = "acceptButton2";
            this.acceptButton2.Size = new System.Drawing.Size(98, 40);
            this.acceptButton2.TabIndex = 8;
            this.acceptButton2.Text = "Create";
            this.acceptButton2.UseVisualStyleBackColor = true;
            this.acceptButton2.Click += new System.EventHandler(this.acceptButton2_Click);
            // 
            // CashierNumber_Label
            // 
            this.CashierNumber_Label.AutoSize = true;
            this.CashierNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.CashierNumber_Label.Location = new System.Drawing.Point(62, 41);
            this.CashierNumber_Label.Name = "CashierNumber_Label";
            this.CashierNumber_Label.Size = new System.Drawing.Size(51, 20);
            this.CashierNumber_Label.TabIndex = 32;
            this.CashierNumber_Label.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(119, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(218, 22);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Street Address:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTextBox.Location = new System.Drawing.Point(119, 67);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(218, 22);
            this.streetTextBox.TabIndex = 3;
            this.streetTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(75, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(119, 95);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(218, 22);
            this.cityTextBox.TabIndex = 4;
            this.cityTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(172, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Zip:";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTextBox.Location = new System.Drawing.Point(211, 122);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(126, 22);
            this.zipTextBox.TabIndex = 6;
            this.zipTextBox.TextChanged += new System.EventHandler(this.fieldsChanged);
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
            this.stateComboBox.Location = new System.Drawing.Point(119, 123);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(47, 21);
            this.stateComboBox.TabIndex = 5;
            this.stateComboBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(69, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "State:";
            // 
            // Store_Form
            // 
            this.AcceptButton = this.acceptButton2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(352, 232);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.CashierNumber_Label);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.acceptButton1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton2);
            this.Controls.Add(this.storeNumComboBox);
            this.Controls.Add(this.CheckNumber_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Store_Form";
            this.Text = "New Store";
            this.Load += new System.EventHandler(this.Check_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox storeNumComboBox;
        private System.Windows.Forms.Label CheckNumber_Label;
        private System.Windows.Forms.Button acceptButton1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton2;
        private System.Windows.Forms.Label CashierNumber_Label;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label label4;
    }
}