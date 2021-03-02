using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();
            myNewCar.Make = "BMW";
            myNewCar.Model = "740i";
            myNewCar.Year = 2019;
            myNewCar.Color = "Black";
            double myValue = myNewCar.DetermineMarketValue();

            Console.WriteLine("{0} - {1} - {2} - {3} - {4}", myNewCar.Make, myNewCar.Model, myNewCar.Year, myNewCar.Color,myValue);

            

            Console.ReadKey();
        }

        
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public  double DetermineMarketValue()
        {

            return 1000.00;
        }
    }
}
