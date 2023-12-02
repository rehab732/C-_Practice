namespace Practice.OperatorOverLoading
{
	public class Money
	{
		public Money(int m) {
			this.amount = m;
		}
		private int amount;
		public int Amount => this.amount;
		public static Money operator+(Money m1, Money m2)
		{
			Money result = new Money(m1.amount + m2.amount);
			return result;

		}


	}
}
