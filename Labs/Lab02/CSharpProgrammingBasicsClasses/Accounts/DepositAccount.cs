using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSharpProgrammingBasics.Classes.Accounts
{
    public class DepositAccount : Account, IDepositAccount
    {
        private TimePeriod period;
        private InterestRate interest;
        private DateTime startDate;
        private DateTime endDate;
        private ITransactionAccount transactionAccount;

        public DepositAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, TransactionAccount transactionAccount)
            : base(currency)
        {
            Period = depositPeriod;
            Interest = interestRate;
            StartDate = startDate;
            EndDate = endDate;
            
            this.transactionAccount= transactionAccount;
            
        }

        public TimePeriod Period
        {
            get { return period; }
            set { period = value; }
        }

        public InterestRate Interest
        {
            get { return interest; }
            set { interest = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        DateTime IDepositAccount.EndDate
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        InterestRate IDepositAccount.Interest
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        TimePeriod IDepositAccount.Period
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        DateTime IDepositAccount.StartDate
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        ITransactionAccount IDepositAccount.TransactionAccount
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
