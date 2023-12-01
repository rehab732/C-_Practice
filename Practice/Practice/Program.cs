namespace Practice
{
	public class Program
	{
		static void Main(string[] args)
		{
			var ip = new Indexer();
			ip[0] = 122;
			ip[1] = 133;
			ip[2] = 144;
			ip[3] = 155;

			Console.WriteLine(ip.GetIP);
		}
	}
}
