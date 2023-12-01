namespace Practice.Delegate
{
	public class Employee
	{
        public Employee(int id,string name,Gender gender,int totalsales)
        {
            Id= id;
			Name= name;
			Gender= gender;
			TotalSales= totalsales;
        }
        public int Id { get; private set; }
		public string Name { get; private set; }
		public Gender Gender { get; private set; }
		public int TotalSales{get; private set; }

	}
}
