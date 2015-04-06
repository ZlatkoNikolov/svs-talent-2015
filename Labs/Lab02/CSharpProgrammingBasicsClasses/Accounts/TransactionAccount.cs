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
    public class TransactionAccount : Account, ITransactionAccount
    {
        private CurrencyAmount limit;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="limitAmount"></param>
        public TransactionAccount(string currency, decimal limitAmount)
            : base(currency)
        {
            limit=new CurrencyAmount();
            limit.Amount = limitAmount;
        }

        
        /// <summary>
        /// 
        /// </summary>
        public CurrencyAmount Limit
        {
            get { return limit; }
            private set { limit = value; }
        }
    }
}
