using System;

namespace ConsoleApp1
{

    // in this program we are overloading constructors
    class Program
    {
        static void Main(string[] args)
        {
            Employee aworker = new Employee();
            Employee anotherWorker = new Employee(234);
            Employee theBoss = new Employee('A');

            // dont be confused
            // the extra number 4 in the placeholder is just there to set the position
            // same thing for 14. you can just take it out if you want
            Console.WriteLine("{0, 4}{1, 14}", aworker.IdNumber, aworker.Salary.ToString("C"));
            Console.WriteLine("{0, 4}{1, 14}", anotherWorker.IdNumber, anotherWorker.Salary.ToString("C"));
            Console.WriteLine("{0, 4}{1, 14}", theBoss.IdNumber, theBoss.Salary.ToString("C"));
        }
    }

    class Employee
    {
        public int IdNumber { get; set; }
        public double Salary { get; set; }

        // these are the overloaded constructors
        // they must all be public and have the same name as the class
        // however, their parameter lists must be different or else it will cause ambiguity
        public Employee()
        {
            IdNumber = 999;
            Salary = 0;
        }

        public Employee(int empId)
        {
            IdNumber = empId;
            Salary = 0;
        }

        public Employee(int empId, double sal)
        {
            IdNumber = empId;
            Salary = sal;
        }

        // with this construcotr, if the object is assigned a charater, then these will be the defualt values
        public Employee(char code)
        {
            IdNumber = 111;
            Salary = 100000;
        }
    }
}
