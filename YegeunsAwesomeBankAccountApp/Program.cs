using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YegeunsAwesomeBankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Here is where the method will be called that print to the console
             * The objective here is to INSTANTIATE a Printer and a BankAccount
             * and call the various methods to a achieve the following:
             * 
             * 1) Print the amount of money in the account
             * 2) Add some money and print the new amount
             * 3) Subtract some money and print the new amount
             * 4) TRY to subtract some more, but fail (Operation, not program) because not enough to subtract)
             */

            /**
             * But I don't want to see anywhere in THIS file the following:
             * 
             * Console.WriteLine("......");
             */

            // This instantiaes the printer and bank account
            Printer ThePrinter = new Printer();
            BankAccount BankBalance = new BankAccount();

            //This prints out the balnce of the current money in the bank account
            ThePrinter.PrintBalance(BankBalance);

            // This deposits money into the bank account

            double DepositMoney = 1000;
            BankBalance.Deposit(DepositMoney);

            ThePrinter.PrintBalance(BankBalance);
            
            //this withdraws money out of the bank account
            double WithdrawMoney = 90;
            BankBalance.Withdraw(WithdrawMoney);

            ThePrinter.PrintBalance(BankBalance);
            
            //This withdraws too much so you can't over draft. 
            double WithdrawTooMuch = 100000000;
            BankBalance.Withdraw(WithdrawTooMuch);

            




        }
    }
}
