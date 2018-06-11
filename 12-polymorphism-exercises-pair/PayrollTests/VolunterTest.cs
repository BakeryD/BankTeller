using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll.Classes;

namespace PayrollTests
{
	[TestClass]
	public class VolunterTest
	{
		[TestMethod]
		public void Verify_Volunteers_Not_Paid()
		{
			//arrange varible
			VolunteerWorker volunteer = new VolunteerWorker("testLAst", "testFirst");


			//whats getting tested
			
			double hours = volunteer.CalculateWeeklyPay(10);

			//assert

			Assert.AreEqual(0, hours);



		}
	}
}
