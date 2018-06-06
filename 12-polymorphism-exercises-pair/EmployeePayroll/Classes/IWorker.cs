using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
	public interface IWorker
	{
		//Properties

		string FirstName { get; }

		string LastName { get; }

		//METHOD

		double CalculateWeeklyPay(int hoursWorked);
		
	}
}
