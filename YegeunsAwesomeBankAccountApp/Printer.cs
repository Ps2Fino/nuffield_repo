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
            int w = (int)Console.Read();
            if (int.(w))
            {
                if (int.(w))
                {
                    Console.WriteLine("You want to withdraw. How much would you like to withdraw?");

                    Console.Read();

                    double t;

                    t = .Parse(Console.ReadLine());
                }
                if (int.d)
                {
                    Console.Write("You want to deposit. How much would you like to deposit?");


                    Console.Read();

                    int p;

                    p = int.Parse(Console.ReadLine());

                else

                Console.Write("You don't have enought money on this account");

                }
                if (int.c)
                {
                    int c;

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
}
