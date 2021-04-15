using System;

namespace BankAccountProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount acct = new BankAccount();
            while (true)
            {

                try
                {
                    //acct.AccountNum = 1234;
                    //acct.Balance = -1000;
                    double balance;
                    Console.WriteLine("Enter a bank balance << ");
                    // whats happening here is that we are outputting a statement, and then we are reading in user input
                    // if the user enters a good value then the loop ends
                    // if the they enter a negative value then the custom negative exception we made will catch it and ask the user to try again
                    // if they enter an incorrect format then the C# format exception will catch it and will continue the loop until successful
                    if (double.TryParse(Console.ReadLine(), out balance))
                    {
                        if (acct.Balance < 0)
                        {
                            throw (new NegativeException());
                        }
                        else
                        {
                            acct.Balance = balance;
                            break;
                        }
                    }
                    else
                        throw (new FormatException("Please enter numeric value"));

                }
                // this is our home made exception
                // C# has a built in negative exception. But we are just practicing making our own
                catch (NegativeException e)
                {
                    //Console.WriteLine(e.Message);
                    //Console.WriteLine(e.StackTrace);
                    Console.WriteLine(e.Message);
                }
                // this is a built in C# exception
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            char answer;
            Console.WriteLine("Your bank balance is {0}", acct.Balance);
            Console.WriteLine("Are you ready to log out? Y/N");
            char.TryParse(Console.ReadLine(), out answer);
            if(answer == 'N')
            {
                Console.WriteLine("Ok. What would you like to do...");
            }
            else
            {
                Console.WriteLine("Thank you for banking with us!");
            }

            Console.ReadLine();
        }
    }


    // here we are creating our own exception
    class NegativeException : Exception
    {
        private static string msg = "Bank balance is negative\n\tnegative number not allowed. ";

        // I think the base is setting your message as the base message for your custom exception
        public NegativeException() : base(msg)
        {

        }
    }


    class BankAccount
    {
        private double balance;
        public int AccountNum { get; set; }
        public double Balance
        {
            get { return balance; }

            set
            {
                if(value < 0)
                {
                    NegativeException nbe = new NegativeException();
                    throw (nbe);
                }
                balance = value;
            }

        }
    }
}
