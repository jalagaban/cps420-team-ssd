﻿namespace CpS_420_Inception_Project
{
    partial class AddStore_Form
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
            this.AddStore_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddStore_Label
            // 
            this.AddStore_Label.AutoSize = true;
            this.AddStore_Label.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStore_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.AddStore_Label.Location = new System.Drawing.Point(12, 9);
            this.AddStore_Label.Name = "AddStore_Label";
            this.AddStore_Label.Size = new System.Drawing.Size(167, 45);
            this.AddStore_Label.TabIndex = 2;
            this.AddStore_Label.Text = "Add Store";
            // 
            // AddStore_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 363);
            this.Controls.Add(this.AddStore_Label);
            this.Name = "AddStore_Form";
            this.Text = "Add Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddStore_Label;
    }
}