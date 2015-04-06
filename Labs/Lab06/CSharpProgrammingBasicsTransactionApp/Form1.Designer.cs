namespace CSharpProgrammingBasicsTransactionApp
{
    partial class frmMain
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
            this.btnCreateTransactionAccount = new System.Windows.Forms.Button();
            this.btnCreateDepositAccount = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.lbl_AccountCurrency = new System.Windows.Forms.Label();
            this.lbl_AccountLimit = new System.Windows.Forms.Label();
            this.lbl_Period = new System.Windows.Forms.Label();
            this.lbl_Interest = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.txtPeriodAmount = new System.Windows.Forms.TextBox();
            this.txtInterestAmount = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_PeriodAmount = new System.Windows.Forms.Label();
            this.lbl_PeriodUnit = new System.Windows.Forms.Label();
            this.lbl_InterestAmount = new System.Windows.Forms.Label();
            this.txtInterestUnit = new System.Windows.Forms.TextBox();
            this.lbl_InterestUnit = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_Currency = new System.Windows.Forms.Label();
            this.lbl_BalanceAmount = new System.Windows.Forms.Label();
            this.lbl_TransAccLimit = new System.Windows.Forms.Label();
            this.lbl_TransAccLimitCurrency = new System.Windows.Forms.Label();
            this.lbl_BalanceCurrency = new System.Windows.Forms.Label();
            this.txtPeriodUnit = new System.Windows.Forms.TextBox();
            this.lbl_ShowPeriod = new System.Windows.Forms.Label();
            this.lbl_ShowInterest = new System.Windows.Forms.Label();
            this.lbl_ShowStartDate = new System.Windows.Forms.Label();
            this.lbl_ShowEndDate = new System.Windows.Forms.Label();
            this.lbl_ShowPeroidAmount = new System.Windows.Forms.Label();
            this.lbl_ShowPeroidUnit = new System.Windows.Forms.Label();
            this.lbl_ShowInterestAmount = new System.Windows.Forms.Label();
            this.lbl_ShowInterestUnit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateTransactionAccount
            // 
            this.btnCreateTransactionAccount.Location = new System.Drawing.Point(42, 12);
            this.btnCreateTransactionAccount.Name = "btnCreateTransactionAccount";
            this.btnCreateTransactionAccount.Size = new System.Drawing.Size(193, 23);
            this.btnCreateTransactionAccount.TabIndex = 0;
            this.btnCreateTransactionAccount.Text = "Create Transaction Account";
            this.btnCreateTransactionAccount.UseVisualStyleBackColor = true;
            this.btnCreateTransactionAccount.Click += new System.EventHandler(this.btnCreateTransactionAccount_Click);
            // 
            // btnCreateDepositAccount
            // 
            this.btnCreateDepositAccount.Location = new System.Drawing.Point(423, 5);
            this.btnCreateDepositAccount.Name = "btnCreateDepositAccount";
            this.btnCreateDepositAccount.Size = new System.Drawing.Size(189, 23);
            this.btnCreateDepositAccount.TabIndex = 1;
            this.btnCreateDepositAccount.Text = "CreateDepositAccount";
            this.btnCreateDepositAccount.UseVisualStyleBackColor = true;
            this.btnCreateDepositAccount.Click += new System.EventHandler(this.btnCreateDepositAccount_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(39, 63);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(90, 20);
            this.txtCurrency.TabIndex = 2;
            this.txtCurrency.Text = "MKD";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(39, 114);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(189, 20);
            this.txtLimit.TabIndex = 3;
            this.txtLimit.Text = "10000";
            // 
            // lbl_AccountCurrency
            // 
            this.lbl_AccountCurrency.AutoSize = true;
            this.lbl_AccountCurrency.Location = new System.Drawing.Point(39, 47);
            this.lbl_AccountCurrency.Name = "lbl_AccountCurrency";
            this.lbl_AccountCurrency.Size = new System.Drawing.Size(90, 13);
            this.lbl_AccountCurrency.TabIndex = 4;
            this.lbl_AccountCurrency.Text = "account currency";
            // 
            // lbl_AccountLimit
            // 
            this.lbl_AccountLimit.AutoSize = true;
            this.lbl_AccountLimit.Location = new System.Drawing.Point(39, 98);
            this.lbl_AccountLimit.Name = "lbl_AccountLimit";
            this.lbl_AccountLimit.Size = new System.Drawing.Size(66, 13);
            this.lbl_AccountLimit.TabIndex = 5;
            this.lbl_AccountLimit.Text = "account limit";
            // 
            // lbl_Period
            // 
            this.lbl_Period.AutoSize = true;
            this.lbl_Period.Location = new System.Drawing.Point(392, 37);
            this.lbl_Period.Name = "lbl_Period";
            this.lbl_Period.Size = new System.Drawing.Size(37, 13);
            this.lbl_Period.TabIndex = 6;
            this.lbl_Period.Text = "Period";
            // 
            // lbl_Interest
            // 
            this.lbl_Interest.AutoSize = true;
            this.lbl_Interest.Location = new System.Drawing.Point(392, 100);
            this.lbl_Interest.Name = "lbl_Interest";
            this.lbl_Interest.Size = new System.Drawing.Size(42, 13);
            this.lbl_Interest.TabIndex = 7;
            this.lbl_Interest.Text = "Interest";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(392, 175);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(55, 13);
            this.lbl_StartDate.TabIndex = 8;
            this.lbl_StartDate.Text = "Start Date";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(395, 226);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(52, 13);
            this.lbl_EndDate.TabIndex = 9;
            this.lbl_EndDate.Text = "End Date";
            // 
            // txtPeriodAmount
            // 
            this.txtPeriodAmount.Location = new System.Drawing.Point(440, 57);
            this.txtPeriodAmount.Name = "txtPeriodAmount";
            this.txtPeriodAmount.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodAmount.TabIndex = 10;
            // 
            // txtInterestAmount
            // 
            this.txtInterestAmount.Location = new System.Drawing.Point(440, 124);
            this.txtInterestAmount.Name = "txtInterestAmount";
            this.txtInterestAmount.Size = new System.Drawing.Size(100, 20);
            this.txtInterestAmount.TabIndex = 11;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(453, 169);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 12;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(453, 220);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 13;
            // 
            // lbl_PeriodAmount
            // 
            this.lbl_PeriodAmount.AutoSize = true;
            this.lbl_PeriodAmount.Location = new System.Drawing.Point(392, 60);
            this.lbl_PeriodAmount.Name = "lbl_PeriodAmount";
            this.lbl_PeriodAmount.Size = new System.Drawing.Size(42, 13);
            this.lbl_PeriodAmount.TabIndex = 14;
            this.lbl_PeriodAmount.Text = "amount";
            // 
            // lbl_PeriodUnit
            // 
            this.lbl_PeriodUnit.AutoSize = true;
            this.lbl_PeriodUnit.Location = new System.Drawing.Point(546, 60);
            this.lbl_PeriodUnit.Name = "lbl_PeriodUnit";
            this.lbl_PeriodUnit.Size = new System.Drawing.Size(24, 13);
            this.lbl_PeriodUnit.TabIndex = 15;
            this.lbl_PeriodUnit.Text = "unit";
            // 
            // lbl_InterestAmount
            // 
            this.lbl_InterestAmount.AutoSize = true;
            this.lbl_InterestAmount.Location = new System.Drawing.Point(392, 127);
            this.lbl_InterestAmount.Name = "lbl_InterestAmount";
            this.lbl_InterestAmount.Size = new System.Drawing.Size(42, 13);
            this.lbl_InterestAmount.TabIndex = 16;
            this.lbl_InterestAmount.Text = "amount";
            // 
            // txtInterestUnit
            // 
            this.txtInterestUnit.Location = new System.Drawing.Point(578, 124);
            this.txtInterestUnit.Name = "txtInterestUnit";
            this.txtInterestUnit.Size = new System.Drawing.Size(100, 20);
            this.txtInterestUnit.TabIndex = 18;
            // 
            // lbl_InterestUnit
            // 
            this.lbl_InterestUnit.AutoSize = true;
            this.lbl_InterestUnit.Location = new System.Drawing.Point(546, 127);
            this.lbl_InterestUnit.Name = "lbl_InterestUnit";
            this.lbl_InterestUnit.Size = new System.Drawing.Size(24, 13);
            this.lbl_InterestUnit.TabIndex = 19;
            this.lbl_InterestUnit.Text = "unit";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(31, 253);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(0, 13);
            this.lbl_Id.TabIndex = 20;
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(31, 274);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(0, 13);
            this.lbl_Number.TabIndex = 21;
            // 
            // lbl_Currency
            // 
            this.lbl_Currency.AutoSize = true;
            this.lbl_Currency.Location = new System.Drawing.Point(31, 296);
            this.lbl_Currency.Name = "lbl_Currency";
            this.lbl_Currency.Size = new System.Drawing.Size(0, 13);
            this.lbl_Currency.TabIndex = 22;
            // 
            // lbl_BalanceAmount
            // 
            this.lbl_BalanceAmount.AutoSize = true;
            this.lbl_BalanceAmount.Location = new System.Drawing.Point(31, 317);
            this.lbl_BalanceAmount.Name = "lbl_BalanceAmount";
            this.lbl_BalanceAmount.Size = new System.Drawing.Size(0, 13);
            this.lbl_BalanceAmount.TabIndex = 23;
            // 
            // lbl_TransAccLimit
            // 
            this.lbl_TransAccLimit.AutoSize = true;
            this.lbl_TransAccLimit.Location = new System.Drawing.Point(39, 159);
            this.lbl_TransAccLimit.Name = "lbl_TransAccLimit";
            this.lbl_TransAccLimit.Size = new System.Drawing.Size(0, 13);
            this.lbl_TransAccLimit.TabIndex = 24;
            // 
            // lbl_TransAccLimitCurrency
            // 
            this.lbl_TransAccLimitCurrency.AutoSize = true;
            this.lbl_TransAccLimitCurrency.Location = new System.Drawing.Point(130, 159);
            this.lbl_TransAccLimitCurrency.Name = "lbl_TransAccLimitCurrency";
            this.lbl_TransAccLimitCurrency.Size = new System.Drawing.Size(0, 13);
            this.lbl_TransAccLimitCurrency.TabIndex = 25;
            // 
            // lbl_BalanceCurrency
            // 
            this.lbl_BalanceCurrency.AutoSize = true;
            this.lbl_BalanceCurrency.Location = new System.Drawing.Point(145, 317);
            this.lbl_BalanceCurrency.Name = "lbl_BalanceCurrency";
            this.lbl_BalanceCurrency.Size = new System.Drawing.Size(0, 13);
            this.lbl_BalanceCurrency.TabIndex = 26;
            // 
            // txtPeriodUnit
            // 
            this.txtPeriodUnit.Location = new System.Drawing.Point(578, 57);
            this.txtPeriodUnit.Name = "txtPeriodUnit";
            this.txtPeriodUnit.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodUnit.TabIndex = 27;
            // 
            // lbl_ShowPeriod
            // 
            this.lbl_ShowPeriod.AutoSize = true;
            this.lbl_ShowPeriod.Location = new System.Drawing.Point(395, 253);
            this.lbl_ShowPeriod.Name = "lbl_ShowPeriod";
            this.lbl_ShowPeriod.Size = new System.Drawing.Size(0, 13);
            this.lbl_ShowPeriod.TabIndex = 28;
            // 
            // lbl_ShowInterest
            // 
            this.lbl_ShowInterest.AutoSize = true;
            this.lbl_ShowInterest.Location = new System.Drawing.Point(395, 274);
            this.lbl_ShowInterest.Name = "lbl_ShowInterest";
            this.lbl_ShowInterest.Size = new System.Drawing.Size(0, 13);
            this.lbl_ShowInterest.TabIndex = 29;
            // 
            // lbl_ShowStartDate
            // 
            this.lbl_ShowStartDate.AutoSize = true;
            this.lbl_ShowStartDate.Location = new System.Drawing.Point(395, 296);
            this.lbl_ShowStartDate.Name = "lbl_ShowStartDate";
            this.lbl_ShowStartDate.Size = new System.Drawing.Size(0, 13);
            this.lbl_ShowStartDate.TabIndex = 30;
            // 
            // lbl_ShowEndDate
            // 
            this.lbl_ShowEndDate.AutoSize = true;
            this.lbl_ShowEndDate.Location = new System.Drawing.Point(395, 317);
            this.lbl_ShowEndDate.Name = "lbl_ShowEndDate";
            this.lbl_ShowEndDate.Size = new System.Drawing.Size(0, 13);
            this.lbl_ShowEndDate.TabIndex = 31;
            // 
            // lbl_ShowPeroidAmount
            // 
            this.lbl_ShowPeroidAmount.AutoSize = true;
            this.lbl_ShowPeroidAmount.Location = new System.Drawing.Point(453, 253);
            this.lbl_ShowPeroidAmount.Name = "lbl_ShowPeroidAmount";
            this.lbl_ShowPeroidAmount.Size = new System.Drawing.Size(0, 13);
            this.lbl_ShowPeroidAmount.TabIndex = 32;
            // 
            // lbl_ShowPeroidUnit
            // 
            this.lbl_ShowPeroidUnit.AutoSize = true;
            this.lbl_ShowPeroidUnit.Location = new System.Drawing.Point(495, 253);
            this.lbl_ShowPeroidUnit.Name = "lbl_ShowPeroidUnit";
            this.lbl_ShowPeroidUnit.Size = new System.Drawing.Size(0, 13);
            this.lbl_ShowPeroidUnit.TabIndex = 33;
            // 
            // lbl_ShowInterestAmount
            // 
            this.lbl_ShowInterestAmount.AutoSize = true;
            this.lbl_ShowInterestAmount.Location = new System.Drawing.Point(450, 274);
            this.lbl_ShowInterestAmount.Name = "lbl_ShowInterestAmount";
            this.lbl_ShowInterestAmount.Size = new System.Drawing.Size(0, 13);
            this.lbl_ShowInterestAmount.TabIndex = 34;
            // 
            // lbl_ShowInterestUnit
            // 
            this.lbl_ShowInterestUnit.AutoSize = true;
            this.lbl_ShowInterestUnit.Location = new System.Drawing.Point(495, 274);
            this.lbl_ShowInterestUnit.Name = "lbl_ShowInterestUnit";
            this.lbl_ShowInterestUnit.Size = new System.Drawing.Size(0, 13);
            this.lbl_ShowInterestUnit.TabIndex = 35;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 396);
            this.Controls.Add(this.lbl_ShowInterestUnit);
            this.Controls.Add(this.lbl_ShowInterestAmount);
            this.Controls.Add(this.lbl_ShowPeroidUnit);
            this.Controls.Add(this.lbl_ShowPeroidAmount);
            this.Controls.Add(this.lbl_ShowEndDate);
            this.Controls.Add(this.lbl_ShowStartDate);
            this.Controls.Add(this.lbl_ShowInterest);
            this.Controls.Add(this.lbl_ShowPeriod);
            this.Controls.Add(this.txtPeriodUnit);
            this.Controls.Add(this.lbl_BalanceCurrency);
            this.Controls.Add(this.lbl_TransAccLimitCurrency);
            this.Controls.Add(this.lbl_TransAccLimit);
            this.Controls.Add(this.lbl_BalanceAmount);
            this.Controls.Add(this.lbl_Currency);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_InterestUnit);
            this.Controls.Add(this.txtInterestUnit);
            this.Controls.Add(this.lbl_InterestAmount);
            this.Controls.Add(this.lbl_PeriodUnit);
            this.Controls.Add(this.lbl_PeriodAmount);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtInterestAmount);
            this.Controls.Add(this.txtPeriodAmount);
            this.Controls.Add(this.lbl_EndDate);
            this.Controls.Add(this.lbl_StartDate);
            this.Controls.Add(this.lbl_Interest);
            this.Controls.Add(this.lbl_Period);
            this.Controls.Add(this.lbl_AccountLimit);
            this.Controls.Add(this.lbl_AccountCurrency);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.btnCreateDepositAccount);
            this.Controls.Add(this.btnCreateTransactionAccount);
            this.Name = "frmMain";
            this.Text = "Account Details Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTransactionAccount;
        private System.Windows.Forms.Button btnCreateDepositAccount;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label lbl_AccountCurrency;
        private System.Windows.Forms.Label lbl_AccountLimit;
        private System.Windows.Forms.Label lbl_Period;
        private System.Windows.Forms.Label lbl_Interest;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.TextBox txtPeriodAmount;
        private System.Windows.Forms.TextBox txtInterestAmount;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lbl_PeriodAmount;
        private System.Windows.Forms.Label lbl_PeriodUnit;
        private System.Windows.Forms.Label lbl_InterestAmount;
        private System.Windows.Forms.TextBox txtInterestUnit;
        private System.Windows.Forms.Label lbl_InterestUnit;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Label lbl_Currency;
        private System.Windows.Forms.Label lbl_BalanceAmount;
        private System.Windows.Forms.Label lbl_TransAccLimit;
        private System.Windows.Forms.Label lbl_TransAccLimitCurrency;
        private System.Windows.Forms.Label lbl_BalanceCurrency;
        private System.Windows.Forms.TextBox txtPeriodUnit;
        private System.Windows.Forms.Label lbl_ShowPeriod;
        private System.Windows.Forms.Label lbl_ShowInterest;
        private System.Windows.Forms.Label lbl_ShowStartDate;
        private System.Windows.Forms.Label lbl_ShowEndDate;
        private System.Windows.Forms.Label lbl_ShowPeroidAmount;
        private System.Windows.Forms.Label lbl_ShowPeroidUnit;
        private System.Windows.Forms.Label lbl_ShowInterestAmount;
        private System.Windows.Forms.Label lbl_ShowInterestUnit;
    }
}

