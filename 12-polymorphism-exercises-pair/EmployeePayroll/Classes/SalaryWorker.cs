using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePayroll.Classes;

namespace EmployeePayroll.Classes
{
	public class SalaryWorker : IWorker
	{
		//Property

		public double AnnualSalary { get; }

		//Constructor

		public SalaryWorker(double annualSalary, string firstName, string lastName)
		{
			this.AnnualSalary = annualSalary;
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		//methods and properties brought in by IWorker
		//even though we set teh  properties and methods in our IWorker...still need to "define" those properties/method in each class
		public string FirstName { get; }

		public string LastName {get;}

		public double CalculateWeeklyPay(int hoursWorked)
		{
			double payPerWeek = AnnualSalary / 52;

			return double.Parse(payPerWeek.ToString("#.##"));
		}
	}
}
