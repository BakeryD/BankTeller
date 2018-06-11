using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll.Classes;

namespace PayrollTests
{
	[TestClass]
	public class SalaryWorkersTest
	{
		[TestMethod]
		public void Verify_PayPerWeek_For_SalaryWorker()
		{
			//create a new salary worker
			SalaryWorker salaryWorker = new SalaryWorker(52000, "FirstTest", "LastTest");

			double weeklyPay = salaryWorker.CalculateWeeklyPay(10);

			//assert

			Assert.AreEqual(1000, weeklyPay);

		}
	}
}
