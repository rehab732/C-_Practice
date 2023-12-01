namespace Practice.Delegate
{
	public class Rectangle
	{
		public delegate void RectDelegate(int length, int width);

		public void GetArea(int width,int height)
		{
			Console.WriteLine("The Area of Rectangle =" + width * height);
		}
		public void GetPreimeter(int width,int height)
		{
			Console.WriteLine("The Premiter of Rectangle =" + 2*(width + height));

		}
	}
}
