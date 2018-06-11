using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll.Classes;

namespace PayrollTests
{
	[TestClass]
	public class HourlyWorkersTest
	{
		[TestMethod]
		public void Verify_NoOverTime_WeeklyPay()
		{
			//create new hourly worker
			HourlyWorker hourlyWorker = new HourlyWorker(10, "TestFirst", "TestLast");

			double weeklyPay = hourlyWorker.CalculateWeeklyPay(30);

			Assert.AreEqual(300, weeklyPay);

		}

		[TestMethod]
		public void Verify_Overtime_Pay()
		{
			HourlyWorker hourlyWorker = new HourlyWorker(10, "First", "lastName");

			double weeklyPay = hourlyWorker.CalculateWeeklyPay(50);

			Assert.AreEqual(550, weeklyPay);
		}
	}
}
