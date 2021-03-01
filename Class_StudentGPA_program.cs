using System;

namespace GPA_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating an instance or instantiating our class
            // creating two student objects that we assign attributes
            student firstStudent = new student();
            firstStudent.IdNumber = 626;
            firstStudent.LastName = "Griffin";
            firstStudent.Gpa = 2.6;

            student secondStudent = new student();
            secondStudent.IdNumber = 333;
            secondStudent.LastName = "Schmurda";
            secondStudent.Gpa = 3.7;

            // calling out Display() method
            Display(firstStudent);
            Display(secondStudent);

            Console.ReadKey();

        }

        // we create a method that we can call from instead of writelining from the Main()
        public static void Display(student stu)
        {
            // we insert two values just to format our output in a specific manner
            // if the second # is positive then it is right aligned and will take up that many spaces starting from the right
            // if the second # is negative then it is left aligned and there will be whtie space to the right of it
            Console.WriteLine("{0, 5} {1, -10} {2, 6}", stu.IdNumber, stu.LastName, stu.Gpa.ToString("F1"));
        }
    }


    class student
    {
        // fields
        private int idNumber;
        private string lastName;
        private double gpa;

        // local constants
        public const double HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0.0;


        // 3 properties
        // remember properties are just the field name with a capital first initial
        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
            }
        }
        
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public double Gpa
        {
            get
            {
                return gpa;
            }
            set
            {
                if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
                    gpa = value;
                else
                    gpa = LOWEST_GPA;
            }
        }

    }
}
