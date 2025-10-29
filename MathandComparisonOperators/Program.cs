using System;


namespace MathandComparisonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate");
            string rate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week");
            string hours1 = Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate");
            string rate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week");
            string hours2 = Console.ReadLine();
            Console.WriteLine("Annual salary of Person 1");
            double salary1 = Convert.ToDouble(rate1) * Convert.ToDouble(hours1) * 52;
            Console.WriteLine(salary1);
            Console.WriteLine("Annual salary of Person 2");
            double salary2 = Convert.ToDouble(rate2) * Convert.ToDouble(hours2) * 52;
            Console.WriteLine(salary2);
            Console.WriteLine("Person 1 makes more money than person 2");
            bool makesMore = salary1 > salary2;
            Console.WriteLine(makesMore);
            Console.ReadLine();
        }
    }
}
