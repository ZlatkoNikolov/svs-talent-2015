using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Common
{
    /// <summary>
    /// 
    /// </summary>
    public struct CurrencyAmount
    {
        private decimal amount;
        private string currency;

        /// <summary>
        /// 
        /// </summary>
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }


    }
}
