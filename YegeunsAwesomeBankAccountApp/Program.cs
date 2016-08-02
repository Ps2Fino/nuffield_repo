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
            Printer ThePrinter = new Printer();
            BankAccount BankBalance = new BankAccount();

            //This prints out the balnce of the current money in the bank account
            ThePrinter.PrintBalance(BankBalance);

            // This deposits money into the bank account

            double DepositMoney = p;
            BankBalance.Deposit(DepositMoney);

            ThePrinter.PrintBalance(BankBalance);
            
            //this withdraws money out of the bank account
            double WithdrawMoney = t;
            BankBalance.Withdraw(WithdrawMoney);

            ThePrinter.PrintBalance(BankBalance);

        } while (escape.key != Consolekey.Escape);
    }
}
