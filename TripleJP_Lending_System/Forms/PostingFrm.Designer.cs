
namespace TripleJP_Lending_System.Forms
{
    partial class PostingFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButtton = new System.Windows.Forms.Button();
            this.nameOrIdGroupBox = new System.Windows.Forms.GroupBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.loanDataGridView = new System.Windows.Forms.DataGridView();
            this.searchFilterGroupBox.SuspendLayout();
            this.nameOrIdGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchFilterGroupBox
            // 
            this.searchFilterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchFilterGroupBox.Controls.Add(this.searchButtton);
            this.searchFilterGroupBox.Controls.Add(this.nameOrIdGroupBox);
            this.searchFilterGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFilterGroupBox.Location = new System.Drawing.Point(16, 15);
            this.searchFilterGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchFilterGroupBox.Name = "searchFilterGroupBox";
            this.searchFilterGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchFilterGroupBox.Size = new System.Drawing.Size(1091, 142);
            this.searchFilterGroupBox.TabIndex = 0;
            this.searchFilterGroupBox.TabStop = false;
            this.searchFilterGroupBox.Text = "Search Filter";
            // 
            // searchButtton
            // 
            this.searchButtton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButtton.Location = new System.Drawing.Point(969, 71);
            this.searchButtton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButtton.Name = "searchButtton";
            this.searchButtton.Size = new System.Drawing.Size(113, 36);
            this.searchButtton.TabIndex = 2;
            this.searchButtton.Tag = "";
            this.searchButtton.Text = "Search";
            this.searchButtton.UseVisualStyleBackColor = true;
            this.searchButtton.Click += new System.EventHandler(this.PostingSubmitButton_Click);
            // 
            // nameOrIdGroupBox
            // 
            this.nameOrIdGroupBox.Controls.Add(this.searchTextBox);
            this.nameOrIdGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOrIdGroupBox.Location = new System.Drawing.Point(8, 46);
            this.nameOrIdGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameOrIdGroupBox.Name = "nameOrIdGroupBox";
            this.nameOrIdGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameOrIdGroupBox.Size = new System.Drawing.Size(953, 76);
            this.nameOrIdGroupBox.TabIndex = 2;
            this.nameOrIdGroupBox.TabStop = false;
            this.nameOrIdGroupBox.Text = "Name or Customer ID #";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(8, 28);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(936, 33);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Tag = "";
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PostingSearchTxt_KeyPress);
            // 
            // loanDataGridView
            // 
            this.loanDataGridView.AllowUserToAddRows = false;
            this.loanDataGridView.AllowUserToDeleteRows = false;
            this.loanDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loanDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.loanDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.loanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.loanDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.loanDataGridView.Location = new System.Drawing.Point(16, 164);
            this.loanDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loanDataGridView.Name = "loanDataGridView";
            this.loanDataGridView.ReadOnly = true;
            this.loanDataGridView.RowHeadersWidth = 51;
            this.loanDataGridView.Size = new System.Drawing.Size(1091, 417);
            this.loanDataGridView.TabIndex = 3;
            this.loanDataGridView.TabStop = false;
            this.loanDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoanDataGridView_CellDoubleClick);
            // 
            // PostingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 596);
            this.Controls.Add(this.loanDataGridView);
            this.Controls.Add(this.searchFilterGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostingFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posting";
            this.Shown += new System.EventHandler(this.PostingFrm_Shown);
            this.searchFilterGroupBox.ResumeLayout(false);
            this.nameOrIdGroupBox.ResumeLayout(false);
            this.nameOrIdGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchFilterGroupBox;
        private System.Windows.Forms.GroupBox nameOrIdGroupBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView loanDataGridView;
        private System.Windows.Forms.Button searchButtton;
    }
}