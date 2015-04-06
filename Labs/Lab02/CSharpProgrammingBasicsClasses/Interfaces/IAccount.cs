using CSharpProgrammingBasics.Classes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Interfaces
{
    interface IAccount
    {

        long Id { get; }
        string Number { get; }
        string Currency { get; }
        CurrencyAmount Balance { get; }
        TransactionStatus DebitAmount(CurrencyAmount amount);
        TransactionStatus CreditAmount(CurrencyAmount amount);
    }
}
