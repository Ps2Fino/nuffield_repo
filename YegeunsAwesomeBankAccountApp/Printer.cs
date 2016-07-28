using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YegeunsAwesomeBankAccountApp
{
    class Printer
    {
        public void PrintBalance(BankAccount AccountBalance)
        {
            double Balance = AccountBalance.GetBalance();
            Console.WriteLine("You have " + Balance + " in you bank account");
   
         
                      
            
        }
 
 
 
 
        /**
         * This class should take a BankAccount instance
         * as a paramater to all of its methods
         * and print information about the account
         */
    }
}
