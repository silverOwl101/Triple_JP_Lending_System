namespace TripleJP_Lending_System.Forms
{
    partial class ReportViewerSummaryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewerSummaryFrm));
            this.generateReportButton = new System.Windows.Forms.Button();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.statusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateReportButton
            // 
            this.generateReportButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportButton.Location = new System.Drawing.Point(286, 33);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(133, 56);
            this.generateReportButton.TabIndex = 29;
            this.generateReportButton.Text = "Generate";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.comboBoxStatus);
            this.statusGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusGroupBox.Location = new System.Drawing.Point(12, 22);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(268, 67);
            this.statusGroupBox.TabIndex = 28;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Select Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Fully Paid",
            "Unpaid and Bad debt"});
            this.comboBoxStatus.Location = new System.Drawing.Point(6, 25);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(256, 30);
            this.comboBoxStatus.TabIndex = 19;
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer.DocumentMapWidth = 42;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "TripleJP_Lending_System.ReportDefinitions.Customer_Account_Details.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(12, 95);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1136, 391);
            this.reportViewer.TabIndex = 27;
            // 
            // ReportViewerSummaryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1160, 498);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.reportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportViewerSummaryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportViewerSummaryFrm";
            this.Load += new System.EventHandler(this.ReportViewerSummaryFrm_Load);
            this.statusGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}