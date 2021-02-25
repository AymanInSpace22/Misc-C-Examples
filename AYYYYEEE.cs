using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant R1 = new Restaurant("Dairy Queen", "123 Main St", .15);
            R1.GenerateReceipt();
        }
    }

    class Restaurant
    {
        // fields
        private string name;
        private string address;
        private double gratuityRate;

        // properties
        // must be public
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public double GratuityRate
        {
            get
            {
                return gratuityRate;
            }
            set
            {
                if(value > 0)
                   gratuityRate = value;
            }
        }

        // constructor
        // must be public. and must be the name of the class
        public Restaurant(string name, string address, double gratuityRate)
        {
            Name = name;
            Address = address;
            GratuityRate = gratuityRate;
        }

        // method
        public void GenerateReceipt()
        {
            double price = 0;
            double subtotal = 0;
            double gratuityAmount = 0;
            double grandTotal = 0;
            int people = 0;

            while (price != 999)
            {
                subtotal += price;
                Console.WriteLine("Enter price of a food item or 999 to quit: ");
                price = Convert.ToDouble(Console.ReadLine());
                
            }
            Console.Write("How many people in your party? ");
            people = Convert.ToInt32(Console.ReadLine());
            if(people > 6)
            {
                gratuityAmount = subtotal * gratuityRate;
            }
            grandTotal = subtotal + gratuityAmount;

            Console.WriteLine("Subtotal: {0} ", subtotal.ToString("C"));
            Console.WriteLine("{0} Gratuity: {1}", gratuityRate, gratuityAmount.ToString("C"));
            Console.WriteLine("Grand Total: {0}", grandTotal.ToString("C"));
        }
    }
}
