﻿namespace ATM_WinForm.Forme.Racun
{
    partial class Form_Racun_OvlascenoLice_AddUpdate
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
            this.labelaAddEditLBL = new System.Windows.Forms.Label();
            this.AddUpdateTxt = new System.Windows.Forms.TextBox();
            this.AkcijaOvlascenoLiceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelaAddEditLBL
            // 
            this.labelaAddEditLBL.AutoSize = true;
            this.labelaAddEditLBL.Location = new System.Drawing.Point(144, 75);
            this.labelaAddEditLBL.Name = "labelaAddEditLBL";
            this.labelaAddEditLBL.Size = new System.Drawing.Size(44, 16);
            this.labelaAddEditLBL.TabIndex = 4;
            this.labelaAddEditLBL.Text = "label1";
            // 
            // AddUpdateTxt
            // 
            this.AddUpdateTxt.Location = new System.Drawing.Point(67, 108);
            this.AddUpdateTxt.Name = "AddUpdateTxt";
            this.AddUpdateTxt.Size = new System.Drawing.Size(210, 22);
            this.AddUpdateTxt.TabIndex = 5;
            // 
            // AkcijaOvlascenoLiceBtn
            // 
            this.AkcijaOvlascenoLiceBtn.Location = new System.Drawing.Point(67, 155);
            this.AkcijaOvlascenoLiceBtn.Name = "AkcijaOvlascenoLiceBtn";
            this.AkcijaOvlascenoLiceBtn.Size = new System.Drawing.Size(210, 57);
            this.AkcijaOvlascenoLiceBtn.TabIndex = 6;
            this.AkcijaOvlascenoLiceBtn.Text = "button1";
            this.AkcijaOvlascenoLiceBtn.UseVisualStyleBackColor = true;
            this.AkcijaOvlascenoLiceBtn.Click += new System.EventHandler(this.AkcijaOvlascenoLiceBtn_Click);
            // 
            // Form_Racun_OvlascenoLice_AddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 333);
            this.Controls.Add(this.AkcijaOvlascenoLiceBtn);
            this.Controls.Add(this.AddUpdateTxt);
            this.Controls.Add(this.labelaAddEditLBL);
            this.Name = "Form_Racun_OvlascenoLice_AddUpdate";
            this.Text = "ATM - Ovlascena Lica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelaAddEditLBL;
        private System.Windows.Forms.TextBox AddUpdateTxt;
        private System.Windows.Forms.Button AkcijaOvlascenoLiceBtn;
    }
}