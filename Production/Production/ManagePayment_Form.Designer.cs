namespace CpS_420_Inception_Project
{
    partial class ManagePayment_Form
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
            this.accountNumComboBox = new System.Windows.Forms.ComboBox();
            this.routingNumComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.CheckNumber_Label = new System.Windows.Forms.Label();
            this.AccountNumber_Label = new System.Windows.Forms.Label();
            this.checkNumComboBox = new System.Windows.Forms.ComboBox();
            this.paidCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // accountNumComboBox
            // 
            this.accountNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.accountNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.accountNumComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumComboBox.FormattingEnabled = true;
            this.accountNumComboBox.Location = new System.Drawing.Point(136, 39);
            this.accountNumComboBox.Name = "accountNumComboBox";
            this.accountNumComboBox.Size = new System.Drawing.Size(204, 21);
            this.accountNumComboBox.TabIndex = 2;
            this.accountNumComboBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            this.accountNumComboBox.Leave += new System.EventHandler(this.accountNumComboBox_Leave);
            // 
            // routingNumComboBox
            // 
            this.routingNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.routingNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.routingNumComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routingNumComboBox.FormattingEnabled = true;
            this.routingNumComboBox.Location = new System.Drawing.Point(136, 12);
            this.routingNumComboBox.Name = "routingNumComboBox";
            this.routingNumComboBox.Size = new System.Drawing.Size(204, 21);
            this.routingNumComboBox.TabIndex = 1;
            this.routingNumComboBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            this.routingNumComboBox.Leave += new System.EventHandler(this.routingNumComboBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Account Number:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.cancelButton.Location = new System.Drawing.Point(220, 151);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 40);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.saveButton.Location = new System.Drawing.Point(93, 151);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 40);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CheckNumber_Label
            // 
            this.CheckNumber_Label.AutoSize = true;
            this.CheckNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.CheckNumber_Label.Location = new System.Drawing.Point(23, 67);
            this.CheckNumber_Label.Name = "CheckNumber_Label";
            this.CheckNumber_Label.Size = new System.Drawing.Size(107, 20);
            this.CheckNumber_Label.TabIndex = 50;
            this.CheckNumber_Label.Text = "Check Number:";
            // 
            // AccountNumber_Label
            // 
            this.AccountNumber_Label.AutoSize = true;
            this.AccountNumber_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumber_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.AccountNumber_Label.Location = new System.Drawing.Point(10, 13);
            this.AccountNumber_Label.Name = "AccountNumber_Label";
            this.AccountNumber_Label.Size = new System.Drawing.Size(118, 20);
            this.AccountNumber_Label.TabIndex = 49;
            this.AccountNumber_Label.Text = "Routing Number:";
            // 
            // checkNumComboBox
            // 
            this.checkNumComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.checkNumComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.checkNumComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNumComboBox.FormattingEnabled = true;
            this.checkNumComboBox.Location = new System.Drawing.Point(136, 66);
            this.checkNumComboBox.Name = "checkNumComboBox";
            this.checkNumComboBox.Size = new System.Drawing.Size(204, 21);
            this.checkNumComboBox.TabIndex = 3;
            this.checkNumComboBox.TextChanged += new System.EventHandler(this.fieldsChanged);
            // 
            // paidCheckBox
            // 
            this.paidCheckBox.AutoSize = true;
            this.paidCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.paidCheckBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.paidCheckBox.Location = new System.Drawing.Point(136, 93);
            this.paidCheckBox.Name = "paidCheckBox";
            this.paidCheckBox.Size = new System.Drawing.Size(52, 21);
            this.paidCheckBox.TabIndex = 4;
            this.paidCheckBox.Text = "Paid";
            this.paidCheckBox.UseVisualStyleBackColor = true;
            // 
            // ManagePayment_Form
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(352, 203);
            this.Controls.Add(this.paidCheckBox);
            this.Controls.Add(this.checkNumComboBox);
            this.Controls.Add(this.accountNumComboBox);
            this.Controls.Add(this.routingNumComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.CheckNumber_Label);
            this.Controls.Add(this.AccountNumber_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ManagePayment_Form";
            this.Text = "Manage Payments";
            this.Load += new System.EventHandler(this.ManagePayment_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox accountNumComboBox;
        private System.Windows.Forms.ComboBox routingNumComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label CheckNumber_Label;
        private System.Windows.Forms.Label AccountNumber_Label;
        private System.Windows.Forms.ComboBox checkNumComboBox;
        private System.Windows.Forms.CheckBox paidCheckBox;
    }
}