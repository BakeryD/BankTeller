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
            Console.WriteLine("Welcome to the virtual bank!");
            Console.WriteLine();
            Console.Write("What is your name?   ");
            string yourName = Console.ReadLine();

            var you = new BankCustomer
            {
                Name = yourName
            };


            Console.Write("Would you like a (C)hecking or a (S)avings account?:   ");
            var choice = Console.ReadLine();
            BankAccount yourAccount = new BankAccount();
            choice = choice.ToUpper();
            if (choice == "C")
            {
                Console.Write("What is the name of the checking account?:  ");
                string name = Console.ReadLine().ToLower();
                var newCheck = new CheckingAccount();

                you.AddAccount(newCheck, name);

                //yourAccount = new CheckingAccount
                //{
                //    AccountNumber = name
                //};



            }
            else
            {
                Console.Write("What is the name of the savings account?:  ");
                string name = Console.ReadLine().ToLower();

                var newSave = new SavingsAccount();

                you.AddAccount(newSave, name);
                //yourAccount = new SavingsAccount()
                //{
                //    AccountNumber = name
                //};


            }
            Console.Clear();

            while (!leave)
            {
                Console.WriteLine("______________________________________");
                Console.WriteLine();
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine("1. Check your Balance");        //Check Balance
                Console.WriteLine("2. Withdraw money");        //Withdraw
                Console.WriteLine("3. Deposit money");        //Deposit
                Console.WriteLine("4. Transfer money to another account");        //Transfer
                Console.WriteLine("5. Open another account");
                Console.WriteLine("6. Quit");        //Quit

                var menuChoice = decimal.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        Console.Write("What is the name of the account would you like the balance of?   ");

                        string AChoice = Console.ReadLine();
                        foreach (var acct in you.Accounts)
                        {
                            if (acct.AccountNumber == AChoice.ToLower())
                            {
                                Console.WriteLine($"Your balance in Account : {acct.AccountNumber} is  ${acct.Balance}");
                                break;
                            }



                        }


                        break;


                    case 2:
                        Console.WriteLine("Which account would you like to withdaraw from (Name on Account) ?   ");
                        string wAcct = Console.ReadLine().ToLower();
                        for (int i = 0; i < you.Accounts.Length; i++)
                        {
                            if (you.Accounts[i].AccountNumber == wAcct)
                            {
                                Console.WriteLine("How Much?   ");
                                decimal withdraw = decimal.Parse(Console.ReadLine());
                                you.Accounts[i].Withdraw(withdraw);

                            }

                            if (i == you.Accounts.Length - 1)
                            {
                                Console.WriteLine("You do not have that account...");
                            }


                        }


                        //Console.WriteLine("How much would you like to withdraw? ");
                        //Console.WriteLine();
                        //decimal withdraw = decimal.Parse(Console.ReadLine());
                        //yourAccount.Withdraw(withdraw);
                        //Console.WriteLine($"Your balance is ${yourAccount.Balance}");
                        //Console.WriteLine();

                        break;


                    case 3:


                        Console.WriteLine("Which account would you like to deposit to (Name on Account) ?   ");
                        string dAcct = Console.ReadLine().ToLower();
                        for (int i = 0; i < you.Accounts.Length; i++)
                        {
                            if (you.Accounts[i].AccountNumber == dAcct)
                            {
                                Console.WriteLine("How Much?   ");
                                decimal deposit = decimal.Parse(Console.ReadLine());
                                you.Accounts[i].Deposit(deposit);
								break;
                            }
							if (i == you.Accounts.Length - 1)
                            {
                                Console.WriteLine("You do not have that account...");
                            }




                        }

                        //Console.WriteLine("How much would you like to deposit? ");
                        //Console.WriteLine();
                        //var deposit = decimal.Parse(Console.ReadLine());
                        //yourAccount.Deposit(deposit);
                        //Console.WriteLine($"Your balance is ${yourAccount.Balance}");
                        //Console.WriteLine();
                        break;


                    case 4:

                        bool doesNotExist = true;

                        while (doesNotExist)
                        {

                            Console.Write("Which account are you transferring from (Enter Name on account)?  ");
                           string tFrom = Console.ReadLine().ToLower();
                            Console.Write("How Much?  ");
                            decimal transAmount = decimal.Parse(Console.ReadLine());
                            

                            for (int i = 0; i < you.Accounts.Length; i++)

                            {
                                if (i == you.Accounts.Length - 1 && you.Accounts[i].AccountNumber != tFrom)
                                {
                                    Console.WriteLine("That account doesnt't exist");
                                    break;
                                }
                                else if (you.Accounts[i].AccountNumber == tFrom)
                                {
                                    var transferFrom = you.Accounts[i];
                                    while (doesNotExist)
                                    {

                                        Console.WriteLine();
                                        Console.Write("Which of your accounts are you transferring to (Enter Name on account)?   ");
                                        string tTo = Console.ReadLine().ToLower();

                                        for (int a = 0; a < you.Accounts.Length; a++)
                                        {
                                            if (a == you.Accounts.Length - 1 && you.Accounts[a].AccountNumber != tTo)
                                            {
                                                Console.WriteLine("That account doesnt't exist");
                                                break;
                                            }
                                            else if (you.Accounts[a].AccountNumber == tTo)
                                            {
                                                var transferTo = you.Accounts[a];
                                                
                                                transferFrom.Transfer(transferTo, transAmount);
                                                doesNotExist = false;

                                                break;
                                            }






                                        }


                                    }

                                    break;
                                }

                            }

                        }
                        
                        








                        //Console.Write("Who would you like to transfer to?: ");
                        //string transfersName = Console.ReadLine();
                        //Console.Write("How much?:  ");
                        //var tranferNum = decimal.Parse(Console.ReadLine());
                        //BankAccount transferAcct = new BankAccount
                        //{
                        //    AccountNumber = transfersName
                        //};
                        //yourAccount.Transfer(transferAcct, tranferNum);
                        //Console.WriteLine($"{transfersName} was transferred {tranferNum}. Their account now holds ${transferAcct.Balance}");
                        //Console.WriteLine($"Your balance is ${yourAccount.Balance}");


                        //would need a dictionary to hold the different accounts you can transfer to 

                        break;

                    case 5:
                        Console.WriteLine("What kind of account would you like to open? (C/S)  ");
                        string aChoice = Console.ReadLine().ToLower();
                        if (aChoice == "c")
                        {
                            Console.Write("What is the name of the account?   ");
                            string aName = Console.ReadLine().ToLower();
                            var newCheck = new CheckingAccount();
                          
                            you.AddAccount(newCheck, aName);



                        }
                        else
                        {
                            Console.Write("What is the name of the account?   ");
                            string aName = Console.ReadLine().ToLower();
                            var newSave = new SavingsAccount();

                            you.AddAccount(newSave, aName);

                        }

                        break;

                    case 6:
                        Console.WriteLine("Do you want to leave the bank?  (Y/N)");
                        Console.WriteLine();
                        var quit = Console.ReadLine();
                        quit = quit.ToUpper();
                        if (quit == "Y")
                        {
                            Console.WriteLine("Leaving Bank ... ");
                            System.Threading.Thread.Sleep(1500);
                            Console.Beep(3007, 80);
                            // Console.Beep(3007, 80);
                            Console.Beep(2600, 100);

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
