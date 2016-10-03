using System;
using eu.sig.training.ch04.v3;
using eu.sig.training.ch04.v1;

namespace eu.sig.training.ch04.v3
{

    // tag::Account[]
    public abstract class Account
    {
        private const int ACCOUNT_NUMBER_LENGTH = 9;
        private const int VALIDATION_MODULO = 11;

        public virtual Transfer MakeTransfer(string counterAccount, Money amount)
        {
            if (IsValid(counterAccount))
            {
                CheckingAccount acct = Accounts.FindAcctByNumber(counterAccount);
                return new Transfer(this, acct, amount);
            }
            else
            {
                throw new BusinessException("Invalid account number!");
            }
        }

        public static bool IsValid(string number)
        {
            if (String.IsNullOrEmpty(number) || number.Length != ACCOUNT_NUMBER_LENGTH)
            {
                return false;
            }
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum = sum + (ACCOUNT_NUMBER_LENGTH - i) * (int)Char.GetNumericValue(number[i]);
            }
            return sum % VALIDATION_MODULO == 0;
        }
    }
    // end::Account[]

}