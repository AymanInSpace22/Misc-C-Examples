using System;
class HelloWorld
{
  static void Main() 
  {
      // creating an instance of the Child class
    Child myChild = new Child();
    // new instantiation. All at the top
    Child myChild2 = new Child();
    
    myChild.Name = "Michael";
    myChild.Age = 40;
    myChild.Married = "Y";
    myChild.NumChild = 2;
    
    // we just made a copy of the first myChild
    myChild2.Name = "Tracey";
    myChild2.Age = 30;
    myChild2.Married = "Y";
    myChild2.NumChild = 5;
    
    // you cant just write the variable. You have to put the myChild in front
    Console.WriteLine("My Child is {0}. Age is {1}.", myChild.Name, myChild.Age);
    Console.WriteLine("Married: {0}. Number of children: {1}.", myChild.Married, myChild.NumChild);
    
    // and here we made a copy of the 2 preceding WriteLines
    Console.WriteLine("My Child is {0}. Age is {1}.", myChild2.Name, myChild2.Age);
    Console.WriteLine("Married: {0}. Number of children: {1}.", myChild2.Married, myChild2.NumChild);
  }
  
 class Child
 {
    public string  Name {get; set; }
    
    public int Age {get; set; }
    
    public string Married { get; set; }
    
    public int NumChild { get; set; }
    
    
    
 }
}
