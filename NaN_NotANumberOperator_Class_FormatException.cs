// Declare a Student
// ID must be an integer and gpa must be a double to continue
using System;
using static System.Console;
class DebugEleven04
{
   static void Main()
   {
      Student stu = new Student();
      bool areNumbersGood = false;
      while(!areNumbersGood)
      {
         try
         {
            stu.setID();
            stu.setGPA();
            areNumbersGood = true;
         }
         catch (FormatException e)
         {
            WriteLine(e.Message);
            WriteLine("(Either the student ID or the GPA");
            WriteLine(" was not in the correct format.)");
            WriteLine("You will have to re-enter the student data.");
         }
      }
      WriteLine("Valid student");   
   }
}
public class Student
{
   private int stuId;
   private double stuGpa;
   public void setID()
   {
         string stuNumber;
         Write("Enter student ID ");
         stuNumber = ReadLine();
         stuId = Convert.ToInt32(stuNumber);
    
        //if(stuId !<= 0 || stuId !>= 0)
        // NaN - means not number 
        // I am setting the variable equal to it to see if the user entry is not a number
        // basically im using it to tell whether there is a format exception or not(meaning there was not a numeric value)
        // also you must put  double. before NaN
        // thats pretty much it
        if(stuId == int.NaN)
         throw new FormatException();
     
     
     
   }
   public void setGPA()
   {
         string stuGPAString;
         Write("Enter student GPA ");
         stuGPAString = ReadLine();
         stuGpa = Convert.ToDouble(stuGPAString);
        if(stuGpa == int.NaN)
         throw new FormatException();
      
   }
}   
