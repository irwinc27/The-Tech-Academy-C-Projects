using System;


namespace Car_Insurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application for Car Insurance"); //Denotes the topic for the page
            Console.WriteLine("What is your age?"); //Asks the user their age
            int age = Convert.ToInt32(Console.ReadLine()); //Converts their age to an integer   
            Console.WriteLine("Have you ever had a DUI (true or false)"); //Asks user whether had a DUI
            string answer = Console.ReadLine().ToLower(); //Converts all answers of yes or no to lower case
            bool dui = answer == "true";
            Console.WriteLine("How many speeding tickets do you have?"); //Asks user if had any speeding tickets
            int tickets = Convert.ToInt32(Console.ReadLine()); // Converts tickets to an integer
            Console.WriteLine("Qualified:"); // Console writes Qualified
            bool qualified = (age>15) &&!dui && (tickets<=3); // Uses a boolean to work our if user is over 15 years old has a dui and 3 or more tickets
            Console.WriteLine(qualified); // Console writes the answer true or false with parameters given
               

       
        }
    }
}
