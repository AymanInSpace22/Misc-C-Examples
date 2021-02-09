using System;
class HelloWorld
{
      static void Main() 
      {
        int sum1 = CalcSum(2, 5);
        Console.WriteLine(sum1);
        
        int sum2 = CalcSum(4, 0, -2, 12);
        Console.WriteLine(sum2);
        
        int sum3 = CalcSum();
        Console.WriteLine(sum3);
        
        
      }
      
      static int CalcSum(params int[] elements)
      {
          int sum = 0;
          foreach(int element in elements)
          {
            sum += element;
          } 
            
            return sum;
            
      }
  
  
}
