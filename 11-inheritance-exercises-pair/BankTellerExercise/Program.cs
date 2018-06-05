using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankTellerExercise.Classes;

namespace BankTellerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the bank!");
            Console.WriteLine();
            Console.Write("Would you like a (C)hecking or a (S)avings account?:   ");
            var choice = Console.ReadLine();
            choice = choice.ToUpper();
            if (choice=="C")
            {
                Console.Write("What is the name of the checking account?:  ");
                string name = Console.ReadLine();
                BankAccount yourAccount = new CheckingAccount();
                yourAccount.AccountNumber = name;
                Console.Write("How much would you like to deposit today?:  ");
                int deposit = int.Parse(Console.ReadLine());
                yourAccount.Deposit(deposit);


            }
            else
            {
                Console.Write("What is the name of the savings account?:  ");
                string name = Console.ReadLine();
                BankAccount yourAccount = new SavingsAccount();
                yourAccount.AccountNumber = name;
                Console.Write("How much would you like to deposit today?:  ");
                int deposit = int.Parse(Console.ReadLine());
                yourAccount.Deposit(deposit);

            }
            while (true)
            {
                

            }




        }
    }
}
