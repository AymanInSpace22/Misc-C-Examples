using System;
class HelloWorld 
{
    

//This porgram uses a loop to keep asking the user for a number until they enter it in correct format

  static void Main()
  {
    string entryString;
    int score;
    
      Console.Write("Enter yout test score >> ");
      entryString = Console.ReadLine();
     
      While(!int.TryParse(entryString, out score));
      {
          Console.WriteLine("Input data was not formateed correctly");
          Console.Write("Please enter score again >> ");
          entryString = Console.ReadLine();
      }
  }
}
