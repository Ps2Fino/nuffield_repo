﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YegeunsAwesomeBankAccountApp
{
    class BankAccount
    {
        public double Balance = 100;

        public double GetBalance()
        {
            return Balance;
        }

        public double Deposit(double amount)
        {
            this.Balance += amount;

            return Balance;
        }


        public double Withdraw(double amount)
        {
            
            if (Balance >= amount)
            {
                Balance -= amount;
                
            }

            
            return Balance;

        }









        /**
         * My job is to:
         * 1) Print information about the actual account
         * 2) Add money into acccout
         * 3) Subtract money from the account (remember to check if enough funds available!!)
         */
    }
}

