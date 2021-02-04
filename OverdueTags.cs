using System;
class HelloWorld 
{
    
    // Program Overdue Tags
    // Prompt the user for number of tags and days late
    // Create a method names DisplayLateFee
    // $10 per day for the first week
    // $20 per day for each additional day
    // Display:
    // "The fee for {0} tags for {1} is {2}"
    
  static void Main()
  {
    int carTags;
    int days = 0;
    Console.Write("Enter number of car tags that are late >> ");
    carTags = int.Parse(Console.ReadLine());
    
    Console.Write("Enter number of days that the {0} car tags are late >> ", carTags);
    days = int.Parse(Console.ReadLine());
    
    DisplayLateFee(carTags, days);
    
    Console.ReadLine();
  }
  
  public static void DisplayLateFee(int carTags, int days)
  {
      const double FEE1 = 10.00;
      const double FEE2 = 20.00;
      const int INCREASE = 7;
      double fee;
      
      if(days <= INCREASE)
      {
          fee = carTags * days * FEE1;
      }
      
      else 
      {
          fee = ((carTags * FEE1 * INCREASE) + (carTags * FEE2 * (days - INCREASE)));
      }
      
      Console.WriteLine("The fee for {0} cartag(s) for {1} day(s) is {2}", carTags, days, fee.ToString("C"));
  }
}
