
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
            this.searchFilterGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFilterGroupBox.Location = new System.Drawing.Point(12, 12);
            this.searchFilterGroupBox.Name = "searchFilterGroupBox";
            this.searchFilterGroupBox.Size = new System.Drawing.Size(818, 115);
            this.searchFilterGroupBox.TabIndex = 0;
            this.searchFilterGroupBox.TabStop = false;
            this.searchFilterGroupBox.Text = "Search Filter";
            // 
            // searchButtton
            // 
            this.searchButtton.Location = new System.Drawing.Point(727, 58);
            this.searchButtton.Name = "searchButtton";
            this.searchButtton.Size = new System.Drawing.Size(85, 29);
            this.searchButtton.TabIndex = 2;
            this.searchButtton.Tag = "";
            this.searchButtton.Text = "Search";
            this.searchButtton.UseVisualStyleBackColor = true;
            this.searchButtton.Click += new System.EventHandler(this.PostingSubmitButton_Click);
            // 
            // nameOrIdGroupBox
            // 
            this.nameOrIdGroupBox.Controls.Add(this.searchTextBox);
            this.nameOrIdGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOrIdGroupBox.Location = new System.Drawing.Point(6, 37);
            this.nameOrIdGroupBox.Name = "nameOrIdGroupBox";
            this.nameOrIdGroupBox.Size = new System.Drawing.Size(715, 62);
            this.nameOrIdGroupBox.TabIndex = 2;
            this.nameOrIdGroupBox.TabStop = false;
            this.nameOrIdGroupBox.Text = "Name or Customer ID #";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(6, 23);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(703, 21);
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
            this.loanDataGridView.Location = new System.Drawing.Point(12, 133);
            this.loanDataGridView.Name = "loanDataGridView";
            this.loanDataGridView.ReadOnly = true;
            this.loanDataGridView.RowHeadersWidth = 51;
            this.loanDataGridView.Size = new System.Drawing.Size(818, 339);
            this.loanDataGridView.TabIndex = 3;
            this.loanDataGridView.TabStop = false;
            this.loanDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoanDataGridView_CellDoubleClick);
            // 
            // PostingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 484);
            this.Controls.Add(this.loanDataGridView);
            this.Controls.Add(this.searchFilterGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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