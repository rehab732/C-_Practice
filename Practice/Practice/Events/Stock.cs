namespace Practice.Events
{
    public delegate void ChangeOldPriceHandler(Stock stock, int price);
	public class Stock
	{
        private int price;
		private String stockName;
        public event ChangeOldPriceHandler onPriceChanged;
        public Stock(string stockName)
        {
            this.stockName = stockName;
        }

        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int ChangeStockPrice(int price)
        {
            int oldprice = this.price;
            this.price += price;
            if(onPriceChanged != null)
            {
                onPriceChanged(this, oldprice);//send old price and the object that hold new price
            }
            return this.price;

        }

	}
}
