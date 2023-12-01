namespace Practice.Delegate
{
	public class Report
	{
		public delegate bool IlligableSales(Employee e);

		public void Process(string title, string separator,List<Employee> list, IlligableSales isIlligable)
		{
			Console.WriteLine(title);
			Console.WriteLine(separator);

			foreach (Employee e in list)
			{
				if (isIlligable(e))
				{
					Console.WriteLine($" {e.Name} | { e.Gender} | { e.TotalSales}");
				}
			}
			Console.WriteLine("\n\n");
		}

	}
}
