using eu.sig.training.ch04.v3;
using System;
namespace eu.sig.training.ch04.v1
{
    public class CheckingAccount : Account
    {
        private int transferLimit = 100;

        public override Transfer MakeTransfer(string counterAccount, Money amount)
        {
            if (amount.GreaterThan(this.transferLimit))
            {
                throw new BusinessException("Limit exceeded!");
            }
            return base.MakeTransfer(counterAccount, amount);
        }
    }
}