using System;
class HelloWorld 
{
  static void Main() 
  {
   string color = "RED";
   string [] colors = {"RED", "GREEN", "BLUE"};
   
   ReceiverMethod(color);
   Console.WriteLine();
   
   
   Console.WriteLine("Second Call....");
   ReceiverMethod(colors);
      
  }
  
  private static void ReceiverMethod(params string [] colors)
  {
      foreach(string color in colors)
        Console.WriteLine("Color is: " + color);
  }
  
}
