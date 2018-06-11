using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;


namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class CheckingAccountTests
    {
        [TestMethod]
        public void VerifyOverDraftFee()
        {

            CheckingAccount account = new CheckingAccount();
            account.Withdraw(10);
            Assert.AreEqual(-20, account.Balance);


        }



        [TestMethod]
        public void VerifyOverdraftLimit()
        {
            CheckingAccount account = new CheckingAccount();
            account.Withdraw(100);
            Assert.AreEqual(0, account.Balance);




        }
    }
}
