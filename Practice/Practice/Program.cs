using Practice.Inheritance;
using Practice.Struct;

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
            //static bool IsGreater(Employee employee) => employee.TotalSales >= 1000;
            //static bool IsLess(Employee employee) => employee.TotalSales < 1000;
            #endregion

            #region Evens
            //Stock stock = new Stock("Ra7oba");
            //stock.Price = 100;
            //stock.onPriceChanged += Stock_onPriceChanged;
            //Console.WriteLine("Price Before Change");
            //Console.WriteLine(stock.Price);
            //Console.WriteLine("Price After Change");
            //stock.ChangeStockPrice(-20);
            //Console.WriteLine(stock.Price);
            #endregion

            #region operator overloading
            //Money m1 = new Money(10);
            //Money m2 = new Money(20);
            //Money m3 = m1 + m2;
            //Console.WriteLine("Amount of M3="+m3.Amount);
            #endregion

            #region struct
            //struct
            Operation operation = new Operation(10, 20);
            //	Console.WriteLine(operation.X);
            //	Console.WriteLine(operation.Y);
            //	Console.WriteLine(operation.sum());


            //	var p1 = new Coords(0, 0);
            //	Console.WriteLine(p1);  // output: (0, 0)

            //	var p2 = p1 with { X = 3 };
            //	Console.WriteLine(p2);  // output: (3, 0)

            //	var p3 = p1 with { X = 1, Y = 4 };
            //	Console.WriteLine(p3);  // output: (1, 4)
            #endregion


            #region inheritance


            Eagle eagle = new Eagle();
            //base class can not access protected members of base class out it's class
            //  eagle.Move();

            //upcasting -==>ref from base refare to subclass
            Animal a = eagle;
            a.Move();


            //downcasting ===>ref from sub to refare to base (must doing casting)
            Eagle e = (Eagle)a;
            e.Fly();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================");
            var eagle2 = new Eagle();
            Animal animal = eagle2;
            //Falcon falcon = animal;
            if(animal is Falcon)
            {
                Console.WriteLine(" falcon");

            }
            else
            {
                Console.WriteLine("Not falcon");
            }


            #endregion

        }

        //private static void Stock_onPriceChanged(Stock stock, int price)
        //{
        //	if (stock.Price > price)
        //	{
        //		Console.ForegroundColor = ConsoleColor.Red;
        //		Console.WriteLine("New Price="+ stock.Price);
        //		Console.WriteLine("Old Price" + price);
        //	}
        //	else if (stock.Price < price)
        //	{
        //		Console.ForegroundColor = ConsoleColor.Green;
        //		Console.WriteLine("New Price=" + stock.Price);
        //		Console.WriteLine("Old Price" + price);
        //	}
        //	else
        //	{
        //		Console.WriteLine("New Price=" + stock.Price);
        //		Console.WriteLine("Old Price" + price);
        //	}
        //}
    }
}
