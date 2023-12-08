using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Struct
{
	public struct Student
	{
        //can not give initial value
        //public int id = 10;

        //have paramerterless constructor implicitly and can not override it
        //must be public
        //private Student()
        //{
            
        //}
         
        public int Id;
		public void print()
		{
			Console.WriteLine("Hello in struct value type");
            
		}

	}
    public readonly struct Operation
    {
        private readonly int x;
        private readonly int y;
        public int X => x;
        public int Y => y;
        public Operation(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        public int sum()
        {
            return x + y;
        }
    }
	public readonly struct Coords
	{
		public Coords(double x, double y)
		{
			X = x;
			Y = y;
		}

		public double X { get; init; }
		public double Y { get; init; }

		public override string ToString() => $"({X}, {Y})";
	}

	
}
