using System;

namespace ExceptionHandlingEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 demo = new Class1();
            try
            {
                int result = demo.GranDaddyMethod(4);
                Console.WriteLine($"The value at the given position is {result}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace); 
            }
            
        }
    }


    class Class1
    {
        public int GranDaddyMethod(int postition)
        {
            return Daddymethod(postition);
        }


       public int Daddymethod(int position)
        {
            return GetNumber(position);
        }
        
        
        public int GetNumber(int position)
        {
            int output = 0;
            try
            {
                int[] numbers = new int[] { 1, 4, 7, 2 };
                output = numbers[position];
                return numbers[position];
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            return output;

        }
    }
}
