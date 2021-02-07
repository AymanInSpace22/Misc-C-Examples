using System;
using static System.Console;
class ConvertMilesToKilometers
{
   static void Main()
   {
    // Write your main here.
    Write("Enter number of mies: ");
    double miles = double.Parse(ReadLine());

    double result = ConvertToKilometers(miles);
    WriteLine("{0} miles equals {1:F2} kilometers.", miles, result);

   }
   public static double ConvertToKilometers(double miles)
   {
    // Write your ConvertToKilometers() method here.
    double oneKilometer = 1.60934;
    double result = miles * oneKilometer;
    return result;

   }
}
