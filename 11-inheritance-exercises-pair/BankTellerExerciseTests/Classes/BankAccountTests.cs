using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Verify_Deposit_Works()
        {
            //Arrange variables neccesary
            BankAccount bankAccount = new BankAccount();
            int deposit = 50;



            //Deposit
            bankAccount.Deposit(deposit);

            //Assert balance is equal to deposited amount

            Assert.AreEqual(50, bankAccount.Balance);


        }

        [TestMethod]
        public void Verify_Deposit_WorksWithPreviousBalance()
        {

            //Arrange variables neccesary
            BankAccount bankAccount = new BankAccount();
            // initial deposit
            bankAccount.Deposit(50);
            int deposit = 50;



            //Deposit
            bankAccount.Deposit(deposit);

            //Assert balance is equal to previous balance + deposited amount
            Assert.AreEqual(100, bankAccount.Balance);
        }

        [TestMethod]
        public void Verify_Withdraw_Works()
        {

            //Arrange variables needed, initialize balamce to 100

            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(100);
            int withdraw = 50;
            // Withdraw

            bankAccount.Withdraw(withdraw);

            Assert.AreEqual(50, bankAccount.Balance);




        }
        [TestMethod]
        public void Verify_Transfer_Works()
        {


            BankAccount bankAccount = new BankAccount();
            BankAccount transferAcct = new BankAccount();
            bankAccount.Deposit(100);
            int transfer = 50;
            // Withdraw

            bankAccount.Transfer(transferAcct, transfer);

            Assert.AreEqual(50, bankAccount.Balance);
            Assert.AreEqual(50, transferAcct.Balance);


        }
    }
}
