using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountsApp
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal interestRate):base(owner + " (" + interestRate + "%)")
        {
            InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "You Can not deposit $" + amount;
            }
            if (amount > 20000)
            {
                return "Deposit Limit Reached";
            }

            decimal interestAmount = amount * (InterestRate / 100);
            Balance += amount + interestAmount;
            return "Deposit Completed Successfully";
        }
    }
}
