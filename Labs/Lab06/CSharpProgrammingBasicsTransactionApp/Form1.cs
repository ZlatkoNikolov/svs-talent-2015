using CSharpProgrammingBasics.Classes.Accounts;
using CSharpProgrammingBasics.Classes.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpProgrammingBasicsTransactionApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {

            TransactionAccount ta = new TransactionAccount(txtCurrency.Text, decimal.Parse(txtLimit.Text));
            PopulateAccountLabels(ta);

        }

        private void PopulateAccountLabels(Account a)
        {
            lbl_Id.Text = a.Id.ToString();
            lbl_Number.Text = a.Number;
            lbl_Currency.Text = a.Currency;
            lbl_BalanceAmount.Text = a.Balance.Amount.ToString();
            lbl_BalanceCurrency.Text = a.Balance.Currency;
            IsItDepositAccount(a);
            IsItTransactionAccount(a);
        }

        private void IsItTransactionAccount(Account a)
        {
            if (a is TransactionAccount)
            {
                
                lbl_TransAccLimit.Text = txtCurrency.Text;
                lbl_TransAccLimitCurrency.Text = txtLimit.Text;
            }
           
        }

        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {

            UnitOfTime u = new UnitOfTime();
            TimePeriod tp = new TimePeriod();
            tp.Period = 2;///int.Parse(txtPeriodAmount.Text);
            tp.Unit = u;

            InterestRate ir = new InterestRate();
            ir.Percent = 23;//decimal.Parse(txtInterestAmount.Text);
            ir.Unit = u;

            DateTime dtst = new DateTime();
            var v = DateTime.Parse(dtpStartDate.Text);
            dtst = v;

            DateTime dtet = new DateTime();
            var v2 = DateTime.Parse(dtpEndDate.Text);
            dtet = v2;

            TransactionAccount ta = new TransactionAccount(txtCurrency.Text, decimal.Parse(txtLimit.Text));

            DepositAccount da = new DepositAccount(txtCurrency.Text, tp, ir, dtst, dtet, ta);
            PopulateAccountLabels(da);
        }


        private void IsItDepositAccount(Account a)
        {
            if (a is DepositAccount)
            {
                
                lbl_ShowPeroidAmount.Text = txtPeriodAmount.Text;
                lbl_ShowPeroidUnit.Text = txtPeriodUnit.Text;
                lbl_ShowInterestAmount.Text = txtInterestAmount.Text;
                lbl_ShowInterestUnit.Text = txtInterestUnit.Text;
                lbl_ShowStartDate.Text = dtpStartDate.Text;
                lbl_ShowEndDate.Text = dtpEndDate.Text;
                lbl_ShowPeriod.Text = "Period";
                lbl_ShowInterest.Text = "Interest";
            }
            
        }


    }
}
