using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;


namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class SavingsAccountTests
    {
        [TestMethod]
        public void Verify_Cannot_Withdraw_More_Than_Balance()
        {
            SavingsAccount savingsAccount = new SavingsAccount();


            savingsAccount.Withdraw(20);


            Assert.AreEqual(0, savingsAccount.Balance);




        }

        [TestMethod]
        public void Verify_Service_Fee_IsCharged()
        {
            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.Deposit(100);

            savingsAccount.Withdraw(20);


            Assert.AreEqual(78, savingsAccount.Balance);

        }



    }
}
