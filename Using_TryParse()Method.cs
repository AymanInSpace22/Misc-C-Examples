using System;

namespace ConsoleApp1
{
    //Use the TryParse() to retrun a bool (True or False)
    //You must enter two values

    class Program
    {
        static void Main(string[] args)
        {
            string myString = "100";
            int myNum;
            bool result = int.TryParse(myString, out myNum);

            if(result)
            {
                Console.WriteLine("The value of my number is {0}", myNum);
            }
            else
            {
                Console.WriteLine("The format of the integer is invalid");
            }


            Console.ReadLine();
        }
    }
}
