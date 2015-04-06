using System;
namespace CSharpProgrammingBasics.Classes.Interfaces
{
    interface ITransactionAccount : IAccount
    {
        CSharpProgrammingBasics.Classes.Common.CurrencyAmount Limit { get; }
    }
}
