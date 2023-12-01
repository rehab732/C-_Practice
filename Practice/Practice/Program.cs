using Practice.Delegate;
using static Practice.Delegate.Rectangle;

namespace Practice
{
	public class Program
	{
		// public delegate void MultiCast(int x1, int x2);
		static void Main(string[] args)
		{
			#region Indexer
			//var ip = new Indexer();
			//ip[0] = 122;
			//ip[1] = 133;
			//ip[2] = 144;
			//ip[3] = 155;
			//Console.WriteLine(ip.GetIP);
			#endregion



			#region Delegate 
			//List<Employee> employees = new List<Employee> {
			//	new Employee(1, "Rehab Zaki", Gender.Female, 1000),
			//	new Employee(2, "Rehab Ahmed", Gender.Male, 5000),
			//	new Employee(3, "Rehab Mohamed", Gender.Female, 100),
			//	new Employee(4, "Rehab Mahmoud", Gender.Male, 600),
			//	new Employee(5, "Rehab", Gender.Male, 900),
			//};

			//Report report = new Report();
			////till .net framework 2
			//report.Process("Employees with greater than or equal 100", "******************", employees, IsGreater);
			//report.Process("Employees with less than or equal 100", "******************", employees, IsLess);

			////then appeare anonymos delegate 

			//report.Process("anonymous delegate", "========", employees, delegate (Employee e) { return e.TotalSales == 100; });

			////after dot net 3 appeare lamda expression
			//report.Process("Lamda Expression", "--------------", employees, e => e.TotalSales == 5000);


			//Rectangle rect = new Rectangle();

			//rect.GetArea(10, 10);
			//rect.GetPreimeter(10, 10);
			////MultiCast Delegate 
			//RectDelegate dele;
			//dele = rect.GetArea;
			//dele += rect.GetPreimeter;
			//Console.WriteLine("Using delegate");
			//dele(10, 10);
			//Console.WriteLine("Using delegate for unsubscripe");
			//if (dele != null)
			//{
			//	dele -= rect.GetArea;
			//	dele(10, 10);
			//}



			#endregion
		}

		static bool IsGreater(Employee employee) => employee.TotalSales >= 1000;
		static bool IsLess(Employee employee) => employee.TotalSales < 1000;
	}
}
