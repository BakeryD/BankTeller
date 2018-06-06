using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePayroll.Classes;

namespace EmployeePayroll
{
    public class Program
    {
        static void Main(string[] args)
        {	//hours 
			Random rnd = new Random();

			//total hours worked
			int totalHours = 0;

			//total pay
			
			double totalPay = 0;

			//employee List
			List<IWorker> employees = new List<IWorker>();

			employees.Add(new SalaryWorker(10000, "Greg", "Stevenson"));
			employees.Add(new HourlyWorker(10.00, "Dan", "Higgles"));
			employees.Add(new VolunteerWorker("last", "first"));
			Console.WriteLine("{0,10}{1,15}{2,10}", "Employee", "Hours", "Pay");

			foreach (var person in employees)
			{
				
				int hours = rnd.Next(40, 60);

				Console.WriteLine( $"{person.LastName,10}," + $"{person.FirstName, 5}" + $"{hours, 10}" + $"{person.CalculateWeeklyPay(hours), 10}");
				
				//total hours calculation
				totalHours += hours;
				

				//total pay

				totalPay += person.CalculateWeeklyPay(hours);
				
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine($"Total Hours Worked: {totalHours}");
			Console.WriteLine($"Total pay: {totalPay}");
			
		}

    }
}
