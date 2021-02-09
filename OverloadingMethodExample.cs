using System;
class HelloWorld
{
      static void Main() 
      {
        Display("Sam", "Green");
        Display(101, "Green");
        Display(101, "Green", 3.76);
        
        
      }
      
      static void Display (string fname, string lname)
      {
          Console.WriteLine(fname + " " + lname);
      }
      
      
      static void Display(int id, string lname)
      {
          Console.WriteLine(id + " " + lname);
      }
  
    
      static void Display(int id, string lname, double gpa)
      {
          Console.WriteLine(id + " " + lname + " " + gpa);
      }
  
}
