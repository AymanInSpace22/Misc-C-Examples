using System;

namespace ConsoleApp2
{
    // this would be similar to 9-4
    class Program
    {
        static void Main(string[] args)
        {
            Square[] squares = new Square[5];
            for(int i = 0; i < 5; i++)
            {
                squares[i] = new Square(i + 1);
                Console.WriteLine("{0}, {1}", squares[i].Side, squares[i].Area);
            }

            Console.ReadKey();
        }
    } 

    class Square
    {
        private int side;
        private int area;

        public int Side
        {
            get
            {
                return side;
            }
        }
        public int Area
        {
            get
            {
                return area;
            }
        }


        public Square(int side)
        {
            this.side = side;
            calcArea();
            
            
        }

        private void calcArea()
        {
            area = side * side;
        }
    }
}
