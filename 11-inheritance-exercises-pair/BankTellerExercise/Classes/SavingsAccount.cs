﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
	public class SavingsAccount : BankAccount
	{
		//METhOD override

		public override decimal Withdraw(decimal amountToWithdraw)
		{
			if (this.Balance < 150)
			{
				this.Balance -= 2;

			}
			if (amountToWithdraw > this.Balance)
			{
				return this.Balance;
			}

			return base.Withdraw(amountToWithdraw);
		}

	}
}