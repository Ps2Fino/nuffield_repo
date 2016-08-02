using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YegeunsAwesomeBankAccountApp
{
    class Printer
    {
        public void PrintBalance(BankAccount AccountBalance);

        //double Balance = Balance();

        //Console.WriteLine("You have " + Balance + " in you bank account");

        //Console.WriteLine("Press 1 to check balance /n2. 2 to depsit /n3. 3 to withdraw ");

        //int userInput = int.Parse(Console.ReadLine());

        //switch (userInput)

        //{
        //    case 1:
        //        Console.WriteLine(Balance);
        //    case 2:





        Console.WriteLine("Press 1 to check balance /n2. 2 to depsit /n3. 3 to withdraw ");

        string userValue = Console.ReadLine();
         if (userValue == "1")
            {
               Console.WriteLine("You want to withdraw. How much would you like to withdraw?");

                Console.Read();

                double t;

                t = .Parse(Console.ReadLine());
            }
            if (userValue == "2")
            {
                Console.Write("You want to deposit. How much would you like to deposit?");


                Console.Read();

                int p;

                p = int.Parse(Console.ReadLine());

                else

                Console.Write("You don't have enought money on this account");

            }
              if (userValue == "3")
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
