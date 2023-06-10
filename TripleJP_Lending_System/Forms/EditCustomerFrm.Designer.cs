
namespace TripleJP_Lending_System.Forms
{
    partial class EditCustomerFrm
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
            this.personalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.averageDailyGrossSalesTextBox = new System.Windows.Forms.TextBox();
            this.businessCapitalLabel = new System.Windows.Forms.Label();
            this.grossBusinessCapitalTextBox = new System.Windows.Forms.TextBox();
            this.businessAddressLabel = new System.Windows.Forms.Label();
            this.businessAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.businessNatureLabel = new System.Windows.Forms.Label();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.businessNameLabel = new System.Windows.Forms.Label();
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerNumberLabel = new System.Windows.Forms.Label();
            this.businessNameTextBox = new System.Windows.Forms.TextBox();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.businessNatureTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.businessAverageGrossLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.personalInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // personalInfoGroupBox
            // 
            this.personalInfoGroupBox.Controls.Add(this.averageDailyGrossSalesTextBox);
            this.personalInfoGroupBox.Controls.Add(this.businessCapitalLabel);
            this.personalInfoGroupBox.Controls.Add(this.grossBusinessCapitalTextBox);
            this.personalInfoGroupBox.Controls.Add(this.businessAddressLabel);
            this.personalInfoGroupBox.Controls.Add(this.businessAddressTextBox);
            this.personalInfoGroupBox.Controls.Add(this.customerNameTextBox);
            this.personalInfoGroupBox.Controls.Add(this.businessNatureLabel);
            this.personalInfoGroupBox.Controls.Add(this.contactNumberTextBox);
            this.personalInfoGroupBox.Controls.Add(this.businessNameLabel);
            this.personalInfoGroupBox.Controls.Add(this.customerAddressTextBox);
            this.personalInfoGroupBox.Controls.Add(this.customerNumberLabel);
            this.personalInfoGroupBox.Controls.Add(this.businessNameTextBox);
            this.personalInfoGroupBox.Controls.Add(this.customerAddressLabel);
            this.personalInfoGroupBox.Controls.Add(this.businessNatureTextBox);
            this.personalInfoGroupBox.Controls.Add(this.customerNameLabel);
            this.personalInfoGroupBox.Controls.Add(this.businessAverageGrossLabel);
            this.personalInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoGroupBox.Location = new System.Drawing.Point(55, 30);
            this.personalInfoGroupBox.Name = "personalInfoGroupBox";
            this.personalInfoGroupBox.Size = new System.Drawing.Size(687, 329);
            this.personalInfoGroupBox.TabIndex = 12;
            this.personalInfoGroupBox.TabStop = false;
            this.personalInfoGroupBox.Text = "Personal Information ";
            // 
            // averageDailyGrossSalesTextBox
            // 
            this.averageDailyGrossSalesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageDailyGrossSalesTextBox.Location = new System.Drawing.Point(210, 270);
            this.averageDailyGrossSalesTextBox.Name = "averageDailyGrossSalesTextBox";
            this.averageDailyGrossSalesTextBox.Size = new System.Drawing.Size(433, 24);
            this.averageDailyGrossSalesTextBox.TabIndex = 8;
            this.averageDailyGrossSalesTextBox.Enter += new System.EventHandler(this.AverageDailyGrossSalestxt_Enter);
            this.averageDailyGrossSalesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AverageDailyGrossSalestxt_KeyPress);
            this.averageDailyGrossSalesTextBox.Leave += new System.EventHandler(this.AverageDailyGrossSalestxt_Leave);
            // 
            // businessCapitalLabel
            // 
            this.businessCapitalLabel.AutoSize = true;
            this.businessCapitalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessCapitalLabel.Location = new System.Drawing.Point(47, 243);
            this.businessCapitalLabel.Name = "businessCapitalLabel";
            this.businessCapitalLabel.Size = new System.Drawing.Size(149, 16);
            this.businessCapitalLabel.TabIndex = 13;
            this.businessCapitalLabel.Text = "Gross Business Capital:";
            // 
            // grossBusinessCapitalTextBox
            // 
            this.grossBusinessCapitalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossBusinessCapitalTextBox.Location = new System.Drawing.Point(210, 237);
            this.grossBusinessCapitalTextBox.Name = "grossBusinessCapitalTextBox";
            this.grossBusinessCapitalTextBox.Size = new System.Drawing.Size(433, 24);
            this.grossBusinessCapitalTextBox.TabIndex = 7;
            this.grossBusinessCapitalTextBox.Enter += new System.EventHandler(this.GrossBusinessCapitaltxt_Enter);
            this.grossBusinessCapitalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GrossBusinessCapitaltxt_KeyPress);
            this.grossBusinessCapitalTextBox.Leave += new System.EventHandler(this.GrossBusinessCapitaltxt_Leave);
            // 
            // businessAddressLabel
            // 
            this.businessAddressLabel.AutoSize = true;
            this.businessAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessAddressLabel.Location = new System.Drawing.Point(81, 208);
            this.businessAddressLabel.Name = "businessAddressLabel";
            this.businessAddressLabel.Size = new System.Drawing.Size(119, 16);
            this.businessAddressLabel.TabIndex = 11;
            this.businessAddressLabel.Text = "Business Address:";
            // 
            // businessAddressTextBox
            // 
            this.businessAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessAddressTextBox.Location = new System.Drawing.Point(210, 202);
            this.businessAddressTextBox.Name = "businessAddressTextBox";
            this.businessAddressTextBox.Size = new System.Drawing.Size(433, 24);
            this.businessAddressTextBox.TabIndex = 6;
            this.businessAddressTextBox.TextChanged += new System.EventHandler(this.BusinessAddresstxt_TextChanged);
            this.businessAddressTextBox.Leave += new System.EventHandler(this.BusinessAddresstxt_Leave);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(210, 27);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(433, 24);
            this.customerNameTextBox.TabIndex = 1;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.CustomerNametxt_TextChanged);
            this.customerNameTextBox.Leave += new System.EventHandler(this.CustomerNametxt_Leave);
            // 
            // businessNatureLabel
            // 
            this.businessNatureLabel.AutoSize = true;
            this.businessNatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessNatureLabel.Location = new System.Drawing.Point(91, 173);
            this.businessNatureLabel.Name = "businessNatureLabel";
            this.businessNatureLabel.Size = new System.Drawing.Size(108, 16);
            this.businessNatureLabel.TabIndex = 9;
            this.businessNatureLabel.Text = "Business Nature:";
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberTextBox.Location = new System.Drawing.Point(210, 97);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(433, 24);
            this.contactNumberTextBox.TabIndex = 3;
            this.contactNumberTextBox.TextChanged += new System.EventHandler(this.ContactNumbertxt_TextChanged);
            this.contactNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactNumbertxt_KeyPress);
            this.contactNumberTextBox.Leave += new System.EventHandler(this.ContactNumbertxt_Leave);
            // 
            // businessNameLabel
            // 
            this.businessNameLabel.AutoSize = true;
            this.businessNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessNameLabel.Location = new System.Drawing.Point(96, 139);
            this.businessNameLabel.Name = "businessNameLabel";
            this.businessNameLabel.Size = new System.Drawing.Size(105, 16);
            this.businessNameLabel.TabIndex = 8;
            this.businessNameLabel.Text = "Business Name:";
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressTextBox.Location = new System.Drawing.Point(210, 62);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(433, 24);
            this.customerAddressTextBox.TabIndex = 2;
            this.customerAddressTextBox.TextChanged += new System.EventHandler(this.CustomerAddresstxt_TextChanged);
            this.customerAddressTextBox.Leave += new System.EventHandler(this.CustomerAddresstxt_Leave);
            // 
            // customerNumberLabel
            // 
            this.customerNumberLabel.AutoSize = true;
            this.customerNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNumberLabel.Location = new System.Drawing.Point(86, 104);
            this.customerNumberLabel.Name = "customerNumberLabel";
            this.customerNumberLabel.Size = new System.Drawing.Size(106, 16);
            this.customerNumberLabel.TabIndex = 7;
            this.customerNumberLabel.Text = "Contact Number:";
            // 
            // businessNameTextBox
            // 
            this.businessNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessNameTextBox.Location = new System.Drawing.Point(210, 132);
            this.businessNameTextBox.Name = "businessNameTextBox";
            this.businessNameTextBox.Size = new System.Drawing.Size(433, 24);
            this.businessNameTextBox.TabIndex = 4;
            this.businessNameTextBox.TextChanged += new System.EventHandler(this.BusinessNametxt_TextChanged);
            this.businessNameTextBox.Leave += new System.EventHandler(this.BusinessNametxt_Leave);
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressLabel.Location = new System.Drawing.Point(73, 67);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(121, 16);
            this.customerAddressLabel.TabIndex = 6;
            this.customerAddressLabel.Text = "Customer Address:";
            // 
            // businessNatureTextBox
            // 
            this.businessNatureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessNatureTextBox.Location = new System.Drawing.Point(210, 167);
            this.businessNatureTextBox.Name = "businessNatureTextBox";
            this.businessNatureTextBox.Size = new System.Drawing.Size(433, 24);
            this.businessNatureTextBox.TabIndex = 5;
            this.businessNatureTextBox.TextChanged += new System.EventHandler(this.BusinessNaturetxt_TextChanged);
            this.businessNatureTextBox.Leave += new System.EventHandler(this.BusinessNaturetxt_Leave);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(88, 34);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(107, 16);
            this.customerNameLabel.TabIndex = 5;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // businessAverageGrossLabel
            // 
            this.businessAverageGrossLabel.AutoSize = true;
            this.businessAverageGrossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessAverageGrossLabel.Location = new System.Drawing.Point(27, 277);
            this.businessAverageGrossLabel.Name = "businessAverageGrossLabel";
            this.businessAverageGrossLabel.Size = new System.Drawing.Size(173, 16);
            this.businessAverageGrossLabel.TabIndex = 15;
            this.businessAverageGrossLabel.Text = "Average Daily Gross Sales:";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(586, 365);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(112, 45);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // EditCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.personalInfoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCustomerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Customer Information";
            this.personalInfoGroupBox.ResumeLayout(false);
            this.personalInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personalInfoGroupBox;
        private System.Windows.Forms.TextBox averageDailyGrossSalesTextBox;
        private System.Windows.Forms.Label businessCapitalLabel;
        private System.Windows.Forms.TextBox grossBusinessCapitalTextBox;
        private System.Windows.Forms.Label businessAddressLabel;
        private System.Windows.Forms.TextBox businessAddressTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label businessNatureLabel;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.Label businessNameLabel;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.Label customerNumberLabel;
        private System.Windows.Forms.TextBox businessNameTextBox;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.TextBox businessNatureTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label businessAverageGrossLabel;
        private System.Windows.Forms.Button submitButton;
    }
}