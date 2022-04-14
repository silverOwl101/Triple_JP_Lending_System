
namespace TripleJP_Lending_System.Forms
{
    partial class CustomerAccountFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.SearchBoxtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.businessNameLabel = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.businessNatureLabel = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.businessAddressLabel = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.grossBusinessCapitalLabel = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.averageDailyGrossSalesLabel = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.businessInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.customerInfoGroupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.businessInfoGroupBox.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // customerInfoGroupBox
            // 
            this.customerInfoGroupBox.Controls.Add(this.groupBox5);
            this.customerInfoGroupBox.Controls.Add(this.groupBox4);
            this.customerInfoGroupBox.Controls.Add(this.groupBox3);
            this.customerInfoGroupBox.Controls.Add(this.groupBox2);
            this.customerInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfoGroupBox.Location = new System.Drawing.Point(12, 49);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(871, 171);
            this.customerInfoGroupBox.TabIndex = 12;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Text = "Customer Information ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.contactNumberLabel);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(435, 94);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(415, 57);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contact Number";
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.Location = new System.Drawing.Point(54, 25);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(45, 16);
            this.contactNumberLabel.TabIndex = 3;
            this.contactNumberLabel.Text = "contactNumberLabel";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.customerAddressLabel);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(14, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 57);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customer Address";
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Location = new System.Drawing.Point(60, 25);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(45, 16);
            this.customerAddressLabel.TabIndex = 2;
            this.customerAddressLabel.Text = "customerAddressLabel";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.customerNameLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(435, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 57);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Name";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(54, 23);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(45, 16);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "customerNameLabel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customerIdLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 57);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer ID";
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(60, 23);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(45, 16);
            this.customerIdLabel.TabIndex = 0;
            this.customerIdLabel.Text = "customerIdLabel";
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(763, 464);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(120, 50);
            this.editButton.TabIndex = 36;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(897, 52);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(54, 16);
            this.searchLabel.TabIndex = 16;
            this.searchLabel.Text = "Search:";
            // 
            // SearchBoxtxt
            // 
            this.SearchBoxtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBoxtxt.Location = new System.Drawing.Point(960, 49);
            this.SearchBoxtxt.Name = "SearchBoxtxt";
            this.SearchBoxtxt.Size = new System.Drawing.Size(330, 22);
            this.SearchBoxtxt.TabIndex = 15;
            this.SearchBoxtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBoxTxt_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(913, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(377, 493);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.businessNameLabel);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(14, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(415, 57);
            this.groupBox6.TabIndex = 41;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Business Name";
            // 
            // businessNameLabel
            // 
            this.businessNameLabel.AutoSize = true;
            this.businessNameLabel.Location = new System.Drawing.Point(60, 24);
            this.businessNameLabel.Name = "businessNameLabel";
            this.businessNameLabel.Size = new System.Drawing.Size(45, 16);
            this.businessNameLabel.TabIndex = 4;
            this.businessNameLabel.Text = "businessNameLabel";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.businessNatureLabel);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(435, 30);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(415, 57);
            this.groupBox7.TabIndex = 42;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Business Nature";
            // 
            // businessNatureLabel
            // 
            this.businessNatureLabel.AutoSize = true;
            this.businessNatureLabel.Location = new System.Drawing.Point(54, 24);
            this.businessNatureLabel.Name = "businessNatureLabel";
            this.businessNatureLabel.Size = new System.Drawing.Size(45, 16);
            this.businessNatureLabel.TabIndex = 5;
            this.businessNatureLabel.Text = "businessNatureLabel";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.businessAddressLabel);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(14, 93);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(415, 57);
            this.groupBox8.TabIndex = 43;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Business Address";
            // 
            // businessAddressLabel
            // 
            this.businessAddressLabel.AutoSize = true;
            this.businessAddressLabel.Location = new System.Drawing.Point(61, 23);
            this.businessAddressLabel.Name = "businessAddressLabel";
            this.businessAddressLabel.Size = new System.Drawing.Size(45, 16);
            this.businessAddressLabel.TabIndex = 6;
            this.businessAddressLabel.Text = "businessAddressLabel";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.grossBusinessCapitalLabel);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(435, 93);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(415, 57);
            this.groupBox9.TabIndex = 44;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Gross Business Capital";
            // 
            // grossBusinessCapitalLabel
            // 
            this.grossBusinessCapitalLabel.AutoSize = true;
            this.grossBusinessCapitalLabel.Location = new System.Drawing.Point(54, 23);
            this.grossBusinessCapitalLabel.Name = "grossBusinessCapitalLabel";
            this.grossBusinessCapitalLabel.Size = new System.Drawing.Size(45, 16);
            this.grossBusinessCapitalLabel.TabIndex = 7;
            this.grossBusinessCapitalLabel.Text = "grossBusinessCapitalLabel";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.averageDailyGrossSalesLabel);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(14, 156);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(415, 57);
            this.groupBox11.TabIndex = 46;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Average Daily Gross Sales";
            // 
            // averageDailyGrossSalesLabel
            // 
            this.averageDailyGrossSalesLabel.AutoSize = true;
            this.averageDailyGrossSalesLabel.Location = new System.Drawing.Point(61, 23);
            this.averageDailyGrossSalesLabel.Name = "averageDailyGrossSalesLabel";
            this.averageDailyGrossSalesLabel.Size = new System.Drawing.Size(45, 16);
            this.averageDailyGrossSalesLabel.TabIndex = 8;
            this.averageDailyGrossSalesLabel.Text = "averageDailyGrossSalesLabel";
            // 
            // groupBox12
            // 
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(14, 32);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(415, 57);
            this.groupBox12.TabIndex = 47;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Collector";
            // 
            // businessInfoGroupBox
            // 
            this.businessInfoGroupBox.Controls.Add(this.groupBox7);
            this.businessInfoGroupBox.Controls.Add(this.groupBox6);
            this.businessInfoGroupBox.Controls.Add(this.groupBox8);
            this.businessInfoGroupBox.Controls.Add(this.groupBox9);
            this.businessInfoGroupBox.Controls.Add(this.groupBox11);
            this.businessInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessInfoGroupBox.Location = new System.Drawing.Point(12, 226);
            this.businessInfoGroupBox.Name = "businessInfoGroupBox";
            this.businessInfoGroupBox.Size = new System.Drawing.Size(871, 232);
            this.businessInfoGroupBox.TabIndex = 41;
            this.businessInfoGroupBox.TabStop = false;
            this.businessInfoGroupBox.Text = "Business Information ";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.groupBox12);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(12, 464);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(443, 109);
            this.groupBox13.TabIndex = 44;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Collector Information ";
            // 
            // CustomerAccountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 592);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.businessInfoGroupBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.SearchBoxtxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.customerInfoGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustomerAccountFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Account";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.customerInfoGroupBox.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.businessInfoGroupBox.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.GroupBox customerInfoGroupBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox SearchBoxtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox businessInfoGroupBox;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label contactNumberLabel;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label businessNameLabel;
        private System.Windows.Forms.Label businessNatureLabel;
        private System.Windows.Forms.Label businessAddressLabel;
        private System.Windows.Forms.Label grossBusinessCapitalLabel;
        private System.Windows.Forms.Label averageDailyGrossSalesLabel;
    }
}