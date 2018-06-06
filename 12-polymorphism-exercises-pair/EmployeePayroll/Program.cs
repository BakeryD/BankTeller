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
        {
			List<IWorker> employees = new List<IWorker>();

			var greg = new SalaryWorker(10000, "Greg", "Stevenson");
			int hours = 40;
			greg.CalculateWeeklyPay(hours);
			employees.Add(greg);

			var dan = new HourlyWorker(10.00, "Dan", "Higgles");
			hours = 50;
			dan.CalculateWeeklyPay(hours);
			employees.Add(dan);

			var last = new VolunteerWorker("last", "first");
			hours = 20;
			last.CalculateWeeklyPay(hours);
			employees.Add(last);
			
			foreach (var person in employees)
			{
				Console.WriteLine("{0,10}{1,10}{2,10}", "Employee", "Hours", "Pay");

				Console.WriteLine($"{person.LastName}, {person.FirstName}         {hours}             {person.CalculateWeeklyPay(hours)}");
			}


        }

    }
}
