using System;

namespace BookExceptionProgram
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }


    class BookException : Exception
    {

        public BookException(string title, double price, int numPages)
        {

        }

        private static string msg = "For {0}, ratio is invalid.\n...Price is {1} for {2} pages.", title, price, numPages;

        public  BookException() : base(msg)
        {

        }
    }


    class Book
    {
        private string title;
        private string author;
        private double price;
        private int numPages;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public double Price
        {
            get { return price; }
            set 
            { 
                if(value > .10)
                {
                    BookException be = new BookException();
                    throw be;
                }
                Price = value;
            
            }
        }

        public int NumPages
        {
            get { return numPages; }
            set { numPages = value; }
        }
    }
}
