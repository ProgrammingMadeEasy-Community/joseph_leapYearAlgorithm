using System;

namespace JosephPMETASK3_LeapYearAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static bool IsLeapYear(int year)
            {
                return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            }

            // Example usage:
            Console.WriteLine("Input the Year");
            var year = int.Parse(Console.ReadLine());

            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
    }
}
