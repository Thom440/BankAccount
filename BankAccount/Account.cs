using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents a single checking account
    /// </summary>
    public class Account
    {

        /// <summary>
        /// Deposits the amount in the bank account and 
        /// returns the new balance
        /// </summary>
        /// <param name="amount">The amount to deposit</param>
        public double Deposit(double amount)
        {
            if (amount >= 10000)
            {
                throw new ArgumentException($"{ nameof(amount)} must be smaller than 10,000");
            }

            if (amount <= 0)
            {
                throw new ArgumentException($"{nameof(amount)} must be a positive value");
            }

            Balance += amount;
            return Balance;
        }

        /// <summary>
        /// Get the current balance
        /// </summary>
        public double Balance { get; private set; }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentException("You cannot withdraw more than the current balance");
            }

            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be positive");
            }
            Balance -= amount;
        }
    }
}
