using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YegeunsAwesomeBankAccountApp
{
    class BankAccount
    {
        public double GetBalance = 100;

        public double GetBalance()
        {
            return balance;
        }
        public double Deposit(double amount)
        {
            this.GetBalance += amount;

            this.message("Depoosit succesfull");
            return true;
        }


        public double Withdraw()
        {
            this.GetBalance -= amount;
            this.message("Withdraw succesful");
            return true;

        }








        /**
         * My job is to:
         * 1) Print information about the actual account
         * 2) Add money into acccout
         * 3) Subtract money from the account (remember to check if enough funds available!!)
         */
    }
}

