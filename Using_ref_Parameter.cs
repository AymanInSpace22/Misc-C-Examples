using System;
using static System.Console;
class HelloWorld
{
  static void Main() 
  {
    int x = 4;
    WriteLine("In the Main x is {0}", x);
    DisplayReferenceParameter(ref x);
    WriteLine("In Main, x is {0}", x);
  }
  
  private static void DisplayReferenceParameter(ref int number)
  {
      number = 20;
      WriteLine("In method, x is {0}", number);
  }
  
}
