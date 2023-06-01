
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.penaltyComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.principalLoanTextBox = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.interestComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.EffectiveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.durationComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.paymentTermComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.perRemittanceLabel = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.maturityValueLabel = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.maturityDateLabel = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.maturityInterestLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 323);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Information";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.penaltyComboBox);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(435, 241);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(415, 62);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Penalty";
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
            this.penaltyComboBox.TextChanged += new System.EventHandler(this.comboBox6_TextChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.principalLoanTextBox);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(14, 241);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(415, 62);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Principal Loan";
            // 
            // principalLoanTextBox
            // 
            this.principalLoanTextBox.Location = new System.Drawing.Point(80, 26);
            this.principalLoanTextBox.Name = "principalLoanTextBox";
            this.principalLoanTextBox.Size = new System.Drawing.Size(250, 22);
            this.principalLoanTextBox.TabIndex = 5;
            this.principalLoanTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.principalLoanTextBox.Enter += new System.EventHandler(this.textBox1_Enter);
            this.principalLoanTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.principalLoanTextBox.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.interestComboBox);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(435, 165);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(415, 70);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Interest";
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
            this.interestComboBox.TextChanged += new System.EventHandler(this.comboBox4_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.EffectiveDateTimePicker);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(14, 165);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(415, 70);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Effective Date";
            // 
            // EffectiveDateTimePicker
            // 
            this.EffectiveDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffectiveDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffectiveDateTimePicker.Location = new System.Drawing.Point(80, 26);
            this.EffectiveDateTimePicker.Name = "EffectiveDateTimePicker";
            this.EffectiveDateTimePicker.Size = new System.Drawing.Size(250, 21);
            this.EffectiveDateTimePicker.TabIndex = 3;
            this.EffectiveDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.durationComboBox);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(435, 93);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(415, 66);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Duration";
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
            this.durationComboBox.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.paymentTermComboBox);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(14, 93);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(415, 66);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Payment Term";
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
            this.paymentTermComboBox.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.customerIdLabel);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(14, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 57);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customer ID";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.customerAddressLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(435, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 57);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Name";
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
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.saveButton);
            this.groupBox12.Controls.Add(this.calculateButton);
            this.groupBox12.Controls.Add(this.groupBox19);
            this.groupBox12.Controls.Add(this.groupBox20);
            this.groupBox12.Controls.Add(this.groupBox21);
            this.groupBox12.Controls.Add(this.groupBox22);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(12, 341);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(868, 229);
            this.groupBox12.TabIndex = 22;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Loan Maturity Information";
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
            this.saveButton.Click += new System.EventHandler(this.button2_Click);
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
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.perRemittanceLabel);
            this.groupBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox19.Location = new System.Drawing.Point(435, 93);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(415, 57);
            this.groupBox19.TabIndex = 19;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Per Remittance";
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
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.maturityValueLabel);
            this.groupBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox20.Location = new System.Drawing.Point(435, 30);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(415, 57);
            this.groupBox20.TabIndex = 19;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Maturity Value";
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
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.maturityDateLabel);
            this.groupBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox21.Location = new System.Drawing.Point(14, 93);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(415, 57);
            this.groupBox21.TabIndex = 18;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Maturity Date";
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
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.maturityInterestLabel);
            this.groupBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox22.Location = new System.Drawing.Point(14, 30);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(415, 57);
            this.groupBox22.TabIndex = 17;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Maturity Interest";
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
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddLoanFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLoanFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox penaltyComboBox;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox interestComboBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker EffectiveDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox durationComboBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox paymentTermComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label perRemittanceLabel;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label maturityValueLabel;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Label maturityDateLabel;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Label maturityInterestLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox principalLoanTextBox;
    }
}