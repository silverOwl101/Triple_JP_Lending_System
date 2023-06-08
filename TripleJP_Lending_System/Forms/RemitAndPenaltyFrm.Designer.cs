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
            this.saveButton = new System.Windows.Forms.Button();
            this.remitLoanIdGroupBox = new System.Windows.Forms.GroupBox();
            this.loanIdlabel = new System.Windows.Forms.Label();
            this.remitCustomerNameGroupBox = new System.Windows.Forms.GroupBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.collectionGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.totalAmountDuetxt = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.remittancetxt = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.remainingCredittxt = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.penaltytxt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loanBalancetxt = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.remitGroupBox.SuspendLayout();
            this.penaltyGroupBox.SuspendLayout();
            this.penaltyDateGroupBox.SuspendLayout();
            this.penaltyAmountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // remitDateGroupBox
            // 
            this.remitDateGroupBox.Controls.Add(this.remitDateTimePicker);
            this.remitDateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitDateGroupBox.Location = new System.Drawing.Point(13, 219);
            this.remitDateGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.remitDateGroupBox.Name = "remitDateGroupBox";
            this.remitDateGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.remitDateGroupBox.Size = new System.Drawing.Size(441, 100);
            this.remitDateGroupBox.TabIndex = 18;
            this.remitDateGroupBox.TabStop = false;
            this.remitDateGroupBox.Text = "Date";
            // 
            // remitDateTimePicker
            // 
            this.remitDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.remitDateTimePicker.Location = new System.Drawing.Point(7, 37);
            this.remitDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remitDateTimePicker.Name = "remitDateTimePicker";
            this.remitDateTimePicker.Size = new System.Drawing.Size(427, 26);
            this.remitDateTimePicker.TabIndex = 0;
            // 
            // remitAmountGroupBox
            // 
            this.remitAmountGroupBox.Controls.Add(this.remitAmountTextBox);
            this.remitAmountGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitAmountGroupBox.Location = new System.Drawing.Point(13, 334);
            this.remitAmountGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.remitAmountGroupBox.Name = "remitAmountGroupBox";
            this.remitAmountGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.remitAmountGroupBox.Size = new System.Drawing.Size(441, 94);
            this.remitAmountGroupBox.TabIndex = 19;
            this.remitAmountGroupBox.TabStop = false;
            this.remitAmountGroupBox.Text = "Enter Amount";
            // 
            // remitAmountTextBox
            // 
            this.remitAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.remitAmountTextBox.Location = new System.Drawing.Point(7, 37);
            this.remitAmountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remitAmountTextBox.Name = "remitAmountTextBox";
            this.remitAmountTextBox.Size = new System.Drawing.Size(427, 26);
            this.remitAmountTextBox.TabIndex = 0;
            this.remitAmountTextBox.TextChanged += new System.EventHandler(this.remitAmountTextBox_TextChanged);
            this.remitAmountTextBox.Enter += new System.EventHandler(this.RemitTextBox_Enter);
            this.remitAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RemitTextBox_KeyPress);
            this.remitAmountTextBox.Leave += new System.EventHandler(this.RemitTextBox_Leave);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(794, 245);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(131, 56);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Submit";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // remitLoanIdGroupBox
            // 
            this.remitLoanIdGroupBox.Controls.Add(this.loanIdlabel);
            this.remitLoanIdGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitLoanIdGroupBox.Location = new System.Drawing.Point(13, 32);
            this.remitLoanIdGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.remitLoanIdGroupBox.Name = "remitLoanIdGroupBox";
            this.remitLoanIdGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.remitLoanIdGroupBox.Size = new System.Drawing.Size(441, 79);
            this.remitLoanIdGroupBox.TabIndex = 19;
            this.remitLoanIdGroupBox.TabStop = false;
            this.remitLoanIdGroupBox.Text = "Loan ID";
            // 
            // loanIdlabel
            // 
            this.loanIdlabel.AutoSize = true;
            this.loanIdlabel.Location = new System.Drawing.Point(52, 34);
            this.loanIdlabel.Name = "loanIdlabel";
            this.loanIdlabel.Size = new System.Drawing.Size(68, 20);
            this.loanIdlabel.TabIndex = 0;
            this.loanIdlabel.Text = "Load ID";
            // 
            // remitCustomerNameGroupBox
            // 
            this.remitCustomerNameGroupBox.Controls.Add(this.customerNameLabel);
            this.remitCustomerNameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitCustomerNameGroupBox.Location = new System.Drawing.Point(13, 126);
            this.remitCustomerNameGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.remitCustomerNameGroupBox.Name = "remitCustomerNameGroupBox";
            this.remitCustomerNameGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.remitCustomerNameGroupBox.Size = new System.Drawing.Size(441, 79);
            this.remitCustomerNameGroupBox.TabIndex = 20;
            this.remitCustomerNameGroupBox.TabStop = false;
            this.remitCustomerNameGroupBox.Text = "Customer Name";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(52, 34);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(131, 20);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // collectionGroupBox
            // 
            this.collectionGroupBox.Controls.Add(this.groupBox1);
            this.collectionGroupBox.Controls.Add(this.remitGroupBox);
            this.collectionGroupBox.Controls.Add(this.penaltyGroupBox);
            this.collectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionGroupBox.Location = new System.Drawing.Point(16, 15);
            this.collectionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.collectionGroupBox.Name = "collectionGroupBox";
            this.collectionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.collectionGroupBox.Size = new System.Drawing.Size(989, 814);
            this.collectionGroupBox.TabIndex = 20;
            this.collectionGroupBox.TabStop = false;
            this.collectionGroupBox.Text = "Collection";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(20, 488);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(946, 310);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.totalAmountDuetxt);
            this.groupBox6.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(484, 124);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(441, 79);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Total Amount Due";
            // 
            // totalAmountDuetxt
            // 
            this.totalAmountDuetxt.AutoSize = true;
            this.totalAmountDuetxt.ForeColor = System.Drawing.Color.Black;
            this.totalAmountDuetxt.Location = new System.Drawing.Point(52, 34);
            this.totalAmountDuetxt.Name = "totalAmountDuetxt";
            this.totalAmountDuetxt.Size = new System.Drawing.Size(158, 30);
            this.totalAmountDuetxt.TabIndex = 0;
            this.totalAmountDuetxt.Text = "totalAmountDue";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.remittancetxt);
            this.groupBox5.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(8, 124);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(441, 79);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total Remittance";
            // 
            // remittancetxt
            // 
            this.remittancetxt.AutoSize = true;
            this.remittancetxt.ForeColor = System.Drawing.Color.Black;
            this.remittancetxt.Location = new System.Drawing.Point(52, 34);
            this.remittancetxt.Name = "remittancetxt";
            this.remittancetxt.Size = new System.Drawing.Size(156, 30);
            this.remittancetxt.TabIndex = 0;
            this.remittancetxt.Text = "totalRemittance";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.remainingCredittxt);
            this.groupBox4.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(8, 211);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(441, 79);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Remaining Credit";
            // 
            // remainingCredittxt
            // 
            this.remainingCredittxt.AutoSize = true;
            this.remainingCredittxt.ForeColor = System.Drawing.Color.Black;
            this.remainingCredittxt.Location = new System.Drawing.Point(52, 34);
            this.remainingCredittxt.Name = "remainingCredittxt";
            this.remainingCredittxt.Size = new System.Drawing.Size(67, 30);
            this.remainingCredittxt.TabIndex = 0;
            this.remainingCredittxt.Text = "Credit";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.penaltytxt);
            this.groupBox3.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(484, 37);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(441, 79);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Penalty";
            // 
            // penaltytxt
            // 
            this.penaltytxt.AutoSize = true;
            this.penaltytxt.Location = new System.Drawing.Point(52, 34);
            this.penaltytxt.Name = "penaltytxt";
            this.penaltytxt.Size = new System.Drawing.Size(78, 30);
            this.penaltytxt.TabIndex = 0;
            this.penaltytxt.Text = "Penalty";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loanBalancetxt);
            this.groupBox2.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(441, 79);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance";
            // 
            // loanBalancetxt
            // 
            this.loanBalancetxt.AutoSize = true;
            this.loanBalancetxt.Location = new System.Drawing.Point(52, 34);
            this.loanBalancetxt.Name = "loanBalancetxt";
            this.loanBalancetxt.Size = new System.Drawing.Size(130, 30);
            this.loanBalancetxt.TabIndex = 0;
            this.loanBalancetxt.Text = "Loan Balance";
            // 
            // remitGroupBox
            // 
            this.remitGroupBox.Controls.Add(this.remitLoanIdGroupBox);
            this.remitGroupBox.Controls.Add(this.remitAmountGroupBox);
            this.remitGroupBox.Controls.Add(this.remitDateGroupBox);
            this.remitGroupBox.Controls.Add(this.remitCustomerNameGroupBox);
            this.remitGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remitGroupBox.ForeColor = System.Drawing.Color.Black;
            this.remitGroupBox.Location = new System.Drawing.Point(20, 32);
            this.remitGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.remitGroupBox.Name = "remitGroupBox";
            this.remitGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.remitGroupBox.Size = new System.Drawing.Size(475, 448);
            this.remitGroupBox.TabIndex = 22;
            this.remitGroupBox.TabStop = false;
            this.remitGroupBox.Text = "Remit";
            // 
            // penaltyGroupBox
            // 
            this.penaltyGroupBox.Controls.Add(this.penaltyDateGroupBox);
            this.penaltyGroupBox.Controls.Add(this.penaltyAmountGroupBox);
            this.penaltyGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyGroupBox.ForeColor = System.Drawing.Color.Red;
            this.penaltyGroupBox.Location = new System.Drawing.Point(503, 32);
            this.penaltyGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.penaltyGroupBox.Name = "penaltyGroupBox";
            this.penaltyGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.penaltyGroupBox.Size = new System.Drawing.Size(463, 252);
            this.penaltyGroupBox.TabIndex = 21;
            this.penaltyGroupBox.TabStop = false;
            this.penaltyGroupBox.Text = "Penalty";
            // 
            // penaltyDateGroupBox
            // 
            this.penaltyDateGroupBox.Controls.Add(this.penaltyDateTimePicker);
            this.penaltyDateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyDateGroupBox.Location = new System.Drawing.Point(8, 32);
            this.penaltyDateGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.penaltyDateGroupBox.Name = "penaltyDateGroupBox";
            this.penaltyDateGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.penaltyDateGroupBox.Size = new System.Drawing.Size(441, 100);
            this.penaltyDateGroupBox.TabIndex = 18;
            this.penaltyDateGroupBox.TabStop = false;
            this.penaltyDateGroupBox.Text = "Date";
            // 
            // penaltyDateTimePicker
            // 
            this.penaltyDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.penaltyDateTimePicker.Location = new System.Drawing.Point(7, 37);
            this.penaltyDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.penaltyDateTimePicker.Name = "penaltyDateTimePicker";
            this.penaltyDateTimePicker.Size = new System.Drawing.Size(427, 26);
            this.penaltyDateTimePicker.TabIndex = 0;
            // 
            // penaltyAmountGroupBox
            // 
            this.penaltyAmountGroupBox.Controls.Add(this.penaltyAmountTextBox);
            this.penaltyAmountGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyAmountGroupBox.Location = new System.Drawing.Point(8, 146);
            this.penaltyAmountGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.penaltyAmountGroupBox.Name = "penaltyAmountGroupBox";
            this.penaltyAmountGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.penaltyAmountGroupBox.Size = new System.Drawing.Size(441, 94);
            this.penaltyAmountGroupBox.TabIndex = 19;
            this.penaltyAmountGroupBox.TabStop = false;
            this.penaltyAmountGroupBox.Text = "Enter Amount";
            // 
            // penaltyAmountTextBox
            // 
            this.penaltyAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.penaltyAmountTextBox.Location = new System.Drawing.Point(7, 37);
            this.penaltyAmountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.penaltyAmountTextBox.Name = "penaltyAmountTextBox";
            this.penaltyAmountTextBox.Size = new System.Drawing.Size(427, 26);
            this.penaltyAmountTextBox.TabIndex = 0;
            this.penaltyAmountTextBox.TextChanged += new System.EventHandler(this.penaltyAmountTextBox_TextChanged);
            // 
            // RemitAndPenaltyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 842);
            this.Controls.Add(this.collectionGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemitAndPenaltyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remit And Penalty";
            this.remitDateGroupBox.ResumeLayout(false);
            this.remitAmountGroupBox.ResumeLayout(false);
            this.remitAmountGroupBox.PerformLayout();
            this.remitLoanIdGroupBox.ResumeLayout(false);
            this.remitLoanIdGroupBox.PerformLayout();
            this.remitCustomerNameGroupBox.ResumeLayout(false);
            this.remitCustomerNameGroupBox.PerformLayout();
            this.collectionGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox remitLoanIdGroupBox;
        private System.Windows.Forms.Label loanIdlabel;
        private System.Windows.Forms.GroupBox remitCustomerNameGroupBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.GroupBox collectionGroupBox;
        private System.Windows.Forms.GroupBox remitGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label loanBalancetxt;
        private System.Windows.Forms.GroupBox penaltyGroupBox;
        private System.Windows.Forms.GroupBox penaltyDateGroupBox;
        private System.Windows.Forms.DateTimePicker penaltyDateTimePicker;
        private System.Windows.Forms.GroupBox penaltyAmountGroupBox;
        private System.Windows.Forms.TextBox penaltyAmountTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label remainingCredittxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label penaltytxt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label totalAmountDuetxt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label remittancetxt;
    }
}