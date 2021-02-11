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




//Another example of something you can do with TryParse()

using System;
class HelloWorld 
{
    
    //The TryParse() can return any value you want. Not just 0
    //To do this you must put the if() around it with the Not(!) character in front
    
  static void Main()
  {
    string entryString;
    int score;
    Console.Write("Enter your test score >> ");
    entryString = Console.ReadLine();
    if(!int.TryParse(entryString, out score));
        score = -1;
    Console.WriteLine("You entered {0}", score);
  }
}

