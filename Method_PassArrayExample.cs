using System;
class HelloWorld 
{
    
 /* static void Main() 
  {
      int[] myArray = {1, 5, 10, 15, 20};
      
      
      AddThree(myArray);
      for(int i = 0; i < myArray.Length; i++)
      {
          Console.WriteLine(myArray[i]);
      }

      
  }
  
  private static void AddThree(int[] myNumbers)
  {
        for(int i = 0; i < myNumbers.Length; i++)
        {
            myNumbers[i] += 3;
        }
  }
  

*/





//Example

    static void Main()
    {
        Console.WriteLine("Please enter an integer value");
        int value = int.Parse(Console.ReadLine());
        
        int squared = Sqaure(value);
        int cubed = Cube(value);
        Console.WriteLine("{0} squared = {1}", value, squared);
        Console.WriteLine("{0} cubed = {1}", value, cubed);
    }
    
    private static int Sqaure(int number)
    {
        int answer = number * number;
        return answer;
    }
    
    private static int Cube(int number)
    {
        int answer = Sqaure(number) * number;
        return answer;
    }

}








