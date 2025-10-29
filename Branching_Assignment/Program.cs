using System;
using System.Globalization;


namespace Branching_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //Console writes Welcome message
            Console.WriteLine("What is the package weight?");
            //Console asks user for package weight
            int weight = Convert.ToInt32(Console.ReadLine());
            //Converts weight integer
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                }
            //If user input is greater than 50, console displays error message
            Console.WriteLine("What is the package length?");
            //Asks user package length
            int length = Convert.ToInt32(Console.ReadLine());
            //Converts length to integer
            Console.WriteLine("What is the package width?");
            //Asks user pacakge width
            int width = Convert.ToInt32(Console.ReadLine());
            //Converts width to integer
            Console.WriteLine("What is the package height");
            //Asks user pacakge height
            int height = Convert.ToInt32(Console.ReadLine());
            //Converts height to integer
            if (width + height + length >= 50) //Adds the total of width, length and height and whether it is greater than or equal to 50

            { 
                Console.WriteLine("Package too big to be shipped via Package Express."); 
                }
            //Displays error message if pacakge is too big
            int total = (height * width * length) * weight / 100;
            //Calculates total based on multiplying the total height, width and length multiplied by the weight and then divided by one hundred
            string totalWithDollar = total.ToString("C", CultureInfo.GetCultureInfo("en-US")); //Converts total into dollars
            Console.WriteLine($"Estimated Total for shipping package: {totalWithDollar}"); //Displays total for user
            



        }
    }
}
