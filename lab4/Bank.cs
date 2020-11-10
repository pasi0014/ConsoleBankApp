using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Bank
    {
        

        static void Main(string[] args)
        {
            //Initialize variables 
            string name;
            string initial;
            double initialDeposit;
            double monthDeposit;
            string monthsDeposit;

            Console.Write("Enter the number of month to deposit: ");
            int months = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Account account = null;
            List < Account > accountList = new List<Account>();



            while (true)
            {
                Console.Write("Enter Customer Name: ");
                name = Console.ReadLine();

                if (name == "")
                {
                    Console.WriteLine("\n\n");
                    break;
                }

                Console.Write("Enter " + name + "'s" + " Initial Deposit Amount (minimum $1,000.00): ");
                initial = Console.ReadLine();
                initialDeposit = Convert.ToDouble(initial);

                Console.Write("Enter " + name + "'s " + "Montly Deposit Amount (minimum $50.00): ");
                monthsDeposit = Console.ReadLine();
                monthDeposit = Convert.ToDouble(monthsDeposit);

                Console.WriteLine("\n");

                account = new Account(name, initialDeposit);

                for (int i = 0; i < months; i++)
                {
                    account.Deposit(monthDeposit);
                }


                accountList.Add(account);

            }



            foreach (var n in accountList)
            {
                n.Deduction();
                Console.Write("After " + months + " months " + n.AccountOwner + "'s account (#" + n.AccountNumber + "), has a balance of: $" + n.AccountBalance + "\n"); 
            }

            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to complete");

            Console.Read();
        }
    }
}