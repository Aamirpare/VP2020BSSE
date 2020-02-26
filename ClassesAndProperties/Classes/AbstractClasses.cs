using System;

namespace ClassesAndProperties.Classes
{
	public abstract class Employee
	{
		public int EmployeeID { get; set; }
		public string FullName { get; set; }
		public abstract void Print();
	}

	public class Staff : Employee
	{
		public override void Print()
		{
			Console.WriteLine("Employee ID " + EmployeeID);
			Console.WriteLine("Full Name " + FullName);
			Console.WriteLine();
		}
	}

	public class Faculty : Employee
	{
		public string EducationLevel { get; set; }

		public override void Print()
		{
			Console.WriteLine("Employee ID " + EmployeeID);
			Console.WriteLine("Full Name " + FullName);
			Console.WriteLine();
		}
	}

	public class Admin : Employee
	{
		public string Role { get; set; }

		public decimal Salary { get; set; }

		public override void Print()
		{
			Console.WriteLine("Employee ID " + EmployeeID);
			Console.WriteLine("Full Name " + FullName);
			Console.WriteLine("Role " + Role);
			Console.WriteLine("Salary " + Salary);
			Console.WriteLine();
		}
	}
	public static class AbstractDemo
	{
		public static void RunDemo()
		{
			//Can't create an instance of the .....
			//Employee emp1 = new Employee();
			Employee emp;

			emp = new Staff();
			emp.EmployeeID = 10;
			emp.FullName = "sdkafjads";
			emp.Print();

			emp = new Faculty()
			{ 
				EmployeeID	 = 90,
				FullName = "Aamir Pare",
				EducationLevel = "PhD"
			};
			emp.Print();

			emp = new Admin()
			{
				Role = "Assistant Manager",
				EmployeeID = 20,
				FullName = "Javeria Ja"
			};

			emp.Print();

			Console.WriteLine("============================Example 2===================");
			Employee [] employeeList = new Employee[] 
			{ 
				new Admin(){ EmployeeID = 100, FullName = "Sara Khan", Role = "Manager", Salary=60000M },
				new Faculty(){ EmployeeID = 102, FullName = "Rashid Khan", EducationLevel="PhD" },
				new Staff(){ EmployeeID = 103, FullName = "Kareem Kumar" }
			};
			foreach (var e in employeeList)
			{
				e.Print();
			}
			Console.ReadKey();
		}

	}
}
