using System;
using System.Linq;
// Linq = language integrated query
using System.Collections.Generic;




namespace UsingTheLinqNameaspace
{
    class Program
    {
        static void Main(string[] args)
        {
            // generate random numbers
            // instant of the Random class
            Random rand = new Random();

            // create a list of 100 numbers
            List<int> numbers = new List<int>();

            // fill the list with 100 random numbers
            for(int i = 0; i < 100; i++)
            {
                // you can only us .Add for a list. Not an array
                numbers.Add(rand.Next(-10, 110));
            }

            // display the output numbers
            Console.WriteLine("Starting numbers");
            foreach(int number in numbers)
            {
                Console.Write("{0} ", number);
            }


            // LINQ syntax:    
            // var query =      from element in collection
            //                  where condition == true
            //                  orderby element ascending//descending
            //                  select element;



            // reads it like one line -- one semicolon
            var query = from num in numbers
                        select num;

            Console.WriteLine("\n\nAll numbers:");
            foreach(var num in query)
            {

                Console.Write("{0,4}", num);
            }


            // reads it like one line -- one semicolon
            // the numbers is the name of the list
            var query2 = from num in numbers
                         where num >= 0 && num <= 100
                        select num;

            Console.WriteLine("\n\nAll 0 - 100 numbers:");
            foreach (var num in query2)
            {
                Console.Write("{0,4}", num);
            }


            // reads it like one line -- one semicolon
            // the numbers is the name of the list
            var query3 = from num in numbers
                         where num >= 0 && num <= 100
                         orderby num ascending
                         select num;

            Console.WriteLine("\n\nAll 0 - 100 sorted numbers:");
            foreach (var num in query3)
            {
                Console.Write("{0,4}", num);
            }


            // what is the average of numbers greater than 50
            var query4 = from num in numbers
                         where num > 50
                         select num;

            Console.WriteLine("\n\nThe average of number greater than 50 is {0:F}", query4.Average());




            // Numbers over 100
            var query5 = (from num in numbers
                         where num == 100
                         select num).Count();

            Console.WriteLine("\n\nThere were {0} 100s", query5);
        }
    }
}
