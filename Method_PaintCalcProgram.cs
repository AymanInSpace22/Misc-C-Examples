
using System;

namespace MehtodsCOntinued
{
    class Program
    {
        // Paint Program
        // this program allows the user to enter in the price of paint and the amount of wall space and calculates certain costs

        static void Main(string[] args)
        {
            Console.Write("Please enter the square feet of wall space to be painted: ");
            double userWallSpace = double.Parse(Console.ReadLine());

            Console.Write("Please enter the price of paint per gallon: ");
            double priceOfPaint = double.Parse(Console.ReadLine());


            double paintRquired = CalculatePaintRequired(userWallSpace);
            double hoursRequired = CalculateHoursOfLabor(userWallSpace);
            double costOfPaint = CalculateCostOfPaint(priceOfPaint, paintRquired);
            double laborCharges = CalculateLaborCharges(hoursRequired);
            double totalCost = CalculateTotalCost(laborCharges, costOfPaint);

            Console.WriteLine();
            Console.WriteLine("Paint required: {0:F2}", paintRquired);
            Console.WriteLine("Hours required: {0:F2}", hoursRequired);
            Console.WriteLine("Cost of the paint: {0}", costOfPaint.ToString("C"));
            Console.WriteLine("Labor Charges: {0}", laborCharges.ToString("C"));
            Console.WriteLine("Total cost: {0}", totalCost
                .ToString("C"));


        }

        public static double CalculatePaintRequired(double userWallSpace)
        {
            double paintRequired = userWallSpace / 112;
            return paintRequired;
        }

        public static double CalculateHoursOfLabor(double userWallSpcae)
        {
            double hoursRequired = (userWallSpcae / 112) * 8;
            return hoursRequired;
        }

        public static double CalculateCostOfPaint(double priceOfPaint, double gallonsOfPaintRquired)
        {
            double costOfPaint = gallonsOfPaintRquired * priceOfPaint;
            return costOfPaint;
        }

        public static double CalculateLaborCharges(double hoursRequired)
        {
            const double CHARGE_PER_HOUR = 35.00;
            double laborCharges = hoursRequired * CHARGE_PER_HOUR;
            return laborCharges;
        }

        public static double CalculateTotalCost(double laborCharges, double costOfPaint)
        {
            double totalCost = laborCharges + costOfPaint;
            return totalCost;
        }

        //112 sq ft = 1 gallon of paint
        //userWallSpace = ?

    }
}
