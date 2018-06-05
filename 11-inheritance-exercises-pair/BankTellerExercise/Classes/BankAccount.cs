﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{ //SUPER CLASS

	public class BankAccount
	{
		//properties

		public string AccountNumber { get; set; }
		public decimal Balance { get; protected set; }


		//METHODS

		public decimal Deposit(decimal amountToDeposit)
		{
			return Balance += amountToDeposit;
		}

		public virtual decimal Withdraw(decimal amountToWithdraw)
		{
			return Balance -= amountToWithdraw;
		}

		public void Transfer(BankAccount destinationAcount, decimal transferAmount)
		{
			destinationAcount.Balance += transferAmount;
		}

		//CONSTRUCTOR

		public BankAccount()
		{
			this.Balance = 0;
		}
	}
}