﻿namespace TripleJP_Lending_System.Forms
{
    partial class AddSalaryFrm
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
            this.remitGroupBox = new System.Windows.Forms.GroupBox();
            this.remitAmountGroupBox = new System.Windows.Forms.GroupBox();
            this.remitAmountTextBox = new System.Windows.Forms.TextBox();
            this.remitDateGroupBox = new System.Windows.Forms.GroupBox();
            this.remitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loanGroupBox = new System.Windows.Forms.GroupBox();
            this.totalRemittanceGroupBox = new System.Windows.Forms.GroupBox();
            this.salaryCalculationLabel = new System.Windows.Forms.Label();
            this.remainingCreditGroupBox = new System.Windows.Forms.GroupBox();
            this.savingsCalculationLabel = new System.Windows.Forms.Label();
            this.remitButton = new System.Windows.Forms.Button();
            this.balanceGroupBox = new System.Windows.Forms.GroupBox();
            this.totalCollectionLabel = new System.Windows.Forms.Label();
            this.remitGroupBox.SuspendLayout();
            this.remitAmountGroupBox.SuspendLayout();
            this.remitDateGroupBox.SuspendLayout();
            this.loanGroupBox.SuspendLayout();
            this.totalRemittanceGroupBox.SuspendLayout();
            this.remainingCreditGroupBox.SuspendLayout();
            this.balanceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // remitGroupBox
            // 
            this.remitGroupBox.Controls.Add(this.remitAmountGroupBox);
            this.remitGroupBox.Controls.Add(this.remitDateGroupBox);
            this.remitGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitGroupBox.ForeColor = System.Drawing.Color.Black;
            this.remitGroupBox.Location = new System.Drawing.Point(12, 23);
            this.remitGroupBox.Name = "remitGroupBox";
            this.remitGroupBox.Size = new System.Drawing.Size(351, 211);
            this.remitGroupBox.TabIndex = 24;
            this.remitGroupBox.TabStop = false;
            this.remitGroupBox.Text = "Add Salary";
            // 
            // remitAmountGroupBox
            // 
            this.remitAmountGroupBox.Controls.Add(this.remitAmountTextBox);
            this.remitAmountGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitAmountGroupBox.Location = new System.Drawing.Point(10, 115);
            this.remitAmountGroupBox.Name = "remitAmountGroupBox";
            this.remitAmountGroupBox.Size = new System.Drawing.Size(331, 76);
            this.remitAmountGroupBox.TabIndex = 19;
            this.remitAmountGroupBox.TabStop = false;
            this.remitAmountGroupBox.Text = "Enter Amount";
            // 
            // remitAmountTextBox
            // 
            this.remitAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.remitAmountTextBox.Location = new System.Drawing.Point(5, 30);
            this.remitAmountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.remitAmountTextBox.Name = "remitAmountTextBox";
            this.remitAmountTextBox.Size = new System.Drawing.Size(321, 28);
            this.remitAmountTextBox.TabIndex = 0;
            // 
            // remitDateGroupBox
            // 
            this.remitDateGroupBox.Controls.Add(this.remitDateTimePicker);
            this.remitDateGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitDateGroupBox.Location = new System.Drawing.Point(10, 28);
            this.remitDateGroupBox.Name = "remitDateGroupBox";
            this.remitDateGroupBox.Size = new System.Drawing.Size(331, 81);
            this.remitDateGroupBox.TabIndex = 18;
            this.remitDateGroupBox.TabStop = false;
            this.remitDateGroupBox.Text = "Date";
            // 
            // remitDateTimePicker
            // 
            this.remitDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.remitDateTimePicker.Location = new System.Drawing.Point(5, 30);
            this.remitDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.remitDateTimePicker.Name = "remitDateTimePicker";
            this.remitDateTimePicker.Size = new System.Drawing.Size(321, 28);
            this.remitDateTimePicker.TabIndex = 0;
            // 
            // loanGroupBox
            // 
            this.loanGroupBox.Controls.Add(this.totalRemittanceGroupBox);
            this.loanGroupBox.Controls.Add(this.remainingCreditGroupBox);
            this.loanGroupBox.Controls.Add(this.remitButton);
            this.loanGroupBox.Controls.Add(this.balanceGroupBox);
            this.loanGroupBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanGroupBox.ForeColor = System.Drawing.Color.Black;
            this.loanGroupBox.Location = new System.Drawing.Point(12, 240);
            this.loanGroupBox.Name = "loanGroupBox";
            this.loanGroupBox.Size = new System.Drawing.Size(351, 299);
            this.loanGroupBox.TabIndex = 25;
            this.loanGroupBox.TabStop = false;
            this.loanGroupBox.Text = "Calculation";
            // 
            // totalRemittanceGroupBox
            // 
            this.totalRemittanceGroupBox.Controls.Add(this.salaryCalculationLabel);
            this.totalRemittanceGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRemittanceGroupBox.ForeColor = System.Drawing.Color.Black;
            this.totalRemittanceGroupBox.Location = new System.Drawing.Point(6, 100);
            this.totalRemittanceGroupBox.Name = "totalRemittanceGroupBox";
            this.totalRemittanceGroupBox.Size = new System.Drawing.Size(335, 64);
            this.totalRemittanceGroupBox.TabIndex = 23;
            this.totalRemittanceGroupBox.TabStop = false;
            this.totalRemittanceGroupBox.Text = "Salary";
            // 
            // salaryCalculationLabel
            // 
            this.salaryCalculationLabel.AutoSize = true;
            this.salaryCalculationLabel.ForeColor = System.Drawing.Color.Black;
            this.salaryCalculationLabel.Location = new System.Drawing.Point(39, 28);
            this.salaryCalculationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salaryCalculationLabel.Name = "salaryCalculationLabel";
            this.salaryCalculationLabel.Size = new System.Drawing.Size(132, 25);
            this.salaryCalculationLabel.TabIndex = 0;
            this.salaryCalculationLabel.Text = "salaryCalculation";
            // 
            // remainingCreditGroupBox
            // 
            this.remainingCreditGroupBox.Controls.Add(this.savingsCalculationLabel);
            this.remainingCreditGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingCreditGroupBox.ForeColor = System.Drawing.Color.Black;
            this.remainingCreditGroupBox.Location = new System.Drawing.Point(6, 170);
            this.remainingCreditGroupBox.Name = "remainingCreditGroupBox";
            this.remainingCreditGroupBox.Size = new System.Drawing.Size(335, 64);
            this.remainingCreditGroupBox.TabIndex = 22;
            this.remainingCreditGroupBox.TabStop = false;
            this.remainingCreditGroupBox.Text = "Savings";
            // 
            // savingsCalculationLabel
            // 
            this.savingsCalculationLabel.AutoSize = true;
            this.savingsCalculationLabel.ForeColor = System.Drawing.Color.Black;
            this.savingsCalculationLabel.Location = new System.Drawing.Point(39, 28);
            this.savingsCalculationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.savingsCalculationLabel.Name = "savingsCalculationLabel";
            this.savingsCalculationLabel.Size = new System.Drawing.Size(143, 25);
            this.savingsCalculationLabel.TabIndex = 0;
            this.savingsCalculationLabel.Text = "savingsCalculation";
            // 
            // remitButton
            // 
            this.remitButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitButton.Location = new System.Drawing.Point(243, 239);
            this.remitButton.Margin = new System.Windows.Forms.Padding(2);
            this.remitButton.Name = "remitButton";
            this.remitButton.Size = new System.Drawing.Size(98, 46);
            this.remitButton.TabIndex = 20;
            this.remitButton.Text = "Remit";
            this.remitButton.UseVisualStyleBackColor = true;
            // 
            // balanceGroupBox
            // 
            this.balanceGroupBox.Controls.Add(this.totalCollectionLabel);
            this.balanceGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceGroupBox.Location = new System.Drawing.Point(6, 30);
            this.balanceGroupBox.Name = "balanceGroupBox";
            this.balanceGroupBox.Size = new System.Drawing.Size(335, 64);
            this.balanceGroupBox.TabIndex = 20;
            this.balanceGroupBox.TabStop = false;
            this.balanceGroupBox.Text = "Total Collection";
            // 
            // totalCollectionLabel
            // 
            this.totalCollectionLabel.AutoSize = true;
            this.totalCollectionLabel.Location = new System.Drawing.Point(39, 28);
            this.totalCollectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCollectionLabel.Name = "totalCollectionLabel";
            this.totalCollectionLabel.Size = new System.Drawing.Size(113, 25);
            this.totalCollectionLabel.TabIndex = 0;
            this.totalCollectionLabel.Text = "totalCollection";
            // 
            // AddSalaryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 545);
            this.Controls.Add(this.loanGroupBox);
            this.Controls.Add(this.remitGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddSalaryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.remitGroupBox.ResumeLayout(false);
            this.remitAmountGroupBox.ResumeLayout(false);
            this.remitAmountGroupBox.PerformLayout();
            this.remitDateGroupBox.ResumeLayout(false);
            this.loanGroupBox.ResumeLayout(false);
            this.totalRemittanceGroupBox.ResumeLayout(false);
            this.totalRemittanceGroupBox.PerformLayout();
            this.remainingCreditGroupBox.ResumeLayout(false);
            this.remainingCreditGroupBox.PerformLayout();
            this.balanceGroupBox.ResumeLayout(false);
            this.balanceGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox remitGroupBox;
        private System.Windows.Forms.GroupBox remitAmountGroupBox;
        private System.Windows.Forms.TextBox remitAmountTextBox;
        private System.Windows.Forms.GroupBox remitDateGroupBox;
        private System.Windows.Forms.DateTimePicker remitDateTimePicker;
        private System.Windows.Forms.GroupBox loanGroupBox;
        private System.Windows.Forms.GroupBox totalRemittanceGroupBox;
        private System.Windows.Forms.Label salaryCalculationLabel;
        private System.Windows.Forms.GroupBox remainingCreditGroupBox;
        private System.Windows.Forms.Label savingsCalculationLabel;
        private System.Windows.Forms.Button remitButton;
        private System.Windows.Forms.GroupBox balanceGroupBox;
        private System.Windows.Forms.Label totalCollectionLabel;
    }
}