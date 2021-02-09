using System;
class HelloWorld
{
      //When you overload a method. The methods you create can all have the same name, but what matters is the parameter list.
      //If two or more of the methods have the same parameter list. Then there will be an error.
      //Each method can have the same identifier, but at least ONE DIFFERENCE in the parameter list.
      //The program will automatically know which method to use based on the parameters/arguments you input in the called method.
      
      
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
