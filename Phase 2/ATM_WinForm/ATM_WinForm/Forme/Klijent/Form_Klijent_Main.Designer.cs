﻿namespace ATM_WinForm.Forme.Klijent
{
    partial class Form_Klijent_Main
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
            this.IzbrisiKlijentaBtn = new System.Windows.Forms.Button();
            this.IzmeniKlijentaBtn = new System.Windows.Forms.Button();
            this.DodajKlijentaBtn = new System.Windows.Forms.Button();
            this.KlijentGrid = new System.Windows.Forms.DataGridView();
            this.KlijentComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KlijentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IzbrisiKlijentaBtn
            // 
            this.IzbrisiKlijentaBtn.Enabled = false;
            this.IzbrisiKlijentaBtn.Location = new System.Drawing.Point(12, 501);
            this.IzbrisiKlijentaBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IzbrisiKlijentaBtn.Name = "IzbrisiKlijentaBtn";
            this.IzbrisiKlijentaBtn.Size = new System.Drawing.Size(267, 41);
            this.IzbrisiKlijentaBtn.TabIndex = 14;
            this.IzbrisiKlijentaBtn.Text = "Izbrisi Klijenta";
            this.IzbrisiKlijentaBtn.UseVisualStyleBackColor = true;
            // 
            // IzmeniKlijentaBtn
            // 
            this.IzmeniKlijentaBtn.Enabled = false;
            this.IzmeniKlijentaBtn.Location = new System.Drawing.Point(12, 453);
            this.IzmeniKlijentaBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IzmeniKlijentaBtn.Name = "IzmeniKlijentaBtn";
            this.IzmeniKlijentaBtn.Size = new System.Drawing.Size(267, 41);
            this.IzmeniKlijentaBtn.TabIndex = 13;
            this.IzmeniKlijentaBtn.Text = "Izmeni Klijenta";
            this.IzmeniKlijentaBtn.UseVisualStyleBackColor = true;
            // 
            // DodajKlijentaBtn
            // 
            this.DodajKlijentaBtn.Location = new System.Drawing.Point(12, 404);
            this.DodajKlijentaBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajKlijentaBtn.Name = "DodajKlijentaBtn";
            this.DodajKlijentaBtn.Size = new System.Drawing.Size(267, 41);
            this.DodajKlijentaBtn.TabIndex = 12;
            this.DodajKlijentaBtn.Text = "Dodaj Klijenta";
            this.DodajKlijentaBtn.UseVisualStyleBackColor = true;
            // 
            // KlijentGrid
            // 
            this.KlijentGrid.AllowUserToOrderColumns = true;
            this.KlijentGrid.AllowUserToResizeRows = false;
            this.KlijentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KlijentGrid.ColumnHeadersHeight = 35;
            this.KlijentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.KlijentGrid.Location = new System.Drawing.Point(12, 16);
            this.KlijentGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KlijentGrid.MultiSelect = false;
            this.KlijentGrid.Name = "KlijentGrid";
            this.KlijentGrid.ReadOnly = true;
            this.KlijentGrid.RowHeadersWidth = 51;
            this.KlijentGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.KlijentGrid.Size = new System.Drawing.Size(1191, 380);
            this.KlijentGrid.TabIndex = 11;
            // 
            // KlijentComboBox
            // 
            this.KlijentComboBox.Items.AddRange(new object[] {
            "Svi klijenti",
            "Pravna lica",
            "Fizicka lica"});
            this.KlijentComboBox.Location = new System.Drawing.Point(348, 418);
            this.KlijentComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KlijentComboBox.MaxDropDownItems = 50;
            this.KlijentComboBox.Name = "KlijentComboBox";
            this.KlijentComboBox.Size = new System.Drawing.Size(233, 24);
            this.KlijentComboBox.TabIndex = 20;
            this.KlijentComboBox.SelectedIndexChanged += new System.EventHandler(this.KlijentComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Izaberi vrstu korisnika za prikaz";
            // 
            // Form_Klijent_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KlijentComboBox);
            this.Controls.Add(this.IzbrisiKlijentaBtn);
            this.Controls.Add(this.IzmeniKlijentaBtn);
            this.Controls.Add(this.DodajKlijentaBtn);
            this.Controls.Add(this.KlijentGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Klijent_Main";
            this.Text = "ATM - Klijenti";
            this.Load += new System.EventHandler(this.Form_Klijent_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KlijentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IzbrisiKlijentaBtn;
        private System.Windows.Forms.Button IzmeniKlijentaBtn;
        private System.Windows.Forms.Button DodajKlijentaBtn;
        private System.Windows.Forms.DataGridView KlijentGrid;
        private System.Windows.Forms.ComboBox KlijentComboBox;
        private System.Windows.Forms.Label label1;
    }
}