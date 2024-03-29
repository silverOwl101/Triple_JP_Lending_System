﻿
namespace TripleJP_Lending_System.Forms
{
    partial class MainApplicationFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApplicationFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionReportSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyCollectionReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savingAndSalarySummaryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSavingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerAccountToolStripMenuItem,
            this.loanInformationToolStripMenuItem,
            this.postingToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.otherOptionsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1395, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerAccountToolStripMenuItem
            // 
            this.customerAccountToolStripMenuItem.Name = "customerAccountToolStripMenuItem";
            this.customerAccountToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.customerAccountToolStripMenuItem.Text = "Customer Account";
            this.customerAccountToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // loanInformationToolStripMenuItem
            // 
            this.loanInformationToolStripMenuItem.Name = "loanInformationToolStripMenuItem";
            this.loanInformationToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.loanInformationToolStripMenuItem.Text = "Loan Information";
            this.loanInformationToolStripMenuItem.Click += new System.EventHandler(this.loanInformationToolStripMenuItem_Click);
            // 
            // postingToolStripMenuItem
            // 
            this.postingToolStripMenuItem.Name = "postingToolStripMenuItem";
            this.postingToolStripMenuItem.Size = new System.Drawing.Size(80, 30);
            this.postingToolStripMenuItem.Text = "Posting";
            this.postingToolStripMenuItem.Click += new System.EventHandler(this.postingToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectionReportSummaryToolStripMenuItem,
            this.dailyCollectionReportToolStripMenuItem,
            this.savingAndSalarySummaryReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(73, 30);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // collectionReportSummaryToolStripMenuItem
            // 
            this.collectionReportSummaryToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.collectionReportSummaryToolStripMenuItem.Name = "collectionReportSummaryToolStripMenuItem";
            this.collectionReportSummaryToolStripMenuItem.Size = new System.Drawing.Size(358, 30);
            this.collectionReportSummaryToolStripMenuItem.Text = "Collection Summary Report ";
            this.collectionReportSummaryToolStripMenuItem.Click += new System.EventHandler(this.collectionReportSummaryToolStripMenuItem_Click);
            // 
            // dailyCollectionReportToolStripMenuItem
            // 
            this.dailyCollectionReportToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.dailyCollectionReportToolStripMenuItem.Name = "dailyCollectionReportToolStripMenuItem";
            this.dailyCollectionReportToolStripMenuItem.Size = new System.Drawing.Size(358, 30);
            this.dailyCollectionReportToolStripMenuItem.Text = "Daily Collection Report";
            this.dailyCollectionReportToolStripMenuItem.Click += new System.EventHandler(this.dailyCollectionReportToolStripMenuItem_Click);
            // 
            // savingAndSalarySummaryReportToolStripMenuItem
            // 
            this.savingAndSalarySummaryReportToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.savingAndSalarySummaryReportToolStripMenuItem.Name = "savingAndSalarySummaryReportToolStripMenuItem";
            this.savingAndSalarySummaryReportToolStripMenuItem.Size = new System.Drawing.Size(358, 30);
            this.savingAndSalarySummaryReportToolStripMenuItem.Text = "Savings and Salary Summary Report";
            this.savingAndSalarySummaryReportToolStripMenuItem.Click += new System.EventHandler(this.savingAndSalarySummaryReportToolStripMenuItem_Click);
            // 
            // otherOptionsToolStripMenuItem
            // 
            this.otherOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.salaryToolStripMenuItem});
            this.otherOptionsToolStripMenuItem.Name = "otherOptionsToolStripMenuItem";
            this.otherOptionsToolStripMenuItem.Size = new System.Drawing.Size(129, 30);
            this.otherOptionsToolStripMenuItem.Text = "Other Options";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSavingsToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.addToolStripMenuItem.Text = "Savings";
            // 
            // addSavingsToolStripMenuItem
            // 
            this.addSavingsToolStripMenuItem.Name = "addSavingsToolStripMenuItem";
            this.addSavingsToolStripMenuItem.Size = new System.Drawing.Size(114, 30);
            this.addSavingsToolStripMenuItem.Text = "Add";
            this.addSavingsToolStripMenuItem.Click += new System.EventHandler(this.addSavingsToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.salaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSalaryToolStripMenuItem});
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.salaryToolStripMenuItem.Text = "Salary";
            // 
            // addSalaryToolStripMenuItem
            // 
            this.addSalaryToolStripMenuItem.Name = "addSalaryToolStripMenuItem";
            this.addSalaryToolStripMenuItem.Size = new System.Drawing.Size(114, 30);
            this.addSalaryToolStripMenuItem.Text = "Add";
            this.addSalaryToolStripMenuItem.Click += new System.EventHandler(this.addSalaryToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(83, 30);
            this.logoutToolStripMenuItem.Text = "Log-out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(735, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainApplicationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1395, 737);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainApplicationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triple JP Lending System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainApplicationFrm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectionReportSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSavingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyCollectionReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savingAndSalarySummaryReportToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}