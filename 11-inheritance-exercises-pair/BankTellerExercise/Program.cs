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
            bool leave = false;
            Console.WriteLine("Welcome to the bank!");
            Console.WriteLine();
            Console.Write("Would you like a (C)hecking or a (S)avings account?:   ");
            var choice = Console.ReadLine();
            BankAccount yourAccount= new BankAccount();
            choice = choice.ToUpper();
            if (choice=="C")
            {
                Console.Write("What is the name of the checking account?:  ");
                string name = Console.ReadLine();
                yourAccount = new CheckingAccount
                {
                    AccountNumber = name
                };



            }
            else
            {
                Console.Write("What is the name of the savings account?:  ");
                string name = Console.ReadLine();
                yourAccount = new SavingsAccount
                {
                    AccountNumber = name
                };


            }
            
            while (!leave)
            {
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine("1. Check your Balance");        //Check Balance
                Console.WriteLine("2. Withdraw money");        //Withdraw
                Console.WriteLine("3. Deposit money");        //Deposit
                Console.WriteLine("4.Transfer money to another account");        //Transfer
                Console.WriteLine("5. Quit");        //Quit
                var menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine($"Your balance in account: {yourAccount.AccountNumber}  is ${yourAccount.Balance}");
                        Console.WriteLine();
                        break;


                    case 2:
                        Console.WriteLine("How much would you like to withdraw? ");
                        Console.WriteLine();
                        int withdraw = int.Parse(Console.ReadLine());
                        yourAccount.Withdraw(withdraw);
                        break;


                    case 3:
                        Console.WriteLine("How much would you like to deposit? ");
                        Console.WriteLine();
                        int deposit = int.Parse(Console.ReadLine());
                        yourAccount.Deposit(deposit);
                        break;


                    case 4:
                        Console.WriteLine("Who would you like to transfer to? ");
                        string transfersName = Console.ReadLine();
                        Console.WriteLine("How much?");
                        var tranferNum = int.Parse(Console.ReadLine());
                        BankAccount transferAcct = new BankAccount
                        {
                            AccountNumber = transfersName
                        };
                        yourAccount.Transfer(transferAcct, tranferNum);
                        Console.WriteLine($"{transfersName} was transferred {tranferNum}. Their account now holds ${transferAcct.Balance}");

                        //would need a dictionary to hold the different accounts you can transfer to 

                        break;

                    case 5:
                        Console.WriteLine("want to leave to bank?  (Y/N)");
                        Console.WriteLine();
                        var quit = Console.ReadLine();
                        quit = quit.ToUpper();
                        if (quit == "Y")
                        {
                            Console.WriteLine("Leaving Bank ... ");
                            System.Threading.Thread.Sleep(1500);
                            Console.Beep(3007, 300);
                            Console.Beep(3007, 300);

                            Console.WriteLine("Bye-Bye!");
                            leave = true;
                            break;
                           
                        }
                        else
                        {
                            break;
                        }

                        
           


                }


            }




        }
    }
}
