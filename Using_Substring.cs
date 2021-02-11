

using System;
class HelloWorld 
{
  static void Main() 
  {
    string price;
    Console.WriteLine("Please enter your price");
    price = Console.ReadLine();
    
    double doublePrice;
    string dollarString = " dollars";
    
    if(price.Substring(0, 1).Equals("$"))
    {
        if(double.TryParse(price.Substring(1,price.Length-1), out doublePrice))
        
        AcceptPrice(doublePrice);
    }
    
    else
    if(price.Substring(price.Length - dollarString.Length, dollarString.Length).Equals(dollarString))
       {
        if(double.TryParse(price.Substring(0,price.Length - 8), out doublePrice))
            AcceptPrice(doublePrice);
       }
  }
  private static void AcceptPrice(double amount)
  {
      Console.WriteLine(amount);
      
  }
  
}
