
namespace TripleJP_Lending_System.Forms
{
    partial class LoanInformationFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.loanInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.totalPenaltyGroupBox = new System.Windows.Forms.GroupBox();
            this.penaltyLabel = new System.Windows.Forms.Label();
            this.principalLoanGroupBox = new System.Windows.Forms.GroupBox();
            this.principalLoanLabel = new System.Windows.Forms.Label();
            this.interestGroupBox = new System.Windows.Forms.GroupBox();
            this.interestLabel = new System.Windows.Forms.Label();
            this.effectiveDateGroupBox = new System.Windows.Forms.GroupBox();
            this.effectiveDateLabel = new System.Windows.Forms.Label();
            this.durationGroupBox = new System.Windows.Forms.GroupBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.paymentTermGroupBox = new System.Windows.Forms.GroupBox();
            this.paymentTermLabel = new System.Windows.Forms.Label();
            this.customerIdGroupBox = new System.Windows.Forms.GroupBox();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.customerNameGroupBox = new System.Windows.Forms.GroupBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.loanIdGroupBox = new System.Windows.Forms.GroupBox();
            this.loanIdLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanMaturityInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.totalLoanAmountGroupBox = new System.Windows.Forms.GroupBox();
            this.totalLoanPenaltyLabel = new System.Windows.Forms.Label();
            this.totalBalanceGroupBox = new System.Windows.Forms.GroupBox();
            this.totalBalanceLabel = new System.Windows.Forms.Label();
            this.totalCollectedAmountGroupBox = new System.Windows.Forms.GroupBox();
            this.totalAmountRemittanceLabel = new System.Windows.Forms.Label();
            this.perRemittanceGroupBox = new System.Windows.Forms.GroupBox();
            this.perRemittanceLabel = new System.Windows.Forms.Label();
            this.maturityValueGroupBox = new System.Windows.Forms.GroupBox();
            this.maturityValueLabel = new System.Windows.Forms.Label();
            this.maturityDateGroupBox = new System.Windows.Forms.GroupBox();
            this.maturityDateLabel = new System.Windows.Forms.Label();
            this.maturityInterestGroupBox = new System.Windows.Forms.GroupBox();
            this.maturityInterestLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.loanDataGridView = new System.Windows.Forms.DataGridView();
            this.searchFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.badDebtCheckBox = new System.Windows.Forms.CheckBox();
            this.fullyPaidCheckBox = new System.Windows.Forms.CheckBox();
            this.unPaidCheckBox = new System.Windows.Forms.CheckBox();
            this.generateAccountStatementButton = new System.Windows.Forms.Button();
            this.loanInformationGroupBox.SuspendLayout();
            this.statusGroupBox.SuspendLayout();
            this.totalPenaltyGroupBox.SuspendLayout();
            this.principalLoanGroupBox.SuspendLayout();
            this.interestGroupBox.SuspendLayout();
            this.effectiveDateGroupBox.SuspendLayout();
            this.durationGroupBox.SuspendLayout();
            this.paymentTermGroupBox.SuspendLayout();
            this.customerIdGroupBox.SuspendLayout();
            this.customerNameGroupBox.SuspendLayout();
            this.loanIdGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.loanMaturityInformationGroupBox.SuspendLayout();
            this.totalLoanAmountGroupBox.SuspendLayout();
            this.totalBalanceGroupBox.SuspendLayout();
            this.totalCollectedAmountGroupBox.SuspendLayout();
            this.perRemittanceGroupBox.SuspendLayout();
            this.maturityValueGroupBox.SuspendLayout();
            this.maturityDateGroupBox.SuspendLayout();
            this.maturityInterestGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanDataGridView)).BeginInit();
            this.searchFilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loanInformationGroupBox
            // 
            this.loanInformationGroupBox.Controls.Add(this.statusGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.totalPenaltyGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.principalLoanGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.interestGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.effectiveDateGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.durationGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.paymentTermGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.customerIdGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.customerNameGroupBox);
            this.loanInformationGroupBox.Controls.Add(this.loanIdGroupBox);
            this.loanInformationGroupBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanInformationGroupBox.Location = new System.Drawing.Point(13, 34);
            this.loanInformationGroupBox.Name = "loanInformationGroupBox";
            this.loanInformationGroupBox.Size = new System.Drawing.Size(926, 350);
            this.loanInformationGroupBox.TabIndex = 13;
            this.loanInformationGroupBox.TabStop = false;
            this.loanInformationGroupBox.Text = "Loan Information";
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.statusLabel);
            this.statusGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusGroupBox.Location = new System.Drawing.Point(464, 278);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(442, 56);
            this.statusGroupBox.TabIndex = 20;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Status";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(64, 22);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(74, 25);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "statusTxt";
            // 
            // totalPenaltyGroupBox
            // 
            this.totalPenaltyGroupBox.Controls.Add(this.penaltyLabel);
            this.totalPenaltyGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPenaltyGroupBox.Location = new System.Drawing.Point(15, 278);
            this.totalPenaltyGroupBox.Name = "totalPenaltyGroupBox";
            this.totalPenaltyGroupBox.Size = new System.Drawing.Size(442, 56);
            this.totalPenaltyGroupBox.TabIndex = 20;
            this.totalPenaltyGroupBox.TabStop = false;
            this.totalPenaltyGroupBox.Text = "Total Penalty";
            // 
            // penaltyLabel
            // 
            this.penaltyLabel.AutoSize = true;
            this.penaltyLabel.Location = new System.Drawing.Point(64, 22);
            this.penaltyLabel.Name = "penaltyLabel";
            this.penaltyLabel.Size = new System.Drawing.Size(64, 25);
            this.penaltyLabel.TabIndex = 0;
            this.penaltyLabel.Text = "penalty";
            // 
            // principalLoanGroupBox
            // 
            this.principalLoanGroupBox.Controls.Add(this.principalLoanLabel);
            this.principalLoanGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalLoanGroupBox.Location = new System.Drawing.Point(464, 216);
            this.principalLoanGroupBox.Name = "principalLoanGroupBox";
            this.principalLoanGroupBox.Size = new System.Drawing.Size(442, 56);
            this.principalLoanGroupBox.TabIndex = 19;
            this.principalLoanGroupBox.TabStop = false;
            this.principalLoanGroupBox.Text = "Principal Loan";
            // 
            // principalLoanLabel
            // 
            this.principalLoanLabel.AutoSize = true;
            this.principalLoanLabel.Location = new System.Drawing.Point(64, 22);
            this.principalLoanLabel.Name = "principalLoanLabel";
            this.principalLoanLabel.Size = new System.Drawing.Size(194, 25);
            this.principalLoanLabel.TabIndex = 0;
            this.principalLoanLabel.Text = "grossBusinessCapitalLabel";
            // 
            // interestGroupBox
            // 
            this.interestGroupBox.Controls.Add(this.interestLabel);
            this.interestGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestGroupBox.Location = new System.Drawing.Point(15, 216);
            this.interestGroupBox.Name = "interestGroupBox";
            this.interestGroupBox.Size = new System.Drawing.Size(442, 56);
            this.interestGroupBox.TabIndex = 19;
            this.interestGroupBox.TabStop = false;
            this.interestGroupBox.Text = "Interest";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(64, 22);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(84, 25);
            this.interestLabel.TabIndex = 0;
            this.interestLabel.Text = "interestTxt";
            // 
            // effectiveDateGroupBox
            // 
            this.effectiveDateGroupBox.Controls.Add(this.effectiveDateLabel);
            this.effectiveDateGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectiveDateGroupBox.Location = new System.Drawing.Point(464, 154);
            this.effectiveDateGroupBox.Name = "effectiveDateGroupBox";
            this.effectiveDateGroupBox.Size = new System.Drawing.Size(442, 56);
            this.effectiveDateGroupBox.TabIndex = 19;
            this.effectiveDateGroupBox.TabStop = false;
            this.effectiveDateGroupBox.Text = "Effective Date";
            // 
            // effectiveDateLabel
            // 
            this.effectiveDateLabel.AutoSize = true;
            this.effectiveDateLabel.Location = new System.Drawing.Point(64, 22);
            this.effectiveDateLabel.Name = "effectiveDateLabel";
            this.effectiveDateLabel.Size = new System.Drawing.Size(155, 25);
            this.effectiveDateLabel.TabIndex = 0;
            this.effectiveDateLabel.Text = "businessNatureLabel";
            // 
            // durationGroupBox
            // 
            this.durationGroupBox.Controls.Add(this.durationLabel);
            this.durationGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationGroupBox.Location = new System.Drawing.Point(15, 154);
            this.durationGroupBox.Name = "durationGroupBox";
            this.durationGroupBox.Size = new System.Drawing.Size(442, 56);
            this.durationGroupBox.TabIndex = 19;
            this.durationGroupBox.TabStop = false;
            this.durationGroupBox.Text = "Duration";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(64, 22);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(150, 25);
            this.durationLabel.TabIndex = 0;
            this.durationLabel.Text = "businessNameLabel";
            // 
            // paymentTermGroupBox
            // 
            this.paymentTermGroupBox.Controls.Add(this.paymentTermLabel);
            this.paymentTermGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTermGroupBox.Location = new System.Drawing.Point(464, 91);
            this.paymentTermGroupBox.Name = "paymentTermGroupBox";
            this.paymentTermGroupBox.Size = new System.Drawing.Size(442, 56);
            this.paymentTermGroupBox.TabIndex = 19;
            this.paymentTermGroupBox.TabStop = false;
            this.paymentTermGroupBox.Text = "Payment Term";
            // 
            // paymentTermLabel
            // 
            this.paymentTermLabel.AutoSize = true;
            this.paymentTermLabel.Location = new System.Drawing.Point(64, 22);
            this.paymentTermLabel.Name = "paymentTermLabel";
            this.paymentTermLabel.Size = new System.Drawing.Size(159, 25);
            this.paymentTermLabel.TabIndex = 0;
            this.paymentTermLabel.Text = "contactNumberLabel";
            // 
            // customerIdGroupBox
            // 
            this.customerIdGroupBox.Controls.Add(this.customerIdLabel);
            this.customerIdGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdGroupBox.Location = new System.Drawing.Point(464, 30);
            this.customerIdGroupBox.Name = "customerIdGroupBox";
            this.customerIdGroupBox.Size = new System.Drawing.Size(442, 56);
            this.customerIdGroupBox.TabIndex = 19;
            this.customerIdGroupBox.TabStop = false;
            this.customerIdGroupBox.Text = "Customer ID";
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(64, 22);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(157, 25);
            this.customerIdLabel.TabIndex = 0;
            this.customerIdLabel.Text = "customerNameLabel";
            // 
            // customerNameGroupBox
            // 
            this.customerNameGroupBox.Controls.Add(this.customerNameLabel);
            this.customerNameGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameGroupBox.Location = new System.Drawing.Point(15, 91);
            this.customerNameGroupBox.Name = "customerNameGroupBox";
            this.customerNameGroupBox.Size = new System.Drawing.Size(442, 56);
            this.customerNameGroupBox.TabIndex = 18;
            this.customerNameGroupBox.TabStop = false;
            this.customerNameGroupBox.Text = "Customer Name";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(64, 22);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(170, 25);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "customerAddressLabel";
            // 
            // loanIdGroupBox
            // 
            this.loanIdGroupBox.Controls.Add(this.loanIdLabel);
            this.loanIdGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanIdGroupBox.Location = new System.Drawing.Point(15, 30);
            this.loanIdGroupBox.Name = "loanIdGroupBox";
            this.loanIdGroupBox.Size = new System.Drawing.Size(442, 56);
            this.loanIdGroupBox.TabIndex = 17;
            this.loanIdGroupBox.TabStop = false;
            this.loanIdGroupBox.Text = "Loan ID";
            // 
            // loanIdLabel
            // 
            this.loanIdLabel.AutoSize = true;
            this.loanIdLabel.Location = new System.Drawing.Point(64, 22);
            this.loanIdLabel.Name = "loanIdLabel";
            this.loanIdLabel.Size = new System.Drawing.Size(127, 25);
            this.loanIdLabel.TabIndex = 0;
            this.loanIdLabel.Text = "customerIdLabel";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1385, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // loanMaturityInformationGroupBox
            // 
            this.loanMaturityInformationGroupBox.Controls.Add(this.totalLoanAmountGroupBox);
            this.loanMaturityInformationGroupBox.Controls.Add(this.totalBalanceGroupBox);
            this.loanMaturityInformationGroupBox.Controls.Add(this.totalCollectedAmountGroupBox);
            this.loanMaturityInformationGroupBox.Controls.Add(this.perRemittanceGroupBox);
            this.loanMaturityInformationGroupBox.Controls.Add(this.maturityValueGroupBox);
            this.loanMaturityInformationGroupBox.Controls.Add(this.maturityDateGroupBox);
            this.loanMaturityInformationGroupBox.Controls.Add(this.maturityInterestGroupBox);
            this.loanMaturityInformationGroupBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanMaturityInformationGroupBox.Location = new System.Drawing.Point(13, 390);
            this.loanMaturityInformationGroupBox.Name = "loanMaturityInformationGroupBox";
            this.loanMaturityInformationGroupBox.Size = new System.Drawing.Size(926, 286);
            this.loanMaturityInformationGroupBox.TabIndex = 21;
            this.loanMaturityInformationGroupBox.TabStop = false;
            this.loanMaturityInformationGroupBox.Text = "Loan Maturity Information";
            // 
            // totalLoanAmountGroupBox
            // 
            this.totalLoanAmountGroupBox.Controls.Add(this.totalLoanPenaltyLabel);
            this.totalLoanAmountGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLoanAmountGroupBox.Location = new System.Drawing.Point(463, 91);
            this.totalLoanAmountGroupBox.Name = "totalLoanAmountGroupBox";
            this.totalLoanAmountGroupBox.Size = new System.Drawing.Size(442, 56);
            this.totalLoanAmountGroupBox.TabIndex = 19;
            this.totalLoanAmountGroupBox.TabStop = false;
            this.totalLoanAmountGroupBox.Text = "Total Loan Amount (Penalty Added)";
            // 
            // totalLoanPenaltyLabel
            // 
            this.totalLoanPenaltyLabel.AutoSize = true;
            this.totalLoanPenaltyLabel.Location = new System.Drawing.Point(64, 22);
            this.totalLoanPenaltyLabel.Name = "totalLoanPenaltyLabel";
            this.totalLoanPenaltyLabel.Size = new System.Drawing.Size(172, 25);
            this.totalLoanPenaltyLabel.TabIndex = 0;
            this.totalLoanPenaltyLabel.Text = "totalLoanPenaltyAdded";
            // 
            // totalBalanceGroupBox
            // 
            this.totalBalanceGroupBox.Controls.Add(this.totalBalanceLabel);
            this.totalBalanceGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBalanceGroupBox.Location = new System.Drawing.Point(464, 219);
            this.totalBalanceGroupBox.Name = "totalBalanceGroupBox";
            this.totalBalanceGroupBox.Size = new System.Drawing.Size(442, 56);
            this.totalBalanceGroupBox.TabIndex = 21;
            this.totalBalanceGroupBox.TabStop = false;
            this.totalBalanceGroupBox.Text = "Total Balance";
            // 
            // totalBalanceLabel
            // 
            this.totalBalanceLabel.AutoSize = true;
            this.totalBalanceLabel.Location = new System.Drawing.Point(64, 22);
            this.totalBalanceLabel.Name = "totalBalanceLabel";
            this.totalBalanceLabel.Size = new System.Drawing.Size(120, 25);
            this.totalBalanceLabel.TabIndex = 0;
            this.totalBalanceLabel.Text = "totalBalanceTxt";
            // 
            // totalCollectedAmountGroupBox
            // 
            this.totalCollectedAmountGroupBox.Controls.Add(this.totalAmountRemittanceLabel);
            this.totalCollectedAmountGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCollectedAmountGroupBox.Location = new System.Drawing.Point(464, 154);
            this.totalCollectedAmountGroupBox.Name = "totalCollectedAmountGroupBox";
            this.totalCollectedAmountGroupBox.Size = new System.Drawing.Size(442, 56);
            this.totalCollectedAmountGroupBox.TabIndex = 20;
            this.totalCollectedAmountGroupBox.TabStop = false;
            this.totalCollectedAmountGroupBox.Text = "Total CollectedAmount Remittance";
            // 
            // totalAmountRemittanceLabel
            // 
            this.totalAmountRemittanceLabel.AutoSize = true;
            this.totalAmountRemittanceLabel.Location = new System.Drawing.Point(64, 22);
            this.totalAmountRemittanceLabel.Name = "totalAmountRemittanceLabel";
            this.totalAmountRemittanceLabel.Size = new System.Drawing.Size(199, 25);
            this.totalAmountRemittanceLabel.TabIndex = 0;
            this.totalAmountRemittanceLabel.Text = "totalAmountRemittanceTxt";
            // 
            // perRemittanceGroupBox
            // 
            this.perRemittanceGroupBox.Controls.Add(this.perRemittanceLabel);
            this.perRemittanceGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perRemittanceGroupBox.Location = new System.Drawing.Point(15, 154);
            this.perRemittanceGroupBox.Name = "perRemittanceGroupBox";
            this.perRemittanceGroupBox.Size = new System.Drawing.Size(442, 56);
            this.perRemittanceGroupBox.TabIndex = 19;
            this.perRemittanceGroupBox.TabStop = false;
            this.perRemittanceGroupBox.Text = "Per Remittance";
            // 
            // perRemittanceLabel
            // 
            this.perRemittanceLabel.AutoSize = true;
            this.perRemittanceLabel.Location = new System.Drawing.Point(64, 22);
            this.perRemittanceLabel.Name = "perRemittanceLabel";
            this.perRemittanceLabel.Size = new System.Drawing.Size(136, 25);
            this.perRemittanceLabel.TabIndex = 0;
            this.perRemittanceLabel.Text = "perRemittanceTxt";
            // 
            // maturityValueGroupBox
            // 
            this.maturityValueGroupBox.Controls.Add(this.maturityValueLabel);
            this.maturityValueGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maturityValueGroupBox.Location = new System.Drawing.Point(464, 30);
            this.maturityValueGroupBox.Name = "maturityValueGroupBox";
            this.maturityValueGroupBox.Size = new System.Drawing.Size(442, 56);
            this.maturityValueGroupBox.TabIndex = 19;
            this.maturityValueGroupBox.TabStop = false;
            this.maturityValueGroupBox.Text = "Maturity Value";
            // 
            // maturityValueLabel
            // 
            this.maturityValueLabel.AutoSize = true;
            this.maturityValueLabel.Location = new System.Drawing.Point(64, 22);
            this.maturityValueLabel.Name = "maturityValueLabel";
            this.maturityValueLabel.Size = new System.Drawing.Size(129, 25);
            this.maturityValueLabel.TabIndex = 0;
            this.maturityValueLabel.Text = "maturityValueTxt";
            // 
            // maturityDateGroupBox
            // 
            this.maturityDateGroupBox.Controls.Add(this.maturityDateLabel);
            this.maturityDateGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maturityDateGroupBox.Location = new System.Drawing.Point(15, 91);
            this.maturityDateGroupBox.Name = "maturityDateGroupBox";
            this.maturityDateGroupBox.Size = new System.Drawing.Size(442, 56);
            this.maturityDateGroupBox.TabIndex = 18;
            this.maturityDateGroupBox.TabStop = false;
            this.maturityDateGroupBox.Text = "Maturity Date";
            // 
            // maturityDateLabel
            // 
            this.maturityDateLabel.AutoSize = true;
            this.maturityDateLabel.Location = new System.Drawing.Point(64, 22);
            this.maturityDateLabel.Name = "maturityDateLabel";
            this.maturityDateLabel.Size = new System.Drawing.Size(123, 25);
            this.maturityDateLabel.TabIndex = 0;
            this.maturityDateLabel.Text = "maturityDateTxt";
            // 
            // maturityInterestGroupBox
            // 
            this.maturityInterestGroupBox.Controls.Add(this.maturityInterestLabel);
            this.maturityInterestGroupBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maturityInterestGroupBox.Location = new System.Drawing.Point(15, 30);
            this.maturityInterestGroupBox.Name = "maturityInterestGroupBox";
            this.maturityInterestGroupBox.Size = new System.Drawing.Size(442, 56);
            this.maturityInterestGroupBox.TabIndex = 17;
            this.maturityInterestGroupBox.TabStop = false;
            this.maturityInterestGroupBox.Text = "Maturity Interest";
            // 
            // maturityInterestLabel
            // 
            this.maturityInterestLabel.AutoSize = true;
            this.maturityInterestLabel.Location = new System.Drawing.Point(64, 22);
            this.maturityInterestLabel.Name = "maturityInterestLabel";
            this.maturityInterestLabel.Size = new System.Drawing.Size(142, 25);
            this.maturityInterestLabel.TabIndex = 0;
            this.maturityInterestLabel.Text = "maturityInterestTxt";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(951, 45);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(64, 25);
            this.searchLabel.TabIndex = 24;
            this.searchLabel.Text = "Search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(1015, 42);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(352, 28);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBoxTxt_KeyPress);
            // 
            // loanDataGridView
            // 
            this.loanDataGridView.AllowUserToAddRows = false;
            this.loanDataGridView.AllowUserToDeleteRows = false;
            this.loanDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.loanDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.loanDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loanDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.loanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.loanDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.loanDataGridView.Location = new System.Drawing.Point(966, 75);
            this.loanDataGridView.Name = "loanDataGridView";
            this.loanDataGridView.ReadOnly = true;
            this.loanDataGridView.RowHeadersWidth = 50;
            this.loanDataGridView.Size = new System.Drawing.Size(402, 418);
            this.loanDataGridView.TabIndex = 2;
            this.loanDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            this.loanDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseClick);
            this.loanDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.loanDataGridView_RowPrePaint);
            this.loanDataGridView.Enter += new System.EventHandler(this.DataGridView1_Enter);
            // 
            // searchFilterGroupBox
            // 
            this.searchFilterGroupBox.Controls.Add(this.badDebtCheckBox);
            this.searchFilterGroupBox.Controls.Add(this.fullyPaidCheckBox);
            this.searchFilterGroupBox.Controls.Add(this.unPaidCheckBox);
            this.searchFilterGroupBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFilterGroupBox.Location = new System.Drawing.Point(966, 498);
            this.searchFilterGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchFilterGroupBox.Name = "searchFilterGroupBox";
            this.searchFilterGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.searchFilterGroupBox.Size = new System.Drawing.Size(402, 63);
            this.searchFilterGroupBox.TabIndex = 3;
            this.searchFilterGroupBox.TabStop = false;
            this.searchFilterGroupBox.Text = "Search Filter";
            // 
            // badDebtCheckBox
            // 
            this.badDebtCheckBox.AutoSize = true;
            this.badDebtCheckBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badDebtCheckBox.Location = new System.Drawing.Point(268, 25);
            this.badDebtCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.badDebtCheckBox.Name = "badDebtCheckBox";
            this.badDebtCheckBox.Size = new System.Drawing.Size(95, 29);
            this.badDebtCheckBox.TabIndex = 5;
            this.badDebtCheckBox.Text = "Bad Debt";
            this.badDebtCheckBox.UseVisualStyleBackColor = true;
            this.badDebtCheckBox.CheckedChanged += new System.EventHandler(this.BadDebtCheckBox_CheckedChanged);
            // 
            // fullyPaidCheckBox
            // 
            this.fullyPaidCheckBox.AutoSize = true;
            this.fullyPaidCheckBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullyPaidCheckBox.Location = new System.Drawing.Point(161, 25);
            this.fullyPaidCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.fullyPaidCheckBox.Name = "fullyPaidCheckBox";
            this.fullyPaidCheckBox.Size = new System.Drawing.Size(94, 29);
            this.fullyPaidCheckBox.TabIndex = 4;
            this.fullyPaidCheckBox.Text = "Fully Paid";
            this.fullyPaidCheckBox.UseVisualStyleBackColor = true;
            this.fullyPaidCheckBox.CheckedChanged += new System.EventHandler(this.FullyPaidCheckBox_CheckedChanged);
            // 
            // unPaidCheckBox
            // 
            this.unPaidCheckBox.AutoSize = true;
            this.unPaidCheckBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unPaidCheckBox.Location = new System.Drawing.Point(62, 25);
            this.unPaidCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.unPaidCheckBox.Name = "unPaidCheckBox";
            this.unPaidCheckBox.Size = new System.Drawing.Size(79, 29);
            this.unPaidCheckBox.TabIndex = 3;
            this.unPaidCheckBox.Text = "Unpaid";
            this.unPaidCheckBox.UseVisualStyleBackColor = true;
            this.unPaidCheckBox.CheckedChanged += new System.EventHandler(this.UnpaidCheckBox_CheckedChanged);
            // 
            // generateAccountStatementButton
            // 
            this.generateAccountStatementButton.Enabled = false;
            this.generateAccountStatementButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateAccountStatementButton.Location = new System.Drawing.Point(966, 566);
            this.generateAccountStatementButton.Name = "generateAccountStatementButton";
            this.generateAccountStatementButton.Size = new System.Drawing.Size(401, 63);
            this.generateAccountStatementButton.TabIndex = 25;
            this.generateAccountStatementButton.Text = "Generate Account Statement";
            this.generateAccountStatementButton.UseVisualStyleBackColor = true;
            this.generateAccountStatementButton.Click += new System.EventHandler(this.generateAccountStatementButton_Click);
            // 
            // LoanInformationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1385, 676);
            this.Controls.Add(this.generateAccountStatementButton);
            this.Controls.Add(this.searchFilterGroupBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.loanDataGridView);
            this.Controls.Add(this.loanMaturityInformationGroupBox);
            this.Controls.Add(this.loanInformationGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoanInformationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Information";
            this.loanInformationGroupBox.ResumeLayout(false);
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            this.totalPenaltyGroupBox.ResumeLayout(false);
            this.totalPenaltyGroupBox.PerformLayout();
            this.principalLoanGroupBox.ResumeLayout(false);
            this.principalLoanGroupBox.PerformLayout();
            this.interestGroupBox.ResumeLayout(false);
            this.interestGroupBox.PerformLayout();
            this.effectiveDateGroupBox.ResumeLayout(false);
            this.effectiveDateGroupBox.PerformLayout();
            this.durationGroupBox.ResumeLayout(false);
            this.durationGroupBox.PerformLayout();
            this.paymentTermGroupBox.ResumeLayout(false);
            this.paymentTermGroupBox.PerformLayout();
            this.customerIdGroupBox.ResumeLayout(false);
            this.customerIdGroupBox.PerformLayout();
            this.customerNameGroupBox.ResumeLayout(false);
            this.customerNameGroupBox.PerformLayout();
            this.loanIdGroupBox.ResumeLayout(false);
            this.loanIdGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.loanMaturityInformationGroupBox.ResumeLayout(false);
            this.totalLoanAmountGroupBox.ResumeLayout(false);
            this.totalLoanAmountGroupBox.PerformLayout();
            this.totalBalanceGroupBox.ResumeLayout(false);
            this.totalBalanceGroupBox.PerformLayout();
            this.totalCollectedAmountGroupBox.ResumeLayout(false);
            this.totalCollectedAmountGroupBox.PerformLayout();
            this.perRemittanceGroupBox.ResumeLayout(false);
            this.perRemittanceGroupBox.PerformLayout();
            this.maturityValueGroupBox.ResumeLayout(false);
            this.maturityValueGroupBox.PerformLayout();
            this.maturityDateGroupBox.ResumeLayout(false);
            this.maturityDateGroupBox.PerformLayout();
            this.maturityInterestGroupBox.ResumeLayout(false);
            this.maturityInterestGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanDataGridView)).EndInit();
            this.searchFilterGroupBox.ResumeLayout(false);
            this.searchFilterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox loanInformationGroupBox;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox totalPenaltyGroupBox;
        private System.Windows.Forms.Label penaltyLabel;
        private System.Windows.Forms.GroupBox principalLoanGroupBox;
        private System.Windows.Forms.Label principalLoanLabel;
        private System.Windows.Forms.GroupBox interestGroupBox;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.GroupBox effectiveDateGroupBox;
        private System.Windows.Forms.Label effectiveDateLabel;
        private System.Windows.Forms.GroupBox durationGroupBox;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.GroupBox paymentTermGroupBox;
        private System.Windows.Forms.Label paymentTermLabel;
        private System.Windows.Forms.GroupBox customerIdGroupBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.GroupBox customerNameGroupBox;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.GroupBox loanIdGroupBox;
        private System.Windows.Forms.Label loanIdLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.GroupBox loanMaturityInformationGroupBox;
        private System.Windows.Forms.GroupBox totalBalanceGroupBox;
        private System.Windows.Forms.Label totalBalanceLabel;
        private System.Windows.Forms.GroupBox totalCollectedAmountGroupBox;
        private System.Windows.Forms.Label totalAmountRemittanceLabel;
        private System.Windows.Forms.GroupBox perRemittanceGroupBox;
        private System.Windows.Forms.Label perRemittanceLabel;
        private System.Windows.Forms.GroupBox maturityValueGroupBox;
        private System.Windows.Forms.Label maturityValueLabel;
        private System.Windows.Forms.GroupBox maturityDateGroupBox;
        private System.Windows.Forms.Label maturityDateLabel;
        private System.Windows.Forms.GroupBox maturityInterestGroupBox;
        private System.Windows.Forms.Label maturityInterestLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView loanDataGridView;
        private System.Windows.Forms.GroupBox searchFilterGroupBox;
        private System.Windows.Forms.CheckBox badDebtCheckBox;
        private System.Windows.Forms.CheckBox fullyPaidCheckBox;
        private System.Windows.Forms.CheckBox unPaidCheckBox;
        private System.Windows.Forms.Button generateAccountStatementButton;
        private System.Windows.Forms.GroupBox totalLoanAmountGroupBox;
        private System.Windows.Forms.Label totalLoanPenaltyLabel;
    }
}