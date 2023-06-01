
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
            this.customerNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.customerAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.customerNameGroupBox = new System.Windows.Forms.GroupBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerIdGroupBox = new System.Windows.Forms.GroupBox();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBoxtxt = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.businessNameGroupBox = new System.Windows.Forms.GroupBox();
            this.businessNameLabel = new System.Windows.Forms.Label();
            this.businessNatureGroupBox = new System.Windows.Forms.GroupBox();
            this.businessNatureLabel = new System.Windows.Forms.Label();
            this.businessAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.businessAddressLabel = new System.Windows.Forms.Label();
            this.grossBusinessCapitalGroupBox = new System.Windows.Forms.GroupBox();
            this.grossBusinessCapitalLabel = new System.Windows.Forms.Label();
            this.averageGrossSalesGroupBox = new System.Windows.Forms.GroupBox();
            this.averageDailyGrossSalesLabel = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.businessInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.customerInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.customerInfoGroupBox.SuspendLayout();
            this.customerNumberGroupBox.SuspendLayout();
            this.customerAddressGroupBox.SuspendLayout();
            this.customerNameGroupBox.SuspendLayout();
            this.customerIdGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.businessNameGroupBox.SuspendLayout();
            this.businessNatureGroupBox.SuspendLayout();
            this.businessAddressGroupBox.SuspendLayout();
            this.grossBusinessCapitalGroupBox.SuspendLayout();
            this.averageGrossSalesGroupBox.SuspendLayout();
            this.businessInfoGroupBox.SuspendLayout();
            this.customerInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1312, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // customerInfoGroupBox
            // 
            this.customerInfoGroupBox.Controls.Add(this.customerNumberGroupBox);
            this.customerInfoGroupBox.Controls.Add(this.customerAddressGroupBox);
            this.customerInfoGroupBox.Controls.Add(this.customerNameGroupBox);
            this.customerInfoGroupBox.Controls.Add(this.customerIdGroupBox);
            this.customerInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfoGroupBox.Location = new System.Drawing.Point(12, 49);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(871, 171);
            this.customerInfoGroupBox.TabIndex = 12;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Text = "Customer Information ";
            // 
            // customerNumberGroupBox
            // 
            this.customerNumberGroupBox.Controls.Add(this.contactNumberLabel);
            this.customerNumberGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNumberGroupBox.Location = new System.Drawing.Point(435, 94);
            this.customerNumberGroupBox.Name = "customerNumberGroupBox";
            this.customerNumberGroupBox.Size = new System.Drawing.Size(415, 57);
            this.customerNumberGroupBox.TabIndex = 40;
            this.customerNumberGroupBox.TabStop = false;
            this.customerNumberGroupBox.Text = "Contact Number";
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.Location = new System.Drawing.Point(54, 25);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(139, 17);
            this.contactNumberLabel.TabIndex = 3;
            this.contactNumberLabel.Text = "contactNumberLabel";
            // 
            // customerAddressGroupBox
            // 
            this.customerAddressGroupBox.Controls.Add(this.customerAddressLabel);
            this.customerAddressGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressGroupBox.Location = new System.Drawing.Point(14, 94);
            this.customerAddressGroupBox.Name = "customerAddressGroupBox";
            this.customerAddressGroupBox.Size = new System.Drawing.Size(415, 57);
            this.customerAddressGroupBox.TabIndex = 39;
            this.customerAddressGroupBox.TabStop = false;
            this.customerAddressGroupBox.Text = "Customer Address";
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Location = new System.Drawing.Point(60, 25);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(153, 17);
            this.customerAddressLabel.TabIndex = 2;
            this.customerAddressLabel.Text = "customerAddressLabel";
            // 
            // customerNameGroupBox
            // 
            this.customerNameGroupBox.Controls.Add(this.customerNameLabel);
            this.customerNameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameGroupBox.Location = new System.Drawing.Point(435, 31);
            this.customerNameGroupBox.Name = "customerNameGroupBox";
            this.customerNameGroupBox.Size = new System.Drawing.Size(415, 57);
            this.customerNameGroupBox.TabIndex = 38;
            this.customerNameGroupBox.TabStop = false;
            this.customerNameGroupBox.Text = "Customer Name";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(54, 23);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(138, 17);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "customerNameLabel";
            // 
            // customerIdGroupBox
            // 
            this.customerIdGroupBox.Controls.Add(this.customerIdLabel);
            this.customerIdGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdGroupBox.Location = new System.Drawing.Point(14, 31);
            this.customerIdGroupBox.Name = "customerIdGroupBox";
            this.customerIdGroupBox.Size = new System.Drawing.Size(415, 57);
            this.customerIdGroupBox.TabIndex = 17;
            this.customerIdGroupBox.TabStop = false;
            this.customerIdGroupBox.Text = "Customer ID";
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(60, 23);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(112, 17);
            this.customerIdLabel.TabIndex = 0;
            this.customerIdLabel.Text = "customerIdLabel";
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(897, 52);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(57, 17);
            this.searchLabel.TabIndex = 16;
            this.searchLabel.Text = "Search:";
            // 
            // searchBoxtxt
            // 
            this.searchBoxtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxtxt.Location = new System.Drawing.Point(960, 49);
            this.searchBoxtxt.Name = "searchBoxtxt";
            this.searchBoxtxt.Size = new System.Drawing.Size(330, 23);
            this.searchBoxtxt.TabIndex = 15;
            this.searchBoxtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBoxTxt_KeyPress);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.customerDataGridView.Location = new System.Drawing.Point(913, 82);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersWidth = 50;
            this.customerDataGridView.Size = new System.Drawing.Size(377, 493);
            this.customerDataGridView.TabIndex = 14;
            this.customerDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseClick);
            // 
            // businessNameGroupBox
            // 
            this.businessNameGroupBox.Controls.Add(this.businessNameLabel);
            this.businessNameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessNameGroupBox.Location = new System.Drawing.Point(14, 30);
            this.businessNameGroupBox.Name = "businessNameGroupBox";
            this.businessNameGroupBox.Size = new System.Drawing.Size(415, 57);
            this.businessNameGroupBox.TabIndex = 41;
            this.businessNameGroupBox.TabStop = false;
            this.businessNameGroupBox.Text = "Business Name";
            // 
            // businessNameLabel
            // 
            this.businessNameLabel.AutoSize = true;
            this.businessNameLabel.Location = new System.Drawing.Point(60, 24);
            this.businessNameLabel.Name = "businessNameLabel";
            this.businessNameLabel.Size = new System.Drawing.Size(136, 17);
            this.businessNameLabel.TabIndex = 4;
            this.businessNameLabel.Text = "businessNameLabel";
            // 
            // businessNatureGroupBox
            // 
            this.businessNatureGroupBox.Controls.Add(this.businessNatureLabel);
            this.businessNatureGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessNatureGroupBox.Location = new System.Drawing.Point(435, 30);
            this.businessNatureGroupBox.Name = "businessNatureGroupBox";
            this.businessNatureGroupBox.Size = new System.Drawing.Size(415, 57);
            this.businessNatureGroupBox.TabIndex = 42;
            this.businessNatureGroupBox.TabStop = false;
            this.businessNatureGroupBox.Text = "Business Nature";
            // 
            // businessNatureLabel
            // 
            this.businessNatureLabel.AutoSize = true;
            this.businessNatureLabel.Location = new System.Drawing.Point(54, 24);
            this.businessNatureLabel.Name = "businessNatureLabel";
            this.businessNatureLabel.Size = new System.Drawing.Size(142, 17);
            this.businessNatureLabel.TabIndex = 5;
            this.businessNatureLabel.Text = "businessNatureLabel";
            // 
            // businessAddressGroupBox
            // 
            this.businessAddressGroupBox.Controls.Add(this.businessAddressLabel);
            this.businessAddressGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessAddressGroupBox.Location = new System.Drawing.Point(14, 93);
            this.businessAddressGroupBox.Name = "businessAddressGroupBox";
            this.businessAddressGroupBox.Size = new System.Drawing.Size(415, 57);
            this.businessAddressGroupBox.TabIndex = 43;
            this.businessAddressGroupBox.TabStop = false;
            this.businessAddressGroupBox.Text = "Business Address";
            // 
            // businessAddressLabel
            // 
            this.businessAddressLabel.AutoSize = true;
            this.businessAddressLabel.Location = new System.Drawing.Point(61, 23);
            this.businessAddressLabel.Name = "businessAddressLabel";
            this.businessAddressLabel.Size = new System.Drawing.Size(151, 17);
            this.businessAddressLabel.TabIndex = 6;
            this.businessAddressLabel.Text = "businessAddressLabel";
            // 
            // grossBusinessCapitalGroupBox
            // 
            this.grossBusinessCapitalGroupBox.Controls.Add(this.grossBusinessCapitalLabel);
            this.grossBusinessCapitalGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossBusinessCapitalGroupBox.Location = new System.Drawing.Point(435, 93);
            this.grossBusinessCapitalGroupBox.Name = "grossBusinessCapitalGroupBox";
            this.grossBusinessCapitalGroupBox.Size = new System.Drawing.Size(415, 57);
            this.grossBusinessCapitalGroupBox.TabIndex = 44;
            this.grossBusinessCapitalGroupBox.TabStop = false;
            this.grossBusinessCapitalGroupBox.Text = "Gross Business Capital";
            // 
            // grossBusinessCapitalLabel
            // 
            this.grossBusinessCapitalLabel.AutoSize = true;
            this.grossBusinessCapitalLabel.Location = new System.Drawing.Point(54, 23);
            this.grossBusinessCapitalLabel.Name = "grossBusinessCapitalLabel";
            this.grossBusinessCapitalLabel.Size = new System.Drawing.Size(178, 17);
            this.grossBusinessCapitalLabel.TabIndex = 7;
            this.grossBusinessCapitalLabel.Text = "grossBusinessCapitalLabel";
            // 
            // averageGrossSalesGroupBox
            // 
            this.averageGrossSalesGroupBox.Controls.Add(this.averageDailyGrossSalesLabel);
            this.averageGrossSalesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageGrossSalesGroupBox.Location = new System.Drawing.Point(14, 156);
            this.averageGrossSalesGroupBox.Name = "averageGrossSalesGroupBox";
            this.averageGrossSalesGroupBox.Size = new System.Drawing.Size(415, 57);
            this.averageGrossSalesGroupBox.TabIndex = 46;
            this.averageGrossSalesGroupBox.TabStop = false;
            this.averageGrossSalesGroupBox.Text = "Average Daily Gross Sales";
            // 
            // averageDailyGrossSalesLabel
            // 
            this.averageDailyGrossSalesLabel.AutoSize = true;
            this.averageDailyGrossSalesLabel.Location = new System.Drawing.Point(61, 23);
            this.averageDailyGrossSalesLabel.Name = "averageDailyGrossSalesLabel";
            this.averageDailyGrossSalesLabel.Size = new System.Drawing.Size(199, 17);
            this.averageDailyGrossSalesLabel.TabIndex = 8;
            this.averageDailyGrossSalesLabel.Text = "averageDailyGrossSalesLabel";
            // 
            // groupBox12
            // 
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(14, 32);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(415, 57);
            this.groupBox12.TabIndex = 47;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Collector";
            // 
            // businessInfoGroupBox
            // 
            this.businessInfoGroupBox.Controls.Add(this.businessNatureGroupBox);
            this.businessInfoGroupBox.Controls.Add(this.businessNameGroupBox);
            this.businessInfoGroupBox.Controls.Add(this.businessAddressGroupBox);
            this.businessInfoGroupBox.Controls.Add(this.grossBusinessCapitalGroupBox);
            this.businessInfoGroupBox.Controls.Add(this.averageGrossSalesGroupBox);
            this.businessInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessInfoGroupBox.Location = new System.Drawing.Point(12, 226);
            this.businessInfoGroupBox.Name = "businessInfoGroupBox";
            this.businessInfoGroupBox.Size = new System.Drawing.Size(871, 232);
            this.businessInfoGroupBox.TabIndex = 41;
            this.businessInfoGroupBox.TabStop = false;
            this.businessInfoGroupBox.Text = "Business Information ";
            // 
            // customerInformationGroupBox
            // 
            this.customerInformationGroupBox.Controls.Add(this.groupBox12);
            this.customerInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInformationGroupBox.Location = new System.Drawing.Point(12, 464);
            this.customerInformationGroupBox.Name = "customerInformationGroupBox";
            this.customerInformationGroupBox.Size = new System.Drawing.Size(443, 109);
            this.customerInformationGroupBox.TabIndex = 44;
            this.customerInformationGroupBox.TabStop = false;
            this.customerInformationGroupBox.Text = "Collector Information ";
            // 
            // CustomerAccountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 592);
            this.Controls.Add(this.customerInformationGroupBox);
            this.Controls.Add(this.businessInfoGroupBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBoxtxt);
            this.Controls.Add(this.customerDataGridView);
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
            this.customerNumberGroupBox.ResumeLayout(false);
            this.customerNumberGroupBox.PerformLayout();
            this.customerAddressGroupBox.ResumeLayout(false);
            this.customerAddressGroupBox.PerformLayout();
            this.customerNameGroupBox.ResumeLayout(false);
            this.customerNameGroupBox.PerformLayout();
            this.customerIdGroupBox.ResumeLayout(false);
            this.customerIdGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.businessNameGroupBox.ResumeLayout(false);
            this.businessNameGroupBox.PerformLayout();
            this.businessNatureGroupBox.ResumeLayout(false);
            this.businessNatureGroupBox.PerformLayout();
            this.businessAddressGroupBox.ResumeLayout(false);
            this.businessAddressGroupBox.PerformLayout();
            this.grossBusinessCapitalGroupBox.ResumeLayout(false);
            this.grossBusinessCapitalGroupBox.PerformLayout();
            this.averageGrossSalesGroupBox.ResumeLayout(false);
            this.averageGrossSalesGroupBox.PerformLayout();
            this.businessInfoGroupBox.ResumeLayout(false);
            this.customerInformationGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.GroupBox customerInfoGroupBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBoxtxt;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox businessAddressGroupBox;
        private System.Windows.Forms.GroupBox businessNatureGroupBox;
        private System.Windows.Forms.GroupBox averageGrossSalesGroupBox;
        private System.Windows.Forms.GroupBox businessNameGroupBox;
        private System.Windows.Forms.GroupBox customerNumberGroupBox;
        private System.Windows.Forms.GroupBox customerAddressGroupBox;
        private System.Windows.Forms.GroupBox customerNameGroupBox;
        private System.Windows.Forms.GroupBox grossBusinessCapitalGroupBox;
        private System.Windows.Forms.GroupBox customerIdGroupBox;
        private System.Windows.Forms.GroupBox businessInfoGroupBox;
        private System.Windows.Forms.GroupBox customerInformationGroupBox;
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