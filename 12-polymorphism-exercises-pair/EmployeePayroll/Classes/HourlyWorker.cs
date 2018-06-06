using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
	public class HourlyWorker : IWorker
	{
		//Properties

		public double HourlyRate { get; }

		//Cosntructor

		public HourlyWorker(double hourlyRate, string firstName, string lastName)
		{
			this.HourlyRate = hourlyRate;
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		//Interface Code
		public string FirstName  { get; }

		public string LastName { get; }

		public double CalculateWeeklyPay(int hoursWorked)
		{
			double pay = HourlyRate * hoursWorked;

			int overtime = hoursWorked - 40;

			return pay + (HourlyRate * overtime * .5);


		}
	}
}
