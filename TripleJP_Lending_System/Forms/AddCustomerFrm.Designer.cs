
namespace TripleJP_Lending_System.Forms
{
    partial class AddCustomerFrm
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
            this.personalInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.averageDailyGrossSalesTxt = new System.Windows.Forms.TextBox();
            this.grossBusinessCapitalLabel = new System.Windows.Forms.Label();
            this.grossBusinessCapitalTxt = new System.Windows.Forms.TextBox();
            this.businessAddressLabel = new System.Windows.Forms.Label();
            this.businessAddressTxt = new System.Windows.Forms.TextBox();
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.businessNatureLabel = new System.Windows.Forms.Label();
            this.contactNumberTxt = new System.Windows.Forms.TextBox();
            this.businessNameLabel = new System.Windows.Forms.Label();
            this.customerAddressTxt = new System.Windows.Forms.TextBox();
            this.customerNumberLabel = new System.Windows.Forms.Label();
            this.businessNameTxt = new System.Windows.Forms.TextBox();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.businessNatureTxt = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.businessAverageGrossSalesLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.personalInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // personalInformationGroupBox
            // 
            this.personalInformationGroupBox.Controls.Add(this.averageDailyGrossSalesTxt);
            this.personalInformationGroupBox.Controls.Add(this.grossBusinessCapitalLabel);
            this.personalInformationGroupBox.Controls.Add(this.grossBusinessCapitalTxt);
            this.personalInformationGroupBox.Controls.Add(this.businessAddressLabel);
            this.personalInformationGroupBox.Controls.Add(this.businessAddressTxt);
            this.personalInformationGroupBox.Controls.Add(this.customerNameTxt);
            this.personalInformationGroupBox.Controls.Add(this.businessNatureLabel);
            this.personalInformationGroupBox.Controls.Add(this.contactNumberTxt);
            this.personalInformationGroupBox.Controls.Add(this.businessNameLabel);
            this.personalInformationGroupBox.Controls.Add(this.customerAddressTxt);
            this.personalInformationGroupBox.Controls.Add(this.customerNumberLabel);
            this.personalInformationGroupBox.Controls.Add(this.businessNameTxt);
            this.personalInformationGroupBox.Controls.Add(this.customerAddressLabel);
            this.personalInformationGroupBox.Controls.Add(this.businessNatureTxt);
            this.personalInformationGroupBox.Controls.Add(this.customerNameLabel);
            this.personalInformationGroupBox.Controls.Add(this.businessAverageGrossSalesLabel);
            this.personalInformationGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInformationGroupBox.Location = new System.Drawing.Point(22, 12);
            this.personalInformationGroupBox.Name = "personalInformationGroupBox";
            this.personalInformationGroupBox.Size = new System.Drawing.Size(687, 329);
            this.personalInformationGroupBox.TabIndex = 11;
            this.personalInformationGroupBox.TabStop = false;
            this.personalInformationGroupBox.Text = "Personal Information ";
            // 
            // averageDailyGrossSalesTxt
            // 
            this.averageDailyGrossSalesTxt.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageDailyGrossSalesTxt.Location = new System.Drawing.Point(210, 270);
            this.averageDailyGrossSalesTxt.Name = "averageDailyGrossSalesTxt";
            this.averageDailyGrossSalesTxt.Size = new System.Drawing.Size(433, 27);
            this.averageDailyGrossSalesTxt.TabIndex = 8;
            this.averageDailyGrossSalesTxt.Enter += new System.EventHandler(this.AverageDailyGrossSalestxt_Enter);
            this.averageDailyGrossSalesTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AverageDailyGrossSalestxt_KeyPress);
            this.averageDailyGrossSalesTxt.Leave += new System.EventHandler(this.AverageDailyGrossSalestxt_Leave);
            // 
            // grossBusinessCapitalLabel
            // 
            this.grossBusinessCapitalLabel.AutoSize = true;
            this.grossBusinessCapitalLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossBusinessCapitalLabel.Location = new System.Drawing.Point(32, 237);
            this.grossBusinessCapitalLabel.Name = "grossBusinessCapitalLabel";
            this.grossBusinessCapitalLabel.Size = new System.Drawing.Size(171, 25);
            this.grossBusinessCapitalLabel.TabIndex = 13;
            this.grossBusinessCapitalLabel.Text = "Gross Business Capital:";
            // 
            // grossBusinessCapitalTxt
            // 
            this.grossBusinessCapitalTxt.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossBusinessCapitalTxt.Location = new System.Drawing.Point(210, 237);
            this.grossBusinessCapitalTxt.Name = "grossBusinessCapitalTxt";
            this.grossBusinessCapitalTxt.Size = new System.Drawing.Size(433, 27);
            this.grossBusinessCapitalTxt.TabIndex = 7;
            this.grossBusinessCapitalTxt.Enter += new System.EventHandler(this.GrossBusinessCapitaltxt_Enter);
            this.grossBusinessCapitalTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GrossBusinessCapitaltxt_KeyPress);
            this.grossBusinessCapitalTxt.Leave += new System.EventHandler(this.GrossBusinessCapitaltxt_Leave);
            // 
            // businessAddressLabel
            // 
            this.businessAddressLabel.AutoSize = true;
            this.businessAddressLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessAddressLabel.Location = new System.Drawing.Point(65, 202);
            this.businessAddressLabel.Name = "businessAddressLabel";
            this.businessAddressLabel.Size = new System.Drawing.Size(134, 25);
            this.businessAddressLabel.TabIndex = 11;
            this.businessAddressLabel.Text = "Business Address:";
            // 
            // businessAddressTxt
            // 
            this.businessAddressTxt.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessAddressTxt.Location = new System.Drawing.Point(210, 202);
            this.businessAddressTxt.Name = "businessAddressTxt";
            this.businessAddressTxt.Size = new System.Drawing.Size(433, 27);
            this.businessAddressTxt.TabIndex = 6;
            this.businessAddressTxt.TextChanged += new System.EventHandler(this.BusinessAddresstxt_TextChanged);
            this.businessAddressTxt.Leave += new System.EventHandler(this.BusinessAddresstxt_Leave);
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTxt.Location = new System.Drawing.Point(210, 27);
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(433, 27);
            this.customerNameTxt.TabIndex = 1;
            this.customerNameTxt.TextChanged += new System.EventHandler(this.CustomerNametxt_TextChanged);
            this.customerNameTxt.Leave += new System.EventHandler(this.CustomerNametxt_Leave);
            // 
            // businessNatureLabel
            // 
            this.businessNatureLabel.AutoSize = true;
            this.businessNatureLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessNatureLabel.Location = new System.Drawing.Point(75, 167);
            this.businessNatureLabel.Name = "businessNatureLabel";
            this.businessNatureLabel.Size = new System.Drawing.Size(126, 25);
            this.businessNatureLabel.TabIndex = 9;
            this.businessNatureLabel.Text = "Business Nature:";
            // 
            // contactNumberTxt
            // 
            this.contactNumberTxt.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberTxt.Location = new System.Drawing.Point(210, 97);
            this.contactNumberTxt.Name = "contactNumberTxt";
            this.contactNumberTxt.Size = new System.Drawing.Size(433, 27);
            this.contactNumberTxt.TabIndex = 3;
            this.contactNumberTxt.TextChanged += new System.EventHandler(this.ContactNumbertxt_TextChanged);
            this.contactNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactNumbertxt_KeyPress);
            this.contactNumberTxt.Leave += new System.EventHandler(this.ContactNumbertxt_Leave);
            // 
            // businessNameLabel
            // 
            this.businessNameLabel.AutoSize = true;
            this.businessNameLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessNameLabel.Location = new System.Drawing.Point(80, 133);
            this.businessNameLabel.Name = "businessNameLabel";
            this.businessNameLabel.Size = new System.Drawing.Size(121, 25);
            this.businessNameLabel.TabIndex = 8;
            this.businessNameLabel.Text = "Business Name:";
            // 
            // customerAddressTxt
            // 
            this.customerAddressTxt.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressTxt.Location = new System.Drawing.Point(210, 62);
            this.customerAddressTxt.Name = "customerAddressTxt";
            this.customerAddressTxt.Size = new System.Drawing.Size(433, 27);
            this.customerAddressTxt.TabIndex = 2;
            this.customerAddressTxt.TextChanged += new System.EventHandler(this.CustomerAddresstxt_TextChanged);
            this.customerAddressTxt.Leave += new System.EventHandler(this.CustomerAddresstxt_Leave);
            // 
            // customerNumberLabel
            // 
            this.customerNumberLabel.AutoSize = true;
            this.customerNumberLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNumberLabel.Location = new System.Drawing.Point(70, 98);
            this.customerNumberLabel.Name = "customerNumberLabel";
            this.customerNumberLabel.Size = new System.Drawing.Size(132, 25);
            this.customerNumberLabel.TabIndex = 7;
            this.customerNumberLabel.Text = "Contact Number:";
            // 
            // businessNameTxt
            // 
            this.businessNameTxt.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessNameTxt.Location = new System.Drawing.Point(210, 132);
            this.businessNameTxt.Name = "businessNameTxt";
            this.businessNameTxt.Size = new System.Drawing.Size(433, 27);
            this.businessNameTxt.TabIndex = 4;
            this.businessNameTxt.TextChanged += new System.EventHandler(this.BusinessNametxt_TextChanged);
            this.businessNameTxt.Leave += new System.EventHandler(this.BusinessNametxt_Leave);
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressLabel.Location = new System.Drawing.Point(57, 61);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(143, 25);
            this.customerAddressLabel.TabIndex = 6;
            this.customerAddressLabel.Text = "Customer Address:";
            // 
            // businessNatureTxt
            // 
            this.businessNatureTxt.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessNatureTxt.Location = new System.Drawing.Point(210, 167);
            this.businessNatureTxt.Name = "businessNatureTxt";
            this.businessNatureTxt.Size = new System.Drawing.Size(433, 27);
            this.businessNatureTxt.TabIndex = 5;
            this.businessNatureTxt.TextChanged += new System.EventHandler(this.BusinessNaturetxt_TextChanged);
            this.businessNatureTxt.Leave += new System.EventHandler(this.BusinessNaturetxt_Leave);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(72, 28);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(130, 25);
            this.customerNameLabel.TabIndex = 5;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // businessAverageGrossSalesLabel
            // 
            this.businessAverageGrossSalesLabel.AutoSize = true;
            this.businessAverageGrossSalesLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessAverageGrossSalesLabel.Location = new System.Drawing.Point(11, 271);
            this.businessAverageGrossSalesLabel.Name = "businessAverageGrossSalesLabel";
            this.businessAverageGrossSalesLabel.Size = new System.Drawing.Size(193, 25);
            this.businessAverageGrossSalesLabel.TabIndex = 15;
            this.businessAverageGrossSalesLabel.Text = "Average Daily Gross Sales:";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(598, 348);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(112, 45);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // AddCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(750, 410);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.personalInformationGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddCustomerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.personalInformationGroupBox.ResumeLayout(false);
            this.personalInformationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personalInformationGroupBox;
        private System.Windows.Forms.TextBox averageDailyGrossSalesTxt;
        private System.Windows.Forms.Label grossBusinessCapitalLabel;
        private System.Windows.Forms.TextBox grossBusinessCapitalTxt;
        private System.Windows.Forms.Label businessAddressLabel;
        private System.Windows.Forms.TextBox businessAddressTxt;
        private System.Windows.Forms.Label businessNatureLabel;
        private System.Windows.Forms.TextBox contactNumberTxt;
        private System.Windows.Forms.Label businessNameLabel;
        private System.Windows.Forms.TextBox customerAddressTxt;
        private System.Windows.Forms.Label customerNumberLabel;
        private System.Windows.Forms.TextBox businessNameTxt;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.TextBox businessNatureTxt;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label businessAverageGrossSalesLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox customerNameTxt;
    }
}