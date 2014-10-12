namespace CpS_420_Inception_Project
{
    partial class AddCashier_Form
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
            this.AddCashier_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddCashier_Label
            // 
            this.AddCashier_Label.AutoSize = true;
            this.AddCashier_Label.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCashier_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.AddCashier_Label.Location = new System.Drawing.Point(12, 9);
            this.AddCashier_Label.Name = "AddCashier_Label";
            this.AddCashier_Label.Size = new System.Drawing.Size(202, 45);
            this.AddCashier_Label.TabIndex = 2;
            this.AddCashier_Label.Text = "Add Cashier";
            // 
            // AddCashier_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 342);
            this.Controls.Add(this.AddCashier_Label);
            this.Name = "AddCashier_Form";
            this.Text = "Add Cashier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddCashier_Label;
    }
}