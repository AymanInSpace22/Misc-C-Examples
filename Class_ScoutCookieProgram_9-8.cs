using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // similar to 9-8

            // create a class for Scoouts
            // prompt the user for 5 objects
            // three fields & properties - troop name, cookie name and sales amount
            // display them in order of cookie sales

            Scouts[] scoutsArray = new Scouts[5];
            int x;
            for(x = 0; x < scoutsArray.Length; ++x)
            {
                scoutsArray[x] = new Scouts();
                Console.Write("Enter Scount Troop Name: ");
                scoutsArray[x].Troop = Console.ReadLine();

                Console.Write("Enter Cookie Name: ");
                scoutsArray[x].Cookie = Console.ReadLine();

                Console.Write("Enter Cookie Sales: ");
                scoutsArray[x].Sales = int.Parse(Console.ReadLine());
            }

            Array.Sort(scoutsArray);

            Console.WriteLine("Sorted Array");
            for(x = 0; x < scoutsArray.Length; ++x)
            {
                Console.WriteLine("{0} Troop for cookie {1} has {2} sales", scoutsArray[x].Troop, scoutsArray[x].Cookie, scoutsArray[x].Sales);
            }

            Console.ReadKey();

        }
    }

    class Scouts : IComparable
    {
        // fields
        private string troop;
        private string cookie;
        private int sales;

        // properties
        public string Troop
        {
            get
            {
                return troop;
            }
            set
            {
                troop = value;
            }
        }

        public string Cookie
        {
            get
            {
                return cookie;
            }
            set
            {
                cookie = value;
            }
        }

        public int Sales
        {
            get
            {
                return sales;
            }
            set
            {
                sales = value;
            }
        }

        // We need to revies this
        int IComparable.CompareTo(object o)
        {
            int returnValue;
            Scouts temp = (Scouts)o;
            if (this.sales > temp.sales)
                returnValue = 1;
            else
                if (this.sales < temp.sales)
                returnValue = -1;
            else
                returnValue = 0;

            return returnValue;
        }

    }
}
