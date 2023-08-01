namespace TripleJP_Lending_System.Forms
{
    partial class RemitAndPenaltyFrm
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
            this.remitDateGroupBox = new System.Windows.Forms.GroupBox();
            this.remitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.remitAmountGroupBox = new System.Windows.Forms.GroupBox();
            this.remitAmountTextBox = new System.Windows.Forms.TextBox();
            this.remitButton = new System.Windows.Forms.Button();
            this.remitLoanIdGroupBox = new System.Windows.Forms.GroupBox();
            this.loanIdlabel = new System.Windows.Forms.Label();
            this.remitCustomerNameGroupBox = new System.Windows.Forms.GroupBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.collectionGroupBox = new System.Windows.Forms.GroupBox();
            this.loanGroupBox = new System.Windows.Forms.GroupBox();
            this.totalAmountDueGroupBox = new System.Windows.Forms.GroupBox();
            this.totalAmountDueLabel = new System.Windows.Forms.Label();
            this.totalRemittanceGroupBox = new System.Windows.Forms.GroupBox();
            this.remittanceLabel = new System.Windows.Forms.Label();
            this.remainingCreditGroupBox = new System.Windows.Forms.GroupBox();
            this.remainingCreditLabel = new System.Windows.Forms.Label();
            this.loanPanaltyGroupBox = new System.Windows.Forms.GroupBox();
            this.penaltyLabel = new System.Windows.Forms.Label();
            this.balanceGroupBox = new System.Windows.Forms.GroupBox();
            this.loanBalanceLabel = new System.Windows.Forms.Label();
            this.remitGroupBox = new System.Windows.Forms.GroupBox();
            this.penaltyGroupBox = new System.Windows.Forms.GroupBox();
            this.penaltyDateGroupBox = new System.Windows.Forms.GroupBox();
            this.penaltyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.penaltyAmountGroupBox = new System.Windows.Forms.GroupBox();
            this.penaltyAmountTextBox = new System.Windows.Forms.TextBox();
            this.remitDateGroupBox.SuspendLayout();
            this.remitAmountGroupBox.SuspendLayout();
            this.remitLoanIdGroupBox.SuspendLayout();
            this.remitCustomerNameGroupBox.SuspendLayout();
            this.collectionGroupBox.SuspendLayout();
            this.loanGroupBox.SuspendLayout();
            this.totalAmountDueGroupBox.SuspendLayout();
            this.totalRemittanceGroupBox.SuspendLayout();
            this.remainingCreditGroupBox.SuspendLayout();
            this.loanPanaltyGroupBox.SuspendLayout();
            this.balanceGroupBox.SuspendLayout();
            this.remitGroupBox.SuspendLayout();
            this.penaltyGroupBox.SuspendLayout();
            this.penaltyDateGroupBox.SuspendLayout();
            this.penaltyAmountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // remitDateGroupBox
            // 
            this.remitDateGroupBox.Controls.Add(this.remitDateTimePicker);
            this.remitDateGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitDateGroupBox.Location = new System.Drawing.Point(10, 178);
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
            this.remitDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remitDateTimePicker.Name = "remitDateTimePicker";
            this.remitDateTimePicker.Size = new System.Drawing.Size(321, 28);
            this.remitDateTimePicker.TabIndex = 0;
            // 
            // remitAmountGroupBox
            // 
            this.remitAmountGroupBox.Controls.Add(this.remitAmountTextBox);
            this.remitAmountGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitAmountGroupBox.Location = new System.Drawing.Point(10, 271);
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
            this.remitAmountTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remitAmountTextBox.Name = "remitAmountTextBox";
            this.remitAmountTextBox.Size = new System.Drawing.Size(321, 28);
            this.remitAmountTextBox.TabIndex = 0;
            this.remitAmountTextBox.TextChanged += new System.EventHandler(this.RemitAmountTextBox_TextChanged);
            this.remitAmountTextBox.Enter += new System.EventHandler(this.RemitTextBox_Enter);
            this.remitAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RemitTextBox_KeyPress);
            this.remitAmountTextBox.Leave += new System.EventHandler(this.RemitTextBox_Leave);
            // 
            // remitButton
            // 
            this.remitButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitButton.Location = new System.Drawing.Point(596, 199);
            this.remitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remitButton.Name = "remitButton";
            this.remitButton.Size = new System.Drawing.Size(98, 46);
            this.remitButton.TabIndex = 20;
            this.remitButton.Text = "OnLoadRemit";
            this.remitButton.UseVisualStyleBackColor = true;
            this.remitButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // remitLoanIdGroupBox
            // 
            this.remitLoanIdGroupBox.Controls.Add(this.loanIdlabel);
            this.remitLoanIdGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitLoanIdGroupBox.Location = new System.Drawing.Point(10, 26);
            this.remitLoanIdGroupBox.Name = "remitLoanIdGroupBox";
            this.remitLoanIdGroupBox.Size = new System.Drawing.Size(331, 64);
            this.remitLoanIdGroupBox.TabIndex = 19;
            this.remitLoanIdGroupBox.TabStop = false;
            this.remitLoanIdGroupBox.Text = "Loan ID";
            // 
            // loanIdlabel
            // 
            this.loanIdlabel.AutoSize = true;
            this.loanIdlabel.Location = new System.Drawing.Point(39, 28);
            this.loanIdlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loanIdlabel.Name = "loanIdlabel";
            this.loanIdlabel.Size = new System.Drawing.Size(62, 25);
            this.loanIdlabel.TabIndex = 0;
            this.loanIdlabel.Text = "Load ID";
            // 
            // remitCustomerNameGroupBox
            // 
            this.remitCustomerNameGroupBox.Controls.Add(this.customerNameLabel);
            this.remitCustomerNameGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitCustomerNameGroupBox.Location = new System.Drawing.Point(10, 102);
            this.remitCustomerNameGroupBox.Name = "remitCustomerNameGroupBox";
            this.remitCustomerNameGroupBox.Size = new System.Drawing.Size(331, 64);
            this.remitCustomerNameGroupBox.TabIndex = 20;
            this.remitCustomerNameGroupBox.TabStop = false;
            this.remitCustomerNameGroupBox.Text = "Customer Name";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(39, 28);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(127, 25);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // collectionGroupBox
            // 
            this.collectionGroupBox.Controls.Add(this.loanGroupBox);
            this.collectionGroupBox.Controls.Add(this.remitGroupBox);
            this.collectionGroupBox.Controls.Add(this.penaltyGroupBox);
            this.collectionGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.collectionGroupBox.Name = "collectionGroupBox";
            this.collectionGroupBox.Size = new System.Drawing.Size(742, 661);
            this.collectionGroupBox.TabIndex = 20;
            this.collectionGroupBox.TabStop = false;
            this.collectionGroupBox.Text = "Collection";
            // 
            // loanGroupBox
            // 
            this.loanGroupBox.Controls.Add(this.totalAmountDueGroupBox);
            this.loanGroupBox.Controls.Add(this.totalRemittanceGroupBox);
            this.loanGroupBox.Controls.Add(this.remainingCreditGroupBox);
            this.loanGroupBox.Controls.Add(this.remitButton);
            this.loanGroupBox.Controls.Add(this.loanPanaltyGroupBox);
            this.loanGroupBox.Controls.Add(this.balanceGroupBox);
            this.loanGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanGroupBox.ForeColor = System.Drawing.Color.Black;
            this.loanGroupBox.Location = new System.Drawing.Point(15, 396);
            this.loanGroupBox.Name = "loanGroupBox";
            this.loanGroupBox.Size = new System.Drawing.Size(710, 252);
            this.loanGroupBox.TabIndex = 22;
            this.loanGroupBox.TabStop = false;
            this.loanGroupBox.Text = "Loan";
            // 
            // totalAmountDueGroupBox
            // 
            this.totalAmountDueGroupBox.Controls.Add(this.totalAmountDueLabel);
            this.totalAmountDueGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountDueGroupBox.ForeColor = System.Drawing.Color.Black;
            this.totalAmountDueGroupBox.Location = new System.Drawing.Point(363, 101);
            this.totalAmountDueGroupBox.Name = "totalAmountDueGroupBox";
            this.totalAmountDueGroupBox.Size = new System.Drawing.Size(331, 64);
            this.totalAmountDueGroupBox.TabIndex = 23;
            this.totalAmountDueGroupBox.TabStop = false;
            this.totalAmountDueGroupBox.Text = "Total Amount Due";
            // 
            // totalAmountDueLabel
            // 
            this.totalAmountDueLabel.AutoSize = true;
            this.totalAmountDueLabel.ForeColor = System.Drawing.Color.Black;
            this.totalAmountDueLabel.Location = new System.Drawing.Point(39, 28);
            this.totalAmountDueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalAmountDueLabel.Name = "totalAmountDueLabel";
            this.totalAmountDueLabel.Size = new System.Drawing.Size(126, 25);
            this.totalAmountDueLabel.TabIndex = 0;
            this.totalAmountDueLabel.Text = "totalAmountDue";
            // 
            // totalRemittanceGroupBox
            // 
            this.totalRemittanceGroupBox.Controls.Add(this.remittanceLabel);
            this.totalRemittanceGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRemittanceGroupBox.ForeColor = System.Drawing.Color.Black;
            this.totalRemittanceGroupBox.Location = new System.Drawing.Point(6, 101);
            this.totalRemittanceGroupBox.Name = "totalRemittanceGroupBox";
            this.totalRemittanceGroupBox.Size = new System.Drawing.Size(331, 64);
            this.totalRemittanceGroupBox.TabIndex = 23;
            this.totalRemittanceGroupBox.TabStop = false;
            this.totalRemittanceGroupBox.Text = "Total Remittance";
            // 
            // remittanceLabel
            // 
            this.remittanceLabel.AutoSize = true;
            this.remittanceLabel.ForeColor = System.Drawing.Color.Black;
            this.remittanceLabel.Location = new System.Drawing.Point(39, 28);
            this.remittanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.remittanceLabel.Name = "remittanceLabel";
            this.remittanceLabel.Size = new System.Drawing.Size(124, 25);
            this.remittanceLabel.TabIndex = 0;
            this.remittanceLabel.Text = "totalRemittance";
            // 
            // remainingCreditGroupBox
            // 
            this.remainingCreditGroupBox.Controls.Add(this.remainingCreditLabel);
            this.remainingCreditGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingCreditGroupBox.ForeColor = System.Drawing.Color.Black;
            this.remainingCreditGroupBox.Location = new System.Drawing.Point(6, 171);
            this.remainingCreditGroupBox.Name = "remainingCreditGroupBox";
            this.remainingCreditGroupBox.Size = new System.Drawing.Size(331, 64);
            this.remainingCreditGroupBox.TabIndex = 22;
            this.remainingCreditGroupBox.TabStop = false;
            this.remainingCreditGroupBox.Text = "Remaining Credit";
            // 
            // remainingCreditLabel
            // 
            this.remainingCreditLabel.AutoSize = true;
            this.remainingCreditLabel.ForeColor = System.Drawing.Color.Black;
            this.remainingCreditLabel.Location = new System.Drawing.Point(39, 28);
            this.remainingCreditLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.remainingCreditLabel.Name = "remainingCreditLabel";
            this.remainingCreditLabel.Size = new System.Drawing.Size(54, 25);
            this.remainingCreditLabel.TabIndex = 0;
            this.remainingCreditLabel.Text = "Credit";
            // 
            // loanPanaltyGroupBox
            // 
            this.loanPanaltyGroupBox.Controls.Add(this.penaltyLabel);
            this.loanPanaltyGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanPanaltyGroupBox.ForeColor = System.Drawing.Color.Red;
            this.loanPanaltyGroupBox.Location = new System.Drawing.Point(363, 30);
            this.loanPanaltyGroupBox.Name = "loanPanaltyGroupBox";
            this.loanPanaltyGroupBox.Size = new System.Drawing.Size(331, 64);
            this.loanPanaltyGroupBox.TabIndex = 21;
            this.loanPanaltyGroupBox.TabStop = false;
            this.loanPanaltyGroupBox.Text = "Penalty";
            // 
            // penaltyLabel
            // 
            this.penaltyLabel.AutoSize = true;
            this.penaltyLabel.Location = new System.Drawing.Point(39, 28);
            this.penaltyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.penaltyLabel.Name = "penaltyLabel";
            this.penaltyLabel.Size = new System.Drawing.Size(63, 25);
            this.penaltyLabel.TabIndex = 0;
            this.penaltyLabel.Text = "Penalty";
            // 
            // balanceGroupBox
            // 
            this.balanceGroupBox.Controls.Add(this.loanBalanceLabel);
            this.balanceGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceGroupBox.Location = new System.Drawing.Point(6, 30);
            this.balanceGroupBox.Name = "balanceGroupBox";
            this.balanceGroupBox.Size = new System.Drawing.Size(331, 64);
            this.balanceGroupBox.TabIndex = 20;
            this.balanceGroupBox.TabStop = false;
            this.balanceGroupBox.Text = "Balance";
            // 
            // loanBalanceLabel
            // 
            this.loanBalanceLabel.AutoSize = true;
            this.loanBalanceLabel.Location = new System.Drawing.Point(39, 28);
            this.loanBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loanBalanceLabel.Name = "loanBalanceLabel";
            this.loanBalanceLabel.Size = new System.Drawing.Size(106, 25);
            this.loanBalanceLabel.TabIndex = 0;
            this.loanBalanceLabel.Text = "Loan Balance";
            // 
            // remitGroupBox
            // 
            this.remitGroupBox.Controls.Add(this.remitLoanIdGroupBox);
            this.remitGroupBox.Controls.Add(this.remitAmountGroupBox);
            this.remitGroupBox.Controls.Add(this.remitDateGroupBox);
            this.remitGroupBox.Controls.Add(this.remitCustomerNameGroupBox);
            this.remitGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitGroupBox.ForeColor = System.Drawing.Color.Black;
            this.remitGroupBox.Location = new System.Drawing.Point(15, 26);
            this.remitGroupBox.Name = "remitGroupBox";
            this.remitGroupBox.Size = new System.Drawing.Size(356, 364);
            this.remitGroupBox.TabIndex = 22;
            this.remitGroupBox.TabStop = false;
            this.remitGroupBox.Text = "OnLoadRemit";
            // 
            // penaltyGroupBox
            // 
            this.penaltyGroupBox.Controls.Add(this.penaltyDateGroupBox);
            this.penaltyGroupBox.Controls.Add(this.penaltyAmountGroupBox);
            this.penaltyGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyGroupBox.ForeColor = System.Drawing.Color.Red;
            this.penaltyGroupBox.Location = new System.Drawing.Point(377, 26);
            this.penaltyGroupBox.Name = "penaltyGroupBox";
            this.penaltyGroupBox.Size = new System.Drawing.Size(347, 205);
            this.penaltyGroupBox.TabIndex = 21;
            this.penaltyGroupBox.TabStop = false;
            this.penaltyGroupBox.Text = "Penalty";
            // 
            // penaltyDateGroupBox
            // 
            this.penaltyDateGroupBox.Controls.Add(this.penaltyDateTimePicker);
            this.penaltyDateGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyDateGroupBox.Location = new System.Drawing.Point(6, 26);
            this.penaltyDateGroupBox.Name = "penaltyDateGroupBox";
            this.penaltyDateGroupBox.Size = new System.Drawing.Size(331, 81);
            this.penaltyDateGroupBox.TabIndex = 18;
            this.penaltyDateGroupBox.TabStop = false;
            this.penaltyDateGroupBox.Text = "Date";
            // 
            // penaltyDateTimePicker
            // 
            this.penaltyDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.penaltyDateTimePicker.Location = new System.Drawing.Point(5, 30);
            this.penaltyDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.penaltyDateTimePicker.Name = "penaltyDateTimePicker";
            this.penaltyDateTimePicker.Size = new System.Drawing.Size(321, 28);
            this.penaltyDateTimePicker.TabIndex = 0;
            // 
            // penaltyAmountGroupBox
            // 
            this.penaltyAmountGroupBox.Controls.Add(this.penaltyAmountTextBox);
            this.penaltyAmountGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyAmountGroupBox.Location = new System.Drawing.Point(6, 119);
            this.penaltyAmountGroupBox.Name = "penaltyAmountGroupBox";
            this.penaltyAmountGroupBox.Size = new System.Drawing.Size(331, 76);
            this.penaltyAmountGroupBox.TabIndex = 19;
            this.penaltyAmountGroupBox.TabStop = false;
            this.penaltyAmountGroupBox.Text = "Enter Amount";
            // 
            // penaltyAmountTextBox
            // 
            this.penaltyAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.penaltyAmountTextBox.Location = new System.Drawing.Point(5, 30);
            this.penaltyAmountTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.penaltyAmountTextBox.Name = "penaltyAmountTextBox";
            this.penaltyAmountTextBox.Size = new System.Drawing.Size(321, 28);
            this.penaltyAmountTextBox.TabIndex = 0;
            this.penaltyAmountTextBox.TextChanged += new System.EventHandler(this.PenaltyAmountTextBox_TextChanged);
            // 
            // RemitAndPenaltyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(767, 684);
            this.Controls.Add(this.collectionGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemitAndPenaltyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnLoadRemit And Penalty";
            this.remitDateGroupBox.ResumeLayout(false);
            this.remitAmountGroupBox.ResumeLayout(false);
            this.remitAmountGroupBox.PerformLayout();
            this.remitLoanIdGroupBox.ResumeLayout(false);
            this.remitLoanIdGroupBox.PerformLayout();
            this.remitCustomerNameGroupBox.ResumeLayout(false);
            this.remitCustomerNameGroupBox.PerformLayout();
            this.collectionGroupBox.ResumeLayout(false);
            this.loanGroupBox.ResumeLayout(false);
            this.totalAmountDueGroupBox.ResumeLayout(false);
            this.totalAmountDueGroupBox.PerformLayout();
            this.totalRemittanceGroupBox.ResumeLayout(false);
            this.totalRemittanceGroupBox.PerformLayout();
            this.remainingCreditGroupBox.ResumeLayout(false);
            this.remainingCreditGroupBox.PerformLayout();
            this.loanPanaltyGroupBox.ResumeLayout(false);
            this.loanPanaltyGroupBox.PerformLayout();
            this.balanceGroupBox.ResumeLayout(false);
            this.balanceGroupBox.PerformLayout();
            this.remitGroupBox.ResumeLayout(false);
            this.penaltyGroupBox.ResumeLayout(false);
            this.penaltyDateGroupBox.ResumeLayout(false);
            this.penaltyAmountGroupBox.ResumeLayout(false);
            this.penaltyAmountGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox remitDateGroupBox;
        private System.Windows.Forms.DateTimePicker remitDateTimePicker;
        private System.Windows.Forms.GroupBox remitAmountGroupBox;
        private System.Windows.Forms.TextBox remitAmountTextBox;
        private System.Windows.Forms.Button remitButton;
        private System.Windows.Forms.GroupBox remitLoanIdGroupBox;
        private System.Windows.Forms.Label loanIdlabel;
        private System.Windows.Forms.GroupBox remitCustomerNameGroupBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.GroupBox collectionGroupBox;
        private System.Windows.Forms.GroupBox remitGroupBox;
        private System.Windows.Forms.GroupBox loanGroupBox;
        private System.Windows.Forms.GroupBox balanceGroupBox;
        private System.Windows.Forms.Label loanBalanceLabel;
        private System.Windows.Forms.GroupBox penaltyGroupBox;
        private System.Windows.Forms.GroupBox penaltyDateGroupBox;
        private System.Windows.Forms.DateTimePicker penaltyDateTimePicker;
        private System.Windows.Forms.GroupBox penaltyAmountGroupBox;
        private System.Windows.Forms.TextBox penaltyAmountTextBox;
        private System.Windows.Forms.GroupBox remainingCreditGroupBox;
        private System.Windows.Forms.Label remainingCreditLabel;
        private System.Windows.Forms.GroupBox loanPanaltyGroupBox;
        private System.Windows.Forms.Label penaltyLabel;
        private System.Windows.Forms.GroupBox totalAmountDueGroupBox;
        private System.Windows.Forms.Label totalAmountDueLabel;
        private System.Windows.Forms.GroupBox totalRemittanceGroupBox;
        private System.Windows.Forms.Label remittanceLabel;
    }
}