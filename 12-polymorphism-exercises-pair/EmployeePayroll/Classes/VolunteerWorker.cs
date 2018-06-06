using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
	public class VolunteerWorker : IWorker 
	{
		//Cosntructor

		public VolunteerWorker(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public string FirstName { get; }

		public string LastName {get;}

		public double CalculateWeeklyPay(int hoursWorked)
		{
			return hoursWorked * 0;
		}
	}
}
