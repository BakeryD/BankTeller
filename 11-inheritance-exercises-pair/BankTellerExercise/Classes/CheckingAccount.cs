using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
	public class CheckingAccount : BankAccount
	{
		//Method (override)

		public override decimal Withdraw(decimal amountToWithdraw)
		{
			if (this.Balance - amountToWithdraw < 0)
			{
                if (this.Balance - amountToWithdraw < -90)
                {
                    Console.WriteLine("You are totaly broke");
                    return this.Balance;

                }
                this.Balance -= 10;
				this.Balance -= amountToWithdraw;

               
            }

			

			return this.Balance;
		}


	}
}
