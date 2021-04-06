using System;

namespace ExceptionHandlingEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator = 13;
            int denominator;
            int result;

            int[] nums = { 4, 5, 6 };

            Console.WriteLine("What is the denominator");
            denominator = int.Parse(Console.ReadLine());

            try
            {
                result = numerator / denominator;
                result = nums[numerator];
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                // this is where the final code will go
                // we did not really cover this yet
                // whatever is in this code block will always happen at the very end
            }
        }

        // this is your TryParse
        // TryParse must have the out keyword
        public static bool TryParse(string input, out int number)
        {

            bool returnVal = true;
            try
            {
                number = Convert.ToInt32(input);
            }
            catch(FormatException ex)
            {
                returnVal = false;
                number = 0;
            }

            return returnVal;
        }
    }
}
