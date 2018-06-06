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
			
			foreach (var person in employees)
			{
				
				int hours = rnd.Next(40, 60);



				Console.WriteLine("{0,10}{1,10}{2,10}", "Employee", "Hours", "Pay");

				Console.WriteLine($"{person.LastName}, {person.FirstName}     {hours}        {person.CalculateWeeklyPay(hours)}");
				
				//total hours calculation
				totalHours += hours;
				Console.WriteLine($"{totalHours}");

				//total pay

				totalPay += person.CalculateWeeklyPay(hours);
				Console.WriteLine($"{totalPay}");
			}


        }

    }
}
