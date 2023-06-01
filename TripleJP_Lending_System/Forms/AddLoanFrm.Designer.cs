
namespace TripleJP_Lending_System.Forms
{
    partial class AddLoanFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.loanInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.customerPenaltyGroupBox = new System.Windows.Forms.GroupBox();
            this.penaltyComboBox = new System.Windows.Forms.ComboBox();
            this.customerPrincipalLoanGroupBox = new System.Windows.Forms.GroupBox();
            this.principalLoanTextBox = new System.Windows.Forms.TextBox();
            this.customerInterestGroupBox = new System.Windows.Forms.GroupBox();
            this.interestComboBox = new System.Windows.Forms.ComboBox();
            this.customerEffectiveDateGroupBox = new System.Windows.Forms.GroupBox();
            this.effectiveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customerDurationGroupBox = new System.Windows.Forms.GroupBox();
            this.durationComboBox = new System.Windows.Forms.ComboBox();
            this.customerPaymentTermGroupBox = new System.Windows.Forms.GroupBox();
            this.paymentTermComboBox = new System.Windows.Forms.ComboBox();
            this.customerIdGroupBox = new System.Windows.Forms.GroupBox();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.customerNameGroupBox = new System.Windows.Forms.GroupBox();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.loanMaturityInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.perRemittanceGroupBox = new System.Windows.Forms.GroupBox();
            this.perRemittanceLabel = new System.Windows.Forms.Label();
            this.maturityValueGroupBox = new System.Windows.Forms.GroupBox();
            this.maturityValueLabel = new System.Windows.Forms.Label();
            this.maturityDateGroupBox = new System.Windows.Forms.GroupBox();
            this.maturityDateLabel = new System.Windows.Forms.Label();
            this.maturityInterestGroupBox = new System.Windows.Forms.GroupBox();
            this.maturityInterestLabel = new System.Windows.Forms.Label();
            this.loanInformationGroupBox.SuspendLayout();
            this.customerPenaltyGroupBox.SuspendLayout();
            this.customerPrincipalLoanGroupBox.SuspendLayout();
            this.customerInterestGroupBox.SuspendLayout();
            this.customerEffectiveDateGroupBox.SuspendLayout();
            this.customerDurationGroupBox.SuspendLayout();
            this.customerPaymentTermGroupBox.SuspendLayout();
            this.customerIdGroupBox.SuspendLayout();
            this.customerNameGroupBox.SuspendLayout();
            this.loanMaturityInformationGroupBox.SuspendLayout();
            this.perRemittanceGroupBox.SuspendLayout();
            this.maturityValueGroupBox.SuspendLayout();
            this.maturityDateGroupBox.SuspendLayout();
            this.maturityInterestGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loanInformationGroupBox
            // 
            this.loanInformationGroupBox.Controls.Add(this.customerPenaltyGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.customerPrincipalLoanGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.customerInterestGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.customerEffectiveDateGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.customerDurationGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.customerPaymentTermGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.customerIdGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.customerNameGroupBox);
            this.loanInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanInformationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.loanInformationGroupBox.Name = "loanInformationGroupBox";
            this.loanInformationGroupBox.Size = new System.Drawing.Size(868, 323);
            this.loanInformationGroupBox.TabIndex = 14;
            this.loanInformationGroupBox.TabStop = false;
            this.loanInformationGroupBox.Text = "Loan Information";
            // 
            // customerPenaltyGroupBox
            // 
            this.customerPenaltyGroupBox.Controls.Add(this.penaltyComboBox);
            this.customerPenaltyGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPenaltyGroupBox.Location = new System.Drawing.Point(435, 241);
            this.customerPenaltyGroupBox.Name = "customerPenaltyGroupBox";
            this.customerPenaltyGroupBox.Size = new System.Drawing.Size(415, 62);
            this.customerPenaltyGroupBox.TabIndex = 6;
            this.customerPenaltyGroupBox.TabStop = false;
            this.customerPenaltyGroupBox.Text = "Penalty";
            // 
            // penaltyComboBox
            // 
            this.penaltyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyComboBox.FormattingEnabled = true;
            this.penaltyComboBox.Items.AddRange(new object[] {
            "0"});
            this.penaltyComboBox.Location = new System.Drawing.Point(98, 21);
            this.penaltyComboBox.Name = "penaltyComboBox";
            this.penaltyComboBox.Size = new System.Drawing.Size(250, 23);
            this.penaltyComboBox.TabIndex = 6;
            this.penaltyComboBox.TextChanged += new System.EventHandler(this.PenaltyComboBox_TextChanged);
            // 
            // customerPrincipalLoanGroupBox
            // 
            this.customerPrincipalLoanGroupBox.Controls.Add(this.principalLoanTextBox);
            this.customerPrincipalLoanGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPrincipalLoanGroupBox.Location = new System.Drawing.Point(14, 241);
            this.customerPrincipalLoanGroupBox.Name = "customerPrincipalLoanGroupBox";
            this.customerPrincipalLoanGroupBox.Size = new System.Drawing.Size(415, 62);
            this.customerPrincipalLoanGroupBox.TabIndex = 5;
            this.customerPrincipalLoanGroupBox.TabStop = false;
            this.customerPrincipalLoanGroupBox.Text = "Principal Loan";
            // 
            // principalLoanTextBox
            // 
            this.principalLoanTextBox.Location = new System.Drawing.Point(80, 26);
            this.principalLoanTextBox.Name = "principalLoanTextBox";
            this.principalLoanTextBox.Size = new System.Drawing.Size(250, 22);
            this.principalLoanTextBox.TabIndex = 5;
            this.principalLoanTextBox.TextChanged += new System.EventHandler(this.PrincipalLoanTextBox_TextChanged);
            this.principalLoanTextBox.Enter += new System.EventHandler(this.PrincipalLoanTxt_Enter);
            this.principalLoanTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrincipalLoanTxt_KeyPress);
            this.principalLoanTextBox.Leave += new System.EventHandler(this.PrincipalLoanTxt_Leave);
            // 
            // customerInterestGroupBox
            // 
            this.customerInterestGroupBox.Controls.Add(this.interestComboBox);
            this.customerInterestGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInterestGroupBox.Location = new System.Drawing.Point(435, 165);
            this.customerInterestGroupBox.Name = "customerInterestGroupBox";
            this.customerInterestGroupBox.Size = new System.Drawing.Size(415, 70);
            this.customerInterestGroupBox.TabIndex = 4;
            this.customerInterestGroupBox.TabStop = false;
            this.customerInterestGroupBox.Text = "Interest";
            // 
            // interestComboBox
            // 
            this.interestComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestComboBox.FormattingEnabled = true;
            this.interestComboBox.Items.AddRange(new object[] {
            "20"});
            this.interestComboBox.Location = new System.Drawing.Point(98, 21);
            this.interestComboBox.Name = "interestComboBox";
            this.interestComboBox.Size = new System.Drawing.Size(250, 23);
            this.interestComboBox.TabIndex = 4;
            this.interestComboBox.TextChanged += new System.EventHandler(this.InterestComboBox_TextChanged);
            // 
            // customerEffectiveDateGroupBox
            // 
            this.customerEffectiveDateGroupBox.Controls.Add(this.effectiveDateTimePicker);
            this.customerEffectiveDateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEffectiveDateGroupBox.Location = new System.Drawing.Point(14, 165);
            this.customerEffectiveDateGroupBox.Name = "customerEffectiveDateGroupBox";
            this.customerEffectiveDateGroupBox.Size = new System.Drawing.Size(415, 70);
            this.customerEffectiveDateGroupBox.TabIndex = 3;
            this.customerEffectiveDateGroupBox.TabStop = false;
            this.customerEffectiveDateGroupBox.Text = "Effective Date";
            // 
            // effectiveDateTimePicker
            // 
            this.effectiveDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectiveDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectiveDateTimePicker.Location = new System.Drawing.Point(80, 26);
            this.effectiveDateTimePicker.Name = "effectiveDateTimePicker";
            this.effectiveDateTimePicker.Size = new System.Drawing.Size(250, 21);
            this.effectiveDateTimePicker.TabIndex = 3;
            this.effectiveDateTimePicker.ValueChanged += new System.EventHandler(this.EffectiveDateTimePicker_ValueChanged);
            // 
            // customerDurationGroupBox
            // 
            this.customerDurationGroupBox.Controls.Add(this.durationComboBox);
            this.customerDurationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDurationGroupBox.Location = new System.Drawing.Point(435, 93);
            this.customerDurationGroupBox.Name = "customerDurationGroupBox";
            this.customerDurationGroupBox.Size = new System.Drawing.Size(415, 66);
            this.customerDurationGroupBox.TabIndex = 2;
            this.customerDurationGroupBox.TabStop = false;
            this.customerDurationGroupBox.Text = "Duration";
            // 
            // durationComboBox
            // 
            this.durationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationComboBox.FormattingEnabled = true;
            this.durationComboBox.Items.AddRange(new object[] {
            "30",
            "60"});
            this.durationComboBox.Location = new System.Drawing.Point(98, 21);
            this.durationComboBox.Name = "durationComboBox";
            this.durationComboBox.Size = new System.Drawing.Size(250, 23);
            this.durationComboBox.TabIndex = 2;
            this.durationComboBox.TextChanged += new System.EventHandler(this.DurationComboBox_TextChanged);
            // 
            // customerPaymentTermGroupBox
            // 
            this.customerPaymentTermGroupBox.Controls.Add(this.paymentTermComboBox);
            this.customerPaymentTermGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPaymentTermGroupBox.Location = new System.Drawing.Point(14, 93);
            this.customerPaymentTermGroupBox.Name = "customerPaymentTermGroupBox";
            this.customerPaymentTermGroupBox.Size = new System.Drawing.Size(415, 66);
            this.customerPaymentTermGroupBox.TabIndex = 1;
            this.customerPaymentTermGroupBox.TabStop = false;
            this.customerPaymentTermGroupBox.Text = "Payment Term";
            // 
            // paymentTermComboBox
            // 
            this.paymentTermComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTermComboBox.FormattingEnabled = true;
            this.paymentTermComboBox.Items.AddRange(new object[] {
            "Daily"});
            this.paymentTermComboBox.Location = new System.Drawing.Point(80, 26);
            this.paymentTermComboBox.Name = "paymentTermComboBox";
            this.paymentTermComboBox.Size = new System.Drawing.Size(250, 23);
            this.paymentTermComboBox.TabIndex = 1;
            this.paymentTermComboBox.TextChanged += new System.EventHandler(this.PaymentTermComboBox_TextChanged);
            // 
            // customerIdGroupBox
            // 
            this.customerIdGroupBox.Controls.Add(this.customerIdLabel);
            this.customerIdGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdGroupBox.Location = new System.Drawing.Point(14, 30);
            this.customerIdGroupBox.Name = "customerIdGroupBox";
            this.customerIdGroupBox.Size = new System.Drawing.Size(415, 57);
            this.customerIdGroupBox.TabIndex = 19;
            this.customerIdGroupBox.TabStop = false;
            this.customerIdGroupBox.Text = "Customer ID";
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(76, 23);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(133, 16);
            this.customerIdLabel.TabIndex = 0;
            this.customerIdLabel.Text = "customerNameLabel";
            // 
            // customerNameGroupBox
            // 
            this.customerNameGroupBox.Controls.Add(this.customerAddressLabel);
            this.customerNameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameGroupBox.Location = new System.Drawing.Point(435, 30);
            this.customerNameGroupBox.Name = "customerNameGroupBox";
            this.customerNameGroupBox.Size = new System.Drawing.Size(415, 57);
            this.customerNameGroupBox.TabIndex = 18;
            this.customerNameGroupBox.TabStop = false;
            this.customerNameGroupBox.Text = "Customer Name";
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Location = new System.Drawing.Point(94, 23);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(147, 16);
            this.customerAddressLabel.TabIndex = 0;
            this.customerAddressLabel.Text = "customerAddressLabel";
            // 
            // loanMaturityInformationGroupBox
            // 
            this.loanMaturityInformationGroupBox.Controls.Add(this.saveButton);
            this.loanMaturityInformationGroupBox.Controls.Add(this.calculateButton);
            this.loanMaturityInformationGroupBox.Controls.Add(this.perRemittanceGroupBox);
            this.loanMaturityInformationGroupBox.Controls.Add(this.maturityValueGroupBox);
            this.loanMaturityInformationGroupBox.Controls.Add(this.maturityDateGroupBox);
            this.loanMaturityInformationGroupBox.Controls.Add(this.maturityInterestGroupBox);
            this.loanMaturityInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanMaturityInformationGroupBox.Location = new System.Drawing.Point(12, 341);
            this.loanMaturityInformationGroupBox.Name = "loanMaturityInformationGroupBox";
            this.loanMaturityInformationGroupBox.Size = new System.Drawing.Size(868, 229);
            this.loanMaturityInformationGroupBox.TabIndex = 22;
            this.loanMaturityInformationGroupBox.TabStop = false;
            this.loanMaturityInformationGroupBox.Text = "Loan Maturity Information";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(643, 168);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 46);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(756, 167);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 46);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // perRemittanceGroupBox
            // 
            this.perRemittanceGroupBox.Controls.Add(this.perRemittanceLabel);
            this.perRemittanceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perRemittanceGroupBox.Location = new System.Drawing.Point(435, 93);
            this.perRemittanceGroupBox.Name = "perRemittanceGroupBox";
            this.perRemittanceGroupBox.Size = new System.Drawing.Size(415, 57);
            this.perRemittanceGroupBox.TabIndex = 19;
            this.perRemittanceGroupBox.TabStop = false;
            this.perRemittanceGroupBox.Text = "Per Remittance";
            // 
            // perRemittanceLabel
            // 
            this.perRemittanceLabel.AutoSize = true;
            this.perRemittanceLabel.Location = new System.Drawing.Point(60, 23);
            this.perRemittanceLabel.Name = "perRemittanceLabel";
            this.perRemittanceLabel.Size = new System.Drawing.Size(113, 16);
            this.perRemittanceLabel.TabIndex = 0;
            this.perRemittanceLabel.Text = "perRemittanceTxt";
            // 
            // maturityValueGroupBox
            // 
            this.maturityValueGroupBox.Controls.Add(this.maturityValueLabel);
            this.maturityValueGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maturityValueGroupBox.Location = new System.Drawing.Point(435, 30);
            this.maturityValueGroupBox.Name = "maturityValueGroupBox";
            this.maturityValueGroupBox.Size = new System.Drawing.Size(415, 57);
            this.maturityValueGroupBox.TabIndex = 19;
            this.maturityValueGroupBox.TabStop = false;
            this.maturityValueGroupBox.Text = "Maturity Value";
            // 
            // maturityValueLabel
            // 
            this.maturityValueLabel.AutoSize = true;
            this.maturityValueLabel.Location = new System.Drawing.Point(60, 23);
            this.maturityValueLabel.Name = "maturityValueLabel";
            this.maturityValueLabel.Size = new System.Drawing.Size(106, 16);
            this.maturityValueLabel.TabIndex = 0;
            this.maturityValueLabel.Text = "maturityValueTxt";
            // 
            // maturityDateGroupBox
            // 
            this.maturityDateGroupBox.Controls.Add(this.maturityDateLabel);
            this.maturityDateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maturityDateGroupBox.Location = new System.Drawing.Point(14, 93);
            this.maturityDateGroupBox.Name = "maturityDateGroupBox";
            this.maturityDateGroupBox.Size = new System.Drawing.Size(415, 57);
            this.maturityDateGroupBox.TabIndex = 18;
            this.maturityDateGroupBox.TabStop = false;
            this.maturityDateGroupBox.Text = "Maturity Date";
            // 
            // maturityDateLabel
            // 
            this.maturityDateLabel.AutoSize = true;
            this.maturityDateLabel.Location = new System.Drawing.Point(60, 23);
            this.maturityDateLabel.Name = "maturityDateLabel";
            this.maturityDateLabel.Size = new System.Drawing.Size(100, 16);
            this.maturityDateLabel.TabIndex = 0;
            this.maturityDateLabel.Text = "maturityDateTxt";
            // 
            // maturityInterestGroupBox
            // 
            this.maturityInterestGroupBox.Controls.Add(this.maturityInterestLabel);
            this.maturityInterestGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maturityInterestGroupBox.Location = new System.Drawing.Point(14, 30);
            this.maturityInterestGroupBox.Name = "maturityInterestGroupBox";
            this.maturityInterestGroupBox.Size = new System.Drawing.Size(415, 57);
            this.maturityInterestGroupBox.TabIndex = 17;
            this.maturityInterestGroupBox.TabStop = false;
            this.maturityInterestGroupBox.Text = "Maturity Interest";
            // 
            // maturityInterestLabel
            // 
            this.maturityInterestLabel.AutoSize = true;
            this.maturityInterestLabel.Location = new System.Drawing.Point(60, 23);
            this.maturityInterestLabel.Name = "maturityInterestLabel";
            this.maturityInterestLabel.Size = new System.Drawing.Size(114, 16);
            this.maturityInterestLabel.TabIndex = 0;
            this.maturityInterestLabel.Text = "maturityInterestTxt";
            // 
            // AddLoanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 588);
            this.Controls.Add(this.loanMaturityInformationGroupBox);
            this.Controls.Add(this.loanInformationGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddLoanFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLoanFrm";
            this.loanInformationGroupBox.ResumeLayout(false);
            this.customerPenaltyGroupBox.ResumeLayout(false);
            this.customerPrincipalLoanGroupBox.ResumeLayout(false);
            this.customerPrincipalLoanGroupBox.PerformLayout();
            this.customerInterestGroupBox.ResumeLayout(false);
            this.customerEffectiveDateGroupBox.ResumeLayout(false);
            this.customerDurationGroupBox.ResumeLayout(false);
            this.customerPaymentTermGroupBox.ResumeLayout(false);
            this.customerIdGroupBox.ResumeLayout(false);
            this.customerIdGroupBox.PerformLayout();
            this.customerNameGroupBox.ResumeLayout(false);
            this.customerNameGroupBox.PerformLayout();
            this.loanMaturityInformationGroupBox.ResumeLayout(false);
            this.perRemittanceGroupBox.ResumeLayout(false);
            this.perRemittanceGroupBox.PerformLayout();
            this.maturityValueGroupBox.ResumeLayout(false);
            this.maturityValueGroupBox.PerformLayout();
            this.maturityDateGroupBox.ResumeLayout(false);
            this.maturityDateGroupBox.PerformLayout();
            this.maturityInterestGroupBox.ResumeLayout(false);
            this.maturityInterestGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loanInformationGroupBox;
        private System.Windows.Forms.GroupBox customerPenaltyGroupBox;
        private System.Windows.Forms.ComboBox penaltyComboBox;
        private System.Windows.Forms.GroupBox customerPrincipalLoanGroupBox;
        private System.Windows.Forms.GroupBox customerInterestGroupBox;
        private System.Windows.Forms.ComboBox interestComboBox;
        private System.Windows.Forms.GroupBox customerEffectiveDateGroupBox;
        private System.Windows.Forms.DateTimePicker effectiveDateTimePicker;
        private System.Windows.Forms.GroupBox customerDurationGroupBox;
        private System.Windows.Forms.ComboBox durationComboBox;
        private System.Windows.Forms.GroupBox customerPaymentTermGroupBox;
        private System.Windows.Forms.ComboBox paymentTermComboBox;
        private System.Windows.Forms.GroupBox customerIdGroupBox;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.GroupBox customerNameGroupBox;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.GroupBox loanMaturityInformationGroupBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox perRemittanceGroupBox;
        private System.Windows.Forms.Label perRemittanceLabel;
        private System.Windows.Forms.GroupBox maturityValueGroupBox;
        private System.Windows.Forms.Label maturityValueLabel;
        private System.Windows.Forms.GroupBox maturityDateGroupBox;
        private System.Windows.Forms.Label maturityDateLabel;
        private System.Windows.Forms.GroupBox maturityInterestGroupBox;
        private System.Windows.Forms.Label maturityInterestLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox principalLoanTextBox;
    }
}