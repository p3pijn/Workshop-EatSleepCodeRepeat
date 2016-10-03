using eu.sig.training.ch04.v3;
using System;

namespace eu.sig.training.ch04.v1
{
    public class SavingsAccount : Account
    {
        public CheckingAccount RegisteredCounterAccount { get; set; }

        public Transfer makeTransfer(string counterAccount, Money amount)
        {
            Transfer result = base.MakeTransfer(counterAccount, amount);
            if (result.CounterAccount.Equals(this.RegisteredCounterAccount))
            {
                return result;
            }
            else
            {
                throw new BusinessException("Counter-account not registered!");
            }
        }
    }
}
