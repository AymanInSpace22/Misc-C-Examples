using System;
class HelloWorld 
{
    // similar to 9-6a
  static void Main() 
  {
   Salary[] salaries = new Salary[5];
   int x;
   string entryString;
   for(x = 0; x< salaries.Length; x++)
   {
       salaries[x] = new Salary();
       Console.Write("Enter employee number {0}:  ", x + 1);
       salaries[x].EmployeeNumber + Console.ReadLine();
       
       Console.Write("Enter salary amount:  ");
       entryString = Console.ReadLine();
       salaries[x].Amount = Convert.ToDouble(entryString);
   }
   
   for(x = 0; x < salaries.Length; ++x)
   {
       Console.WriteLine("Employee # {0} Amount: {1} Salary: {2}",
       (x + 1), salaries[x].EmployeeNumber, salaries[x].Amount.ToString("C"));
       Console.WriteLine(" Tax os {0}", salaries[x].Tax.ToString("C"));
   }
   
   
  }
}

class Salary
{
    private double amount;
    private double tax;
    
    public string EmployeeNumber { get; set;}
    
    // constants
    public const double LIMIT = 15000;
    public const double LOWRATE = .20;
    public const double HIGHRATE = 30;
    
    
    
    
    public double Amount
    {
        get
        {
            return amount;
        }    
        set
        {
            amount = value;
            calcTax();
        }
    }
    
    public double Tax
    {
        get
        {
            return tax;
        }
    }
    
    
    private void calcTax()
    {
        if(Amount <= LIMIT)
        {
            tax = Amount * LOWRATE;
        }
        else
        {
            tax = LIMIT * LOWRATE + (Amount - LIMIT) * HIGHRATE;
        }
    }
}
