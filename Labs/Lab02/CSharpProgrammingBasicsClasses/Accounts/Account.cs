using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Accounts
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Account:IAccount
    {
        private long id;
        private string number;
        private string currency;
        private CurrencyAmount balance;



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <param name="currency"></param>
        public Account(long id, string number, string currency)
        {
            Id = id;
            Number = number;
            Currency = currency;
            balance = new CurrencyAmount();
            balance.Amount = 0;
            balance.Currency = currency;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        public Account(string currency)
            : this(-1, "X", currency)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public long Id
        {
            get { return id; }
            private set { id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Number
        {
            get { return number; }
            private set { number = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Currency { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public CurrencyAmount Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        #region Public methods
        public virtual TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            //TODO da gi napravam metodive
            //balance.Amount -= balance.Amount - amount.Amount;
            if (Check(amount))
            {
                CurrencyAmount c = Balance;
                c.Amount = c.Amount - amount.Amount;
                Balance = c;
                return new TransactionStatus();
            }
            else return TransactionStatus.Failed;

        }

        public virtual TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            //TODO da gi napravam metodive
            if (Check(amount))
            {
                CurrencyAmount c = Balance;
                c.Amount = c.Amount + amount.Amount;
                Balance = c;
                return TransactionStatus.Completed;
            }
            else return TransactionStatus.Failed;
        }
        #endregion

        #region Private methods
        private bool Check(CurrencyAmount amount)
        {
            if (amount.Currency == Balance.Currency) return true;
            else return false;
        }
        #endregion
    }
}
