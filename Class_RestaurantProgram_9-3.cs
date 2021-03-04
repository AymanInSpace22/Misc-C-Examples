using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // four fields - Name, mealAMount, gratuityAmount, and rate(read-only)
            // method that will store my gratuity rate - GetRate()
            // 3 constructors -
            // 1st name, meal amount, rate
            // 2nd name, meal amount
            // 3rd name

            // overload + operator - add two meals together - create a new object


            Restaurant r1 = new Restaurant("Dairy Queen", 25, .20);
            Restaurant r2 = new Restaurant("Cook Out", 15);
            Restaurant r3 = new Restaurant("Sonic");
            Restaurant total = r1 + r2 + r3;
            DisplayMeal(r1);
            DisplayMeal(r2);
            DisplayMeal(r3);
            DisplayTotal(total);

            Console.ReadKey();

        }

        public static void DisplayMeal(Restaurant robj)
        {
            Console.WriteLine("\nMy meal at {0} totaled {1}", robj.Name, robj.MealAMount.ToString("C"));
            Console.WriteLine("Gratuity rate is {0}, Gratuity dollars is {1}", robj.GetRate(), robj.GratuityAmount.ToString("C"));
        }

        public static void DisplayTotal(Restaurant robj)
        {
            Console.WriteLine("My meals totaled {0}", robj.MealAMount.ToString("C"));
        }
    }

    class Restaurant
    {
        readonly double RATE;
        public string Name;
        public double MealAMount;
        public double GratuityAmount;

        // onstructor always same name as your class
        public Restaurant(string name, double mealAMount, double rate)
        {
            Name = name;
            RATE = rate;
            MealAMount = mealAMount;
            GratuityAmount = mealAMount * RATE;
        }

        public Restaurant(string name, double mealAMount) : this(name, mealAMount, 0)
        {
        }

        public Restaurant(string name) : this(name, 0, 0)
        {
        }
       
        public double GetRate()
        {
            return RATE;
        }

        public static Restaurant operator + (Restaurant r1,  Restaurant r2)
        {
            double total = r1.MealAMount + r2.MealAMount;
            Restaurant newobj = new Restaurant("Total", total);
            return newobj;
        }

    }
}
