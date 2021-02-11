using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Display(width:1.4, height:1.67, shape:"rectangle");
            //Names Arguments: Thats what this is
            //THis lets you pass the parameters in any order instead of it having to match exactly
            Console.ReadLine();

        }

        //This method includes optional parameters
        //Optional parameters is when you give the parameter a value
        private static void Display(string shape, double width = 1, double height = 1)
        {
            if (width == height && shape.Equals("rectangle"))
                shape = "square";

            shape = shape.ToUpper();
            Console.WriteLine("Area of " + shape + " is: " + (width * height));
        }
    }
}
