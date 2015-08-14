using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new CompanyContext())
			{
				var query = from employee in db.Employees
							orderby employee.FirstName
							select employee;

				Console.WriteLine("All employees:");
				foreach (var employee in query)
				{
					Console.WriteLine("{0}) {1} {2}.", employee.Id, employee.FirstName, employee.LastName);
				}

				Console.ReadKey();
			}
		}
	}
}
