using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;


namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankCustomerTests
    {
        [TestMethod]
        public void Verify_VIP_Status_Works()
        {

            //create a bank account for a customer
            BankCustomer customer = new BankCustomer();
            BankAccount[] bankAccounts = customer.Accounts;

           BankAccount bank = new BankAccount();
            customer.AddAccount(bank, "TEST1");

            //deposit over 25000
            bank.Deposit(25001);



            //check status
            bool amAVIP = customer.IsVIP;

            Assert.IsTrue(customer.IsVIP);


        }
        [TestMethod]
        public void Verify_VIP_Status_Works_WithMultiplAccounts()
        {
            BankCustomer customer = new BankCustomer();
            BankAccount bank = new BankAccount();
            BankAccount bank2 = new BankAccount();

            customer.AddAccount(bank, "TEST1");
            customer.AddAccount(bank2, "TEST2");

            bank.Deposit(12500);
            bank2.Deposit(12500);


            Assert.IsTrue(customer.IsVIP);





        }

        [TestMethod]
        public void Verify_Customer_Can_Hold_Multiple_Accounts()
        {

            BankCustomer customer = new BankCustomer();
            BankAccount bank = new BankAccount();

            customer.AddAccount(bank, "TEST");
            customer.AddAccount(new SavingsAccount(), "Test2");
            BankAccount[] bankAccounts = customer.Accounts;

            Assert.AreEqual(2, bankAccounts.Length);






        }








    }
}
