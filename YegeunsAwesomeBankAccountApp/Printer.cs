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

      
            Console.Write("Press w to withdraw d to depsit and c to check balance ");

            if (w)
            {
                Console.Write("You want to withdraw. How much would you like to withdraw?");

                Console.Read();

                int t;

                t = int.Parse(Console.ReadLine());
            }
            if (d) 
            {
                Console.Write("You want to deposit. How much would you like to deposit?");


                Console.Read();

                int p;

                p = int.Parse(Console.ReadLine());

                else

                Console.Write("You don't have enought money on this account");

            }
            if (c)
            {
                string c;

                Console.Write(" Here is you balance " + AccountBalance);

                
           }                    
 
        }
 
 
 
 
        /**
         * This class should take a BankAccount instance
         * as a paramater to all of its methods
         * and print information about the account
         */
    }
}
