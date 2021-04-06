using System;

namespace ExceptionHandlingEx1
{
    // you may have to use conditionals and loops in the traditional way

    class Program
    {
        static void Main(string[] args)
        {

            // this is the original way of doing this
            // traditional error handling
            /*int num;
            do
            {
                Console.WriteLine("Please provide me the denominator");
                num = int.Parse(Console.ReadLine());
            }
            while (num == 0);
            double result = 500 / num;
            Console.WriteLine(result);*/


            // try catch block
            //
            int num;
            Console.WriteLine("Please provide me the denominator");
            num = int.Parse(Console.ReadLine());
            try
            {
                double result = 500 / num;
                Console.WriteLine("This result is {0}", result);
            }
            // this block will only execute if divide by zero exception occurs in the try block
            // ex is the varibale and is pretty generic for an exception
            catch(DivideByZeroException ex)
            {
                // the ToString method provides you more info about the exception. This can be useful to the developer not the user
                // I think ex.message is a built in type
                // either message or ToString
                Console.WriteLine("{0}", ex.Message);
            }

            catch (Exception ex)
            {
                // the ToString method provides you more info about the exception. This can be useful to the developer not the user
                // I think ex.message is a built in type
                // either message or ToString
                Console.WriteLine("{0}", ex.Message);
            }

            Console.WriteLine("I am out of the try-catch block");

            Console.ReadKey();
        }
    }
}
